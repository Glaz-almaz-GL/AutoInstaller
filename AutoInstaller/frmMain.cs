using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using File = System.IO.File;

namespace AutoInstaller
{
    public partial class frmMain : Form
    {
        private readonly string InstallersPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Installers");

        private List<string> FilesToDownload = new List<string>();

        public frmMain()
        {
            InitializeComponent();

            var checkBoxes = flpSettings.Controls.OfType<CheckBox>();

            foreach (CheckBox chb in checkBoxes)
            {
                chb.CheckedChanged += chb_CheckedChanged;
            }

            //if (!IsRunAsAdmin())
            //{
            //    ProcessStartInfo proc = new ProcessStartInfo();
            //    proc.UseShellExecute = true;
            //    proc.WorkingDirectory = Environment.CurrentDirectory;
            //    proc.FileName = Application.ExecutablePath;
            //    proc.Verb = "runas";

            //    try
            //    {
            //        Process.Start(proc);
            //        this.Close();
            //    }
            //    catch (Exception ex) { Console.WriteLine(ex.Message); }
            //}
        }

        private static bool IsRunAsAdmin()
        {
            WindowsIdentity id = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(id);

            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void chb_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chb = sender as CheckBox;

            string file = chb.Text.Replace("Установить ", "").Replace(" ", "").Replace("?", "").Trim() + "Setup";
            FilesToDownload.Add(file);
        }

        private async Task StartInstall()
        {
            try
            {
                DownloadManager downloadManager = new DownloadManager(lbLog);

                //foreach (string file in FilesToDownload)
                //{
                //    Console.WriteLine("File: " + file);
                //}

                Directory.CreateDirectory(InstallersPath);

                UpdateUI("Начало скачивания файлов");
                await downloadManager.DownloadAllInstallers(FilesToDownload);

                UpdateUI("Начало запуска установщиков");
                int completed = downloadManager.StartAllInstallers(FilesToDownload);
                int unCompleted = FilesToDownload.Count - completed;

                UpdateUI($"Установка завершена! Успешно установлено: {completed}, Неуспешно: {unCompleted}");
                MessageBox.Show($"Успешно: {completed}, Неуспешно: {unCompleted}\n\nУстановка библиотек и приложений завершена, не забудте установить драйвера для устройства!", "Завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void UpdateUI(string msg)
        {
            if (lbLog.InvokeRequired)
            {
                lbLog.Invoke(new MethodInvoker(() => UpdateUI(msg)));
            }
            else
            {
                Console.WriteLine(msg);
                lbLog.Text = msg;
            }
        }

        private async void btStartDownloadAndInstall_Click(object sender, EventArgs e)
        {
            flpSettings.Enabled = false;
            btStartDownloadAndInstall.Enabled = false;

            await StartInstall();

            flpSettings.Enabled = true;
            btStartDownloadAndInstall.Enabled = true;
        }
    }
}
