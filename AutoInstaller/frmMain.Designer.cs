namespace AutoInstaller
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btStartDownloadAndInstall = new System.Windows.Forms.Button();
            this.flpSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.chbLibraries = new System.Windows.Forms.Label();
            this.chbShouldInstallDirectX = new System.Windows.Forms.CheckBox();
            this.chbShouldInstallNetFrameworkRedistributable = new System.Windows.Forms.CheckBox();
            this.chbShouldInstallNetSDK = new System.Windows.Forms.CheckBox();
            this.chbShouldInstallVCRedist = new System.Windows.Forms.CheckBox();
            this.chbShouldInstallJRE = new System.Windows.Forms.CheckBox();
            this.chbShouldInstallAdobeAIR = new System.Windows.Forms.CheckBox();
            this.lbGames = new System.Windows.Forms.Label();
            this.chbShouldInstallSteam = new System.Windows.Forms.CheckBox();
            this.chbShouldInstallEpicGames = new System.Windows.Forms.CheckBox();
            this.lbCommunity = new System.Windows.Forms.Label();
            this.chbShouldInstallTelegram = new System.Windows.Forms.CheckBox();
            this.chbShouldInstallWhatsApp = new System.Windows.Forms.CheckBox();
            this.chbShouldInstallDiscord = new System.Windows.Forms.CheckBox();
            this.lbBrowsers = new System.Windows.Forms.Label();
            this.chbShouldInstallChrome = new System.Windows.Forms.CheckBox();
            this.chbShouldInstallFireFox = new System.Windows.Forms.CheckBox();
            this.chbShouldInstallOpera = new System.Windows.Forms.CheckBox();
            this.lbOther = new System.Windows.Forms.Label();
            this.chbShouldInstalLightshot = new System.Windows.Forms.CheckBox();
            this.chbShouldInstallQBitTorrent = new System.Windows.Forms.CheckBox();
            this.chbShouldInstallWin11MediaPlayer = new System.Windows.Forms.CheckBox();
            this.lbLog = new System.Windows.Forms.Label();
            this.flpSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btStartDownloadAndInstall
            // 
            this.btStartDownloadAndInstall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btStartDownloadAndInstall.Location = new System.Drawing.Point(12, 484);
            this.btStartDownloadAndInstall.Name = "btStartDownloadAndInstall";
            this.btStartDownloadAndInstall.Size = new System.Drawing.Size(285, 49);
            this.btStartDownloadAndInstall.TabIndex = 0;
            this.btStartDownloadAndInstall.Text = "Начать установку";
            this.btStartDownloadAndInstall.UseVisualStyleBackColor = true;
            this.btStartDownloadAndInstall.Click += new System.EventHandler(this.btStartDownloadAndInstall_Click);
            // 
            // flpSettings
            // 
            this.flpSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpSettings.Controls.Add(this.chbLibraries);
            this.flpSettings.Controls.Add(this.chbShouldInstallDirectX);
            this.flpSettings.Controls.Add(this.chbShouldInstallNetFrameworkRedistributable);
            this.flpSettings.Controls.Add(this.chbShouldInstallNetSDK);
            this.flpSettings.Controls.Add(this.chbShouldInstallVCRedist);
            this.flpSettings.Controls.Add(this.chbShouldInstallJRE);
            this.flpSettings.Controls.Add(this.chbShouldInstallAdobeAIR);
            this.flpSettings.Controls.Add(this.lbGames);
            this.flpSettings.Controls.Add(this.chbShouldInstallSteam);
            this.flpSettings.Controls.Add(this.chbShouldInstallEpicGames);
            this.flpSettings.Controls.Add(this.lbCommunity);
            this.flpSettings.Controls.Add(this.chbShouldInstallTelegram);
            this.flpSettings.Controls.Add(this.chbShouldInstallWhatsApp);
            this.flpSettings.Controls.Add(this.chbShouldInstallDiscord);
            this.flpSettings.Controls.Add(this.lbBrowsers);
            this.flpSettings.Controls.Add(this.chbShouldInstallChrome);
            this.flpSettings.Controls.Add(this.chbShouldInstallFireFox);
            this.flpSettings.Controls.Add(this.chbShouldInstallOpera);
            this.flpSettings.Controls.Add(this.lbOther);
            this.flpSettings.Controls.Add(this.chbShouldInstalLightshot);
            this.flpSettings.Controls.Add(this.chbShouldInstallQBitTorrent);
            this.flpSettings.Controls.Add(this.chbShouldInstallWin11MediaPlayer);
            this.flpSettings.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSettings.Location = new System.Drawing.Point(12, 12);
            this.flpSettings.Name = "flpSettings";
            this.flpSettings.Size = new System.Drawing.Size(285, 466);
            this.flpSettings.TabIndex = 4;
            // 
            // chbLibraries
            // 
            this.chbLibraries.AutoSize = true;
            this.chbLibraries.Location = new System.Drawing.Point(3, 0);
            this.chbLibraries.Name = "chbLibraries";
            this.chbLibraries.Size = new System.Drawing.Size(70, 13);
            this.chbLibraries.TabIndex = 15;
            this.chbLibraries.Text = "Библиотеки:";
            // 
            // chbShouldInstallDirectX
            // 
            this.chbShouldInstallDirectX.AutoSize = true;
            this.chbShouldInstallDirectX.Location = new System.Drawing.Point(3, 16);
            this.chbShouldInstallDirectX.Name = "chbShouldInstallDirectX";
            this.chbShouldInstallDirectX.Size = new System.Drawing.Size(130, 17);
            this.chbShouldInstallDirectX.TabIndex = 16;
            this.chbShouldInstallDirectX.Text = "Установить DirectX?";
            this.chbShouldInstallDirectX.UseVisualStyleBackColor = true;
            // 
            // chbShouldInstallNetFrameworkRedistributable
            // 
            this.chbShouldInstallNetFrameworkRedistributable.AutoSize = true;
            this.chbShouldInstallNetFrameworkRedistributable.Location = new System.Drawing.Point(3, 39);
            this.chbShouldInstallNetFrameworkRedistributable.Name = "chbShouldInstallNetFrameworkRedistributable";
            this.chbShouldInstallNetFrameworkRedistributable.Size = new System.Drawing.Size(248, 17);
            this.chbShouldInstallNetFrameworkRedistributable.TabIndex = 18;
            this.chbShouldInstallNetFrameworkRedistributable.Text = "Установить .NET Framework Redistributable?";
            this.chbShouldInstallNetFrameworkRedistributable.UseVisualStyleBackColor = true;
            // 
            // chbShouldInstallNetSDK
            // 
            this.chbShouldInstallNetSDK.AutoSize = true;
            this.chbShouldInstallNetSDK.Location = new System.Drawing.Point(3, 62);
            this.chbShouldInstallNetSDK.Name = "chbShouldInstallNetSDK";
            this.chbShouldInstallNetSDK.Size = new System.Drawing.Size(145, 17);
            this.chbShouldInstallNetSDK.TabIndex = 22;
            this.chbShouldInstallNetSDK.Text = "Установить .NET SDK?";
            this.chbShouldInstallNetSDK.UseVisualStyleBackColor = true;
            // 
            // chbShouldInstallVCRedist
            // 
            this.chbShouldInstallVCRedist.AutoSize = true;
            this.chbShouldInstallVCRedist.Location = new System.Drawing.Point(3, 85);
            this.chbShouldInstallVCRedist.Name = "chbShouldInstallVCRedist";
            this.chbShouldInstallVCRedist.Size = new System.Drawing.Size(142, 17);
            this.chbShouldInstallVCRedist.TabIndex = 20;
            this.chbShouldInstallVCRedist.Text = "Установить VC-Redist?";
            this.chbShouldInstallVCRedist.UseVisualStyleBackColor = true;
            // 
            // chbShouldInstallJRE
            // 
            this.chbShouldInstallJRE.AutoSize = true;
            this.chbShouldInstallJRE.Location = new System.Drawing.Point(3, 108);
            this.chbShouldInstallJRE.Name = "chbShouldInstallJRE";
            this.chbShouldInstallJRE.Size = new System.Drawing.Size(115, 17);
            this.chbShouldInstallJRE.TabIndex = 21;
            this.chbShouldInstallJRE.Text = "Установить JRE?";
            this.chbShouldInstallJRE.UseVisualStyleBackColor = true;
            // 
            // chbShouldInstallAdobeAIR
            // 
            this.chbShouldInstallAdobeAIR.AutoSize = true;
            this.chbShouldInstallAdobeAIR.Location = new System.Drawing.Point(3, 131);
            this.chbShouldInstallAdobeAIR.Name = "chbShouldInstallAdobeAIR";
            this.chbShouldInstallAdobeAIR.Size = new System.Drawing.Size(144, 17);
            this.chbShouldInstallAdobeAIR.TabIndex = 19;
            this.chbShouldInstallAdobeAIR.Text = "Установить AdobeAIR?";
            this.chbShouldInstallAdobeAIR.UseVisualStyleBackColor = true;
            // 
            // lbGames
            // 
            this.lbGames.AutoSize = true;
            this.lbGames.Location = new System.Drawing.Point(3, 151);
            this.lbGames.Name = "lbGames";
            this.lbGames.Size = new System.Drawing.Size(37, 13);
            this.lbGames.TabIndex = 5;
            this.lbGames.Text = "Игры:";
            // 
            // chbShouldInstallSteam
            // 
            this.chbShouldInstallSteam.AutoSize = true;
            this.chbShouldInstallSteam.Location = new System.Drawing.Point(3, 167);
            this.chbShouldInstallSteam.Name = "chbShouldInstallSteam";
            this.chbShouldInstallSteam.Size = new System.Drawing.Size(125, 17);
            this.chbShouldInstallSteam.TabIndex = 0;
            this.chbShouldInstallSteam.Text = "Установить Steam?";
            this.chbShouldInstallSteam.UseVisualStyleBackColor = true;
            // 
            // chbShouldInstallEpicGames
            // 
            this.chbShouldInstallEpicGames.AutoSize = true;
            this.chbShouldInstallEpicGames.Location = new System.Drawing.Point(3, 190);
            this.chbShouldInstallEpicGames.Name = "chbShouldInstallEpicGames";
            this.chbShouldInstallEpicGames.Size = new System.Drawing.Size(152, 17);
            this.chbShouldInstallEpicGames.TabIndex = 1;
            this.chbShouldInstallEpicGames.Text = "Установить Epic Games?";
            this.chbShouldInstallEpicGames.UseVisualStyleBackColor = true;
            // 
            // lbCommunity
            // 
            this.lbCommunity.AutoSize = true;
            this.lbCommunity.Location = new System.Drawing.Point(3, 210);
            this.lbCommunity.Name = "lbCommunity";
            this.lbCommunity.Size = new System.Drawing.Size(57, 13);
            this.lbCommunity.TabIndex = 6;
            this.lbCommunity.Text = "Общение:";
            // 
            // chbShouldInstallTelegram
            // 
            this.chbShouldInstallTelegram.AutoSize = true;
            this.chbShouldInstallTelegram.Location = new System.Drawing.Point(3, 226);
            this.chbShouldInstallTelegram.Name = "chbShouldInstallTelegram";
            this.chbShouldInstallTelegram.Size = new System.Drawing.Size(139, 17);
            this.chbShouldInstallTelegram.TabIndex = 2;
            this.chbShouldInstallTelegram.Text = "Установить Telegram?";
            this.chbShouldInstallTelegram.UseVisualStyleBackColor = true;
            // 
            // chbShouldInstallWhatsApp
            // 
            this.chbShouldInstallWhatsApp.AutoSize = true;
            this.chbShouldInstallWhatsApp.Location = new System.Drawing.Point(3, 249);
            this.chbShouldInstallWhatsApp.Name = "chbShouldInstallWhatsApp";
            this.chbShouldInstallWhatsApp.Size = new System.Drawing.Size(145, 17);
            this.chbShouldInstallWhatsApp.TabIndex = 3;
            this.chbShouldInstallWhatsApp.Text = "Установить WhatsApp?";
            this.chbShouldInstallWhatsApp.UseVisualStyleBackColor = true;
            // 
            // chbShouldInstallDiscord
            // 
            this.chbShouldInstallDiscord.AutoSize = true;
            this.chbShouldInstallDiscord.Location = new System.Drawing.Point(3, 272);
            this.chbShouldInstallDiscord.Name = "chbShouldInstallDiscord";
            this.chbShouldInstallDiscord.Size = new System.Drawing.Size(131, 17);
            this.chbShouldInstallDiscord.TabIndex = 4;
            this.chbShouldInstallDiscord.Text = "Установить Discord?";
            this.chbShouldInstallDiscord.UseVisualStyleBackColor = true;
            // 
            // lbBrowsers
            // 
            this.lbBrowsers.AutoSize = true;
            this.lbBrowsers.Location = new System.Drawing.Point(3, 292);
            this.lbBrowsers.Name = "lbBrowsers";
            this.lbBrowsers.Size = new System.Drawing.Size(60, 13);
            this.lbBrowsers.TabIndex = 7;
            this.lbBrowsers.Text = "Браузеры:";
            // 
            // chbShouldInstallChrome
            // 
            this.chbShouldInstallChrome.AutoSize = true;
            this.chbShouldInstallChrome.Location = new System.Drawing.Point(3, 308);
            this.chbShouldInstallChrome.Name = "chbShouldInstallChrome";
            this.chbShouldInstallChrome.Size = new System.Drawing.Size(168, 17);
            this.chbShouldInstallChrome.TabIndex = 8;
            this.chbShouldInstallChrome.Text = "Установить Google Chrome?";
            this.chbShouldInstallChrome.UseVisualStyleBackColor = true;
            // 
            // chbShouldInstallFireFox
            // 
            this.chbShouldInstallFireFox.AutoSize = true;
            this.chbShouldInstallFireFox.Location = new System.Drawing.Point(3, 331);
            this.chbShouldInstallFireFox.Name = "chbShouldInstallFireFox";
            this.chbShouldInstallFireFox.Size = new System.Drawing.Size(164, 17);
            this.chbShouldInstallFireFox.TabIndex = 9;
            this.chbShouldInstallFireFox.Text = "Установить Mozilla FireFox?";
            this.chbShouldInstallFireFox.UseVisualStyleBackColor = true;
            // 
            // chbShouldInstallOpera
            // 
            this.chbShouldInstallOpera.AutoSize = true;
            this.chbShouldInstallOpera.Location = new System.Drawing.Point(3, 354);
            this.chbShouldInstallOpera.Name = "chbShouldInstallOpera";
            this.chbShouldInstallOpera.Size = new System.Drawing.Size(124, 17);
            this.chbShouldInstallOpera.TabIndex = 10;
            this.chbShouldInstallOpera.Text = "Установить Opera?";
            this.chbShouldInstallOpera.UseVisualStyleBackColor = true;
            // 
            // lbOther
            // 
            this.lbOther.AutoSize = true;
            this.lbOther.Location = new System.Drawing.Point(3, 374);
            this.lbOther.Name = "lbOther";
            this.lbOther.Size = new System.Drawing.Size(65, 13);
            this.lbOther.TabIndex = 11;
            this.lbOther.Text = "Остальное:";
            // 
            // chbShouldInstalLightshot
            // 
            this.chbShouldInstalLightshot.AutoSize = true;
            this.chbShouldInstalLightshot.Location = new System.Drawing.Point(3, 390);
            this.chbShouldInstalLightshot.Name = "chbShouldInstalLightshot";
            this.chbShouldInstalLightshot.Size = new System.Drawing.Size(138, 17);
            this.chbShouldInstalLightshot.TabIndex = 13;
            this.chbShouldInstalLightshot.Text = "Установить Lightshot?";
            this.chbShouldInstalLightshot.UseVisualStyleBackColor = true;
            // 
            // chbShouldInstallQBitTorrent
            // 
            this.chbShouldInstallQBitTorrent.AutoSize = true;
            this.chbShouldInstallQBitTorrent.Location = new System.Drawing.Point(3, 413);
            this.chbShouldInstallQBitTorrent.Name = "chbShouldInstallQBitTorrent";
            this.chbShouldInstallQBitTorrent.Size = new System.Drawing.Size(149, 17);
            this.chbShouldInstallQBitTorrent.TabIndex = 14;
            this.chbShouldInstallQBitTorrent.Text = "Установить QBitTorrent?";
            this.chbShouldInstallQBitTorrent.UseVisualStyleBackColor = true;
            // 
            // chbShouldInstallWin11MediaPlayer
            // 
            this.chbShouldInstallWin11MediaPlayer.AutoSize = true;
            this.chbShouldInstallWin11MediaPlayer.Location = new System.Drawing.Point(3, 436);
            this.chbShouldInstallWin11MediaPlayer.Name = "chbShouldInstallWin11MediaPlayer";
            this.chbShouldInstallWin11MediaPlayer.Size = new System.Drawing.Size(217, 17);
            this.chbShouldInstallWin11MediaPlayer.TabIndex = 12;
            this.chbShouldInstallWin11MediaPlayer.Text = "Установить Медиаплеер Windows11?";
            this.chbShouldInstallWin11MediaPlayer.UseVisualStyleBackColor = true;
            // 
            // lbLog
            // 
            this.lbLog.AutoSize = true;
            this.lbLog.Location = new System.Drawing.Point(178, 504);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(0, 13);
            this.lbLog.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 541);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.flpSettings);
            this.Controls.Add(this.btStartDownloadAndInstall);
            this.MinimumSize = new System.Drawing.Size(325, 580);
            this.Name = "frmMain";
            this.Text = "AutoInstaller";
            this.flpSettings.ResumeLayout(false);
            this.flpSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStartDownloadAndInstall;
        private System.Windows.Forms.FlowLayoutPanel flpSettings;
        private System.Windows.Forms.Label chbLibraries;
        private System.Windows.Forms.CheckBox chbShouldInstallDirectX;
        private System.Windows.Forms.CheckBox chbShouldInstallNetFrameworkRedistributable;
        private System.Windows.Forms.CheckBox chbShouldInstallAdobeAIR;
        private System.Windows.Forms.Label lbGames;
        private System.Windows.Forms.CheckBox chbShouldInstallSteam;
        private System.Windows.Forms.CheckBox chbShouldInstallEpicGames;
        private System.Windows.Forms.Label lbCommunity;
        private System.Windows.Forms.CheckBox chbShouldInstallTelegram;
        private System.Windows.Forms.CheckBox chbShouldInstallWhatsApp;
        private System.Windows.Forms.CheckBox chbShouldInstallDiscord;
        private System.Windows.Forms.Label lbBrowsers;
        private System.Windows.Forms.CheckBox chbShouldInstallChrome;
        private System.Windows.Forms.CheckBox chbShouldInstallFireFox;
        private System.Windows.Forms.CheckBox chbShouldInstallOpera;
        private System.Windows.Forms.Label lbOther;
        private System.Windows.Forms.CheckBox chbShouldInstalLightshot;
        private System.Windows.Forms.CheckBox chbShouldInstallQBitTorrent;
        private System.Windows.Forms.CheckBox chbShouldInstallWin11MediaPlayer;
        private System.Windows.Forms.CheckBox chbShouldInstallVCRedist;
        private System.Windows.Forms.CheckBox chbShouldInstallJRE;
        private System.Windows.Forms.Label lbLog;
        private System.Windows.Forms.CheckBox chbShouldInstallNetSDK;
    }
}

