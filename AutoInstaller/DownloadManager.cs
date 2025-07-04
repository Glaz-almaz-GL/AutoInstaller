using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoInstaller
{
    public class DownloadManager
    {

        private Label LbLog { get; set; }

        public DownloadManager(Label lbLog)
        {
            LbLog = lbLog;
        }

        private List<string> FilesToDownload { get; set; }

        private readonly Architecture arch = RuntimeInformation.OSArchitecture;
        private readonly string InstallersPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Installers");

        private readonly string NetSdkUrl = "https://dotnet.microsoft.com/en-us/download";

        private readonly Dictionary<string, string> DownloadProgrammInstallers = new Dictionary<string, string>
        {
            { "TelegramSetup", "https://telegram.org/dl/desktop/win64" },
            { "QBitTorrentSetup", "https://www.fosshub.com/qBittorrent.html" },
            { "EpicGamesSetup.msi", "https://launcher-public-service-prod06.ol.epicgames.com/launcher/api/installer/download/EpicGamesLauncherInstaller.msi" },
            { "SteamSetup.exe", "https://cdn.cloudflare.steamstatic.com/client/installer/SteamSetup.exe" },
        };

        private readonly Dictionary<string, string> CppRedistributableDownloadInstallers = new Dictionary<string, string>
        {
            { "VC-RedistX86.exe", "https://aka.ms/vs/17/release/vc_redist.x86.exe" },
            { "VC-RedistX64.exe", "https://aka.ms/vs/17/release/vc_redist.x64.exe"},
            { "VC-RedistArm64.exe", "https://aka.ms/vs/17/release/vc_redist.arm64.exe" }
        };

        private readonly Dictionary<string, string> LibrariesDownloadInstallers = new Dictionary<string, string>
        {
            { "JRE-Windows-Setup.exe", "https://javadl.oracle.com/webapps/download/AutoDL?BundleId=252042_8a1589aa0fe24566b4337beee47c2d29" }
        };

        public async Task DownloadAllInstallers(List<string> filesToDownload)
        {
            FilesToDownload = filesToDownload;

            try
            {
                await DownloadNetSdkAsync();

                await DownloadVCRedistInstallerAsync();

                await DownloadOtherLibrariesInstallersAsync();
                await DownloadOtherInstallersAsync();
            }
            catch (HttpRequestException ex) { MessageBox.Show($"{ex.Message} Попробуйте проверить доступ к интернету", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public int StartAllInstallers(List<string> filesToDownload)
        {
            FilesToDownload = filesToDownload;

            int completed = 0;

            string[] Installers = Directory.GetFiles(InstallersPath, "*.exe", SearchOption.AllDirectories);

            foreach (var installerForLog in Installers)
            {
                Console.WriteLine($"FileName: {installerForLog}");
            }
            foreach (var installerForDownload in FilesToDownload)
            {
                Console.WriteLine($"File To Download: {installerForDownload}");
            }

            foreach (var Installer in Installers.Where(Installer => FilesToDownload.Any(el => el.IndexOf(Path.GetFileNameWithoutExtension(Installer), StringComparison.OrdinalIgnoreCase) >= 0)))
            {
                try
                {
                    UpdateUI($"Идёт установка: {Installer}");
                    string InstallerName = Path.GetFileNameWithoutExtension(Installer);

                    ProcessStartInfo InstallerInfo = new ProcessStartInfo();
                    InstallerInfo.FileName = Installer;
                    InstallerInfo.RedirectStandardOutput = true;
                    InstallerInfo.RedirectStandardError = true;
                    InstallerInfo.UseShellExecute = false;

                    if (InstallerName.Contains("JRE") || InstallerName.Contains("Steam") || InstallerName.Contains("QBitTorrent"))
                    {
                        InstallerInfo.Arguments = "/S";
                    }
                    else if (InstallerName.Contains("VC-Redist") || InstallerName.Contains("SDK") || InstallerName.Equals("EpicGames"))
                    {
                        InstallerInfo.Arguments = "/quiet /install";
                    }
                    else if (InstallerName.Contains("DirectX") || InstallerName.Contains("NetFramework"))
                    {
                        InstallerInfo.Arguments = "/Q";
                    }
                    else if (InstallerName.Contains("AdobeAIR"))
                    {
                        InstallerInfo.Arguments = "-silent";
                    }
                    else if (InstallerName.Contains("Lightshot") || InstallerName.Contains("Telegram"))
                    {
                        InstallerInfo.Arguments = "/verysilent";
                    }

                    Process.Start(InstallerInfo);

                    completed++;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                // Epic Games, qbitTorrent, telegram, discord, whatsapp, nvidia app, amd, win11 медиаплеер, chrome, opera, firefox
            }

            return completed;
        }

        private async Task DownloadOtherLibrariesInstallersAsync()
        {
            try
            {
                foreach (var library in LibrariesDownloadInstallers.Where(library => FilesToDownload.Contains(library.Key)))
                {
                    UpdateUI($"Скачивание {library.Key}");
                    await DownloadFileAsync(library.Key, library.Value);
                }
            }
            catch (HttpRequestException ex) { MessageBox.Show($"{ex.Message} Попробуйте проверить доступ к интернету", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async Task DownloadOtherInstallersAsync()
        {
            try
            {
                foreach (var programmInstaller in DownloadProgrammInstallers.Where(library => FilesToDownload.Contains(library.Key)))
                {
                    UpdateUI($"Скачивание {programmInstaller.Key}");
                    await DownloadFileAsync(programmInstaller.Key, programmInstaller.Value);
                }
            }
            catch (HttpRequestException ex) { MessageBox.Show($"{ex.Message} Попробуйте проверить доступ к интернету", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async Task DownloadVCRedistInstallerAsync()
        {
            try
            {
                if (FilesToDownload.Contains("VC-Redist"))
                {
                    UpdateUI("Скачивание VC-Redist");

                    var CppInstaller = CppRedistributableDownloadInstallers.FirstOrDefault(s => s.Key.Contains(arch.ToString()));

                    await DownloadFileAsync(CppInstaller.Key, CppInstaller.Value);
                }
            }
            catch (HttpRequestException ex) { MessageBox.Show($"{ex.Message} Попробуйте проверить доступ к интернету", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async Task DownloadFileAsync(string fileName, string url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Полный URL файла
                    Uri fileUri = new Uri(url);

                    // Скачиваем файл
                    byte[] fileBytes = await client.GetByteArrayAsync(fileUri);

                    // Сохраняем файл на диск
                    File.WriteAllBytes(Path.Combine(InstallersPath, fileName), fileBytes);

                    UpdateUI($"Скачан файл: {fileName}");
                }
            }
            catch (HttpRequestException ex) { MessageBox.Show($"{ex.Message} Попробуйте проверить доступ к интернету", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async Task DownloadNetSdkAsync()
        {
            try
            {
                if (FilesToDownload.Contains("SDK"))
                {
                    UpdateUI("Скачивание .Net SDK");

                    using (HttpClient client = new HttpClient())
                    {
                        // Получаем содержимое страницы
                        string htmlContent = await client.GetStringAsync(NetSdkUrl);

                        // Парсим HTML с помощью HtmlAgilityPack
                        HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
                        document.LoadHtml(htmlContent);

                        // Находим все элементы <a> с атрибутом data-bi-name="Download"
                        HtmlNodeCollection nodes = document.DocumentNode.SelectNodes("//a[@data-bi-name='Download']");

                        if (nodes != null)
                        {
                            foreach (HtmlNode node in nodes)
                            {
                                // Получаем значение атрибута href
                                string fileName = Path.Combine(InstallersPath, GetSafeFileName(node.InnerText) + ".exe");
                                string href = node.GetAttributeValue("href", string.Empty);

                                if (!string.IsNullOrEmpty(href))
                                {
                                    // Полный URL файла (если href относительный)
                                    Uri fileUri = new Uri(new Uri(NetSdkUrl), href);

                                    // Скачиваем файл
                                    byte[] fileBytes = await client.GetByteArrayAsync(fileUri);

                                    // Сохраняем файл на диск
                                    File.WriteAllBytes(fileName, fileBytes);

                                    UpdateUI($"Скачан файл: {fileName}");
                                }
                            }
                        }
                        else
                        {
                            UpdateUI("Элементы <a> с атрибутом data-bi-name=\"Download\" не найдены.");
                        }
                    }
                }
            }
            catch (HttpRequestException ex) { MessageBox.Show($"{ex.Message} Попробуйте проверить доступ к интернету", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private static string GetSafeFileName(string fileName)
        {
            return new string(fileName.Where(c => !Path.GetInvalidFileNameChars().Contains(c)).ToArray());
        }

        public void UpdateUI(string msg)
        {
            if (LbLog.InvokeRequired)
            {
                LbLog.Invoke(new MethodInvoker(() => UpdateUI(msg)));
            }
            else
            {
                Console.WriteLine(msg);
                LbLog.Text = msg;
            }
        }
    }
}
