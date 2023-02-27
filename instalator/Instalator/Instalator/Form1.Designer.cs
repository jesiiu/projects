namespace Instalator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.browsers = new System.Windows.Forms.GroupBox();
            this.opera = new System.Windows.Forms.RadioButton();
            this.mozilla = new System.Windows.Forms.RadioButton();
            this.chrome = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.gpudrivers = new System.Windows.Forms.GroupBox();
            this.nvidia = new System.Windows.Forms.RadioButton();
            this.amd = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.discord = new System.Windows.Forms.CheckBox();
            this.apps = new System.Windows.Forms.GroupBox();
            this.notepad = new System.Windows.Forms.CheckBox();
            this.teamviewer = new System.Windows.Forms.CheckBox();
            this.zip = new System.Windows.Forms.CheckBox();
            this.winrar = new System.Windows.Forms.CheckBox();
            this.spotify = new System.Windows.Forms.CheckBox();
            this.teams = new System.Windows.Forms.CheckBox();
            this.java = new System.Windows.Forms.CheckBox();
            this.netflix = new System.Windows.Forms.CheckBox();
            this.ccleaner = new System.Windows.Forms.CheckBox();
            this.gamesapps = new System.Windows.Forms.GroupBox();
            this.epic = new System.Windows.Forms.CheckBox();
            this.uconnect = new System.Windows.Forms.CheckBox();
            this.gog = new System.Windows.Forms.CheckBox();
            this.steam = new System.Windows.Forms.CheckBox();
            this.origin = new System.Windows.Forms.CheckBox();
            this.games = new System.Windows.Forms.Label();
            this.systeminfo = new System.Windows.Forms.GroupBox();
            this.hwmonitor = new System.Windows.Forms.CheckBox();
            this.powermax = new System.Windows.Forms.CheckBox();
            this.cpuz = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.exitapp = new System.Windows.Forms.Button();
            this.browsers.SuspendLayout();
            this.gpudrivers.SuspendLayout();
            this.apps.SuspendLayout();
            this.gamesapps.SuspendLayout();
            this.systeminfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose browser: ";
            // 
            // browsers
            // 
            this.browsers.Controls.Add(this.opera);
            this.browsers.Controls.Add(this.mozilla);
            this.browsers.Controls.Add(this.chrome);
            this.browsers.Location = new System.Drawing.Point(30, 36);
            this.browsers.Name = "browsers";
            this.browsers.Size = new System.Drawing.Size(142, 99);
            this.browsers.TabIndex = 1;
            this.browsers.TabStop = false;
            this.browsers.Text = "Choose browser: ";
            // 
            // opera
            // 
            this.opera.AutoSize = true;
            this.opera.Location = new System.Drawing.Point(6, 72);
            this.opera.Name = "opera";
            this.opera.Size = new System.Drawing.Size(75, 19);
            this.opera.TabIndex = 4;
            this.opera.Tag = "https://www.opera.com/pl/computer/thanks?ni=eapgx&os=windows";
            this.opera.Text = "Opera GX";
            this.opera.UseVisualStyleBackColor = true;
            // 
            // mozilla
            // 
            this.mozilla.AutoSize = true;
            this.mozilla.Location = new System.Drawing.Point(6, 47);
            this.mozilla.Name = "mozilla";
            this.mozilla.Size = new System.Drawing.Size(102, 19);
            this.mozilla.TabIndex = 3;
            this.mozilla.Tag = "https://download.mozilla.org/?product=firefox-msi-latest-ssl&amp;os=win64&amp;lan" +
    "g=pl";
            this.mozilla.Text = "Mozilla Firefox";
            this.mozilla.UseVisualStyleBackColor = true;
            // 
            // chrome
            // 
            this.chrome.AutoSize = true;
            this.chrome.Location = new System.Drawing.Point(6, 22);
            this.chrome.Name = "chrome";
            this.chrome.Size = new System.Drawing.Size(109, 19);
            this.chrome.TabIndex = 2;
            this.chrome.Tag = "https://www.google.com/chrome/?brand=BNSD&gclid=Cj0KCQiAxoiQBhCRARIsAPsvo-z7gOWHG" +
    "VcdH_lIfyf59qQuck19r5b4mDJ5xhlDesgmWPNhvfSyMtAaAmhUEALw_wcB&gclsrc=aw.ds";
            this.chrome.Text = "Google Chrome";
            this.chrome.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Install";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gpudrivers
            // 
            this.gpudrivers.Controls.Add(this.nvidia);
            this.gpudrivers.Controls.Add(this.amd);
            this.gpudrivers.Location = new System.Drawing.Point(30, 205);
            this.gpudrivers.Name = "gpudrivers";
            this.gpudrivers.Size = new System.Drawing.Size(142, 78);
            this.gpudrivers.TabIndex = 3;
            this.gpudrivers.TabStop = false;
            this.gpudrivers.Text = "Choose drivers:";
            // 
            // nvidia
            // 
            this.nvidia.AutoSize = true;
            this.nvidia.Location = new System.Drawing.Point(4, 47);
            this.nvidia.Name = "nvidia";
            this.nvidia.Size = new System.Drawing.Size(60, 19);
            this.nvidia.TabIndex = 6;
            this.nvidia.Tag = "https://pl.download.nvidia.com/GFE/GFEClient/3.25.0.84/GeForce_Experience_v3.25.0" +
    ".84.exe";
            this.nvidia.Text = "NVidia";
            this.nvidia.UseVisualStyleBackColor = true;
            // 
            // amd
            // 
            this.amd.AutoSize = true;
            this.amd.Location = new System.Drawing.Point(4, 22);
            this.amd.Name = "amd";
            this.amd.Size = new System.Drawing.Size(52, 19);
            this.amd.TabIndex = 5;
            this.amd.Tag = "https://www.amd.com/en/support";
            this.amd.Text = "AMD";
            this.amd.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "GPU Drivers:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Applications:";
            // 
            // discord
            // 
            this.discord.AutoSize = true;
            this.discord.Location = new System.Drawing.Point(6, 23);
            this.discord.Name = "discord";
            this.discord.Size = new System.Drawing.Size(66, 19);
            this.discord.TabIndex = 7;
            this.discord.Tag = "https://discord.com/api/download?platform=win";
            this.discord.Text = "Discord";
            this.discord.UseVisualStyleBackColor = true;
            // 
            // apps
            // 
            this.apps.Controls.Add(this.notepad);
            this.apps.Controls.Add(this.teamviewer);
            this.apps.Controls.Add(this.zip);
            this.apps.Controls.Add(this.winrar);
            this.apps.Controls.Add(this.spotify);
            this.apps.Controls.Add(this.teams);
            this.apps.Controls.Add(this.java);
            this.apps.Controls.Add(this.netflix);
            this.apps.Controls.Add(this.ccleaner);
            this.apps.Location = new System.Drawing.Point(190, 36);
            this.apps.Name = "apps";
            this.apps.Size = new System.Drawing.Size(142, 247);
            this.apps.TabIndex = 8;
            this.apps.TabStop = false;
            this.apps.Text = "Choose apps:";
            // 
            // notepad
            // 
            this.notepad.AutoSize = true;
            this.notepad.Location = new System.Drawing.Point(6, 222);
            this.notepad.Name = "notepad";
            this.notepad.Size = new System.Drawing.Size(88, 19);
            this.notepad.TabIndex = 15;
            this.notepad.Tag = "https://github.com/notepad-plus-plus/notepad-plus-plus/releases/download/v8.2.1/n" +
    "pp.8.2.1.Installer.x64.exe";
            this.notepad.Text = "Notepad++";
            this.notepad.UseVisualStyleBackColor = true;
            // 
            // teamviewer
            // 
            this.teamviewer.AutoSize = true;
            this.teamviewer.Location = new System.Drawing.Point(6, 197);
            this.teamviewer.Name = "teamviewer";
            this.teamviewer.Size = new System.Drawing.Size(89, 19);
            this.teamviewer.TabIndex = 11;
            this.teamviewer.Tag = "https://download.teamviewer.com/download/TeamViewer_Setup_x64.exe";
            this.teamviewer.Text = "TeamViewer";
            this.teamviewer.UseVisualStyleBackColor = true;
            // 
            // zip
            // 
            this.zip.AutoSize = true;
            this.zip.Location = new System.Drawing.Point(6, 172);
            this.zip.Name = "zip";
            this.zip.Size = new System.Drawing.Size(47, 19);
            this.zip.TabIndex = 14;
            this.zip.Tag = "https://www.7-zip.org/a/7z2107-x64.exe";
            this.zip.Text = "7zip";
            this.zip.UseVisualStyleBackColor = true;
            // 
            // winrar
            // 
            this.winrar.AutoSize = true;
            this.winrar.Location = new System.Drawing.Point(6, 147);
            this.winrar.Name = "winrar";
            this.winrar.Size = new System.Drawing.Size(69, 19);
            this.winrar.TabIndex = 13;
            this.winrar.Tag = "https://www.rarlab.com/rar/winrar-x64-601pl.exe";
            this.winrar.Text = "WinRAR";
            this.winrar.UseVisualStyleBackColor = true;
            // 
            // spotify
            // 
            this.spotify.AutoSize = true;
            this.spotify.Location = new System.Drawing.Point(6, 122);
            this.spotify.Name = "spotify";
            this.spotify.Size = new System.Drawing.Size(63, 19);
            this.spotify.TabIndex = 12;
            this.spotify.Tag = "https://www.spotify.com/pl/download/windows/";
            this.spotify.Text = "Spotify";
            this.spotify.UseVisualStyleBackColor = true;
            // 
            // teams
            // 
            this.teams.AutoSize = true;
            this.teams.Location = new System.Drawing.Point(6, 72);
            this.teams.Name = "teams";
            this.teams.Size = new System.Drawing.Size(59, 19);
            this.teams.TabIndex = 11;
            this.teams.Tag = "https://www.microsoft.com/pl-pl/microsoft-teams/download-app#desktopAppDownloadre" +
    "gion";
            this.teams.Text = "Teams";
            this.teams.UseVisualStyleBackColor = true;
            // 
            // java
            // 
            this.java.AutoSize = true;
            this.java.Location = new System.Drawing.Point(6, 47);
            this.java.Name = "java";
            this.java.Size = new System.Drawing.Size(48, 19);
            this.java.TabIndex = 10;
            this.java.Tag = "https://www.java.com/pl/download/";
            this.java.Text = "Java";
            this.java.UseVisualStyleBackColor = true;
            // 
            // netflix
            // 
            this.netflix.AutoSize = true;
            this.netflix.Location = new System.Drawing.Point(6, 97);
            this.netflix.Name = "netflix";
            this.netflix.Size = new System.Drawing.Size(61, 19);
            this.netflix.TabIndex = 9;
            this.netflix.Tag = "https://www.microsoft.com/en-us/p/netflix/9wzdncrfj3tj?cid=msft_web_appsforwindow" +
    "sphone_collection#activetab=pivot:overviewtab";
            this.netflix.Text = "Netflix";
            this.netflix.UseVisualStyleBackColor = true;
            // 
            // ccleaner
            // 
            this.ccleaner.AutoSize = true;
            this.ccleaner.Location = new System.Drawing.Point(6, 22);
            this.ccleaner.Name = "ccleaner";
            this.ccleaner.Size = new System.Drawing.Size(74, 19);
            this.ccleaner.TabIndex = 8;
            this.ccleaner.Tag = "https://www.ccleaner.com/ccleaner/download/standard";
            this.ccleaner.Text = "CCleaner";
            this.ccleaner.UseVisualStyleBackColor = true;
            // 
            // gamesapps
            // 
            this.gamesapps.Controls.Add(this.epic);
            this.gamesapps.Controls.Add(this.uconnect);
            this.gamesapps.Controls.Add(this.gog);
            this.gamesapps.Controls.Add(this.steam);
            this.gamesapps.Controls.Add(this.origin);
            this.gamesapps.Controls.Add(this.discord);
            this.gamesapps.Location = new System.Drawing.Point(360, 36);
            this.gamesapps.Name = "gamesapps";
            this.gamesapps.Size = new System.Drawing.Size(130, 174);
            this.gamesapps.TabIndex = 9;
            this.gamesapps.TabStop = false;
            this.gamesapps.Text = "Choose platform:";
            // 
            // epic
            // 
            this.epic.AutoSize = true;
            this.epic.Location = new System.Drawing.Point(6, 147);
            this.epic.Name = "epic";
            this.epic.Size = new System.Drawing.Size(87, 19);
            this.epic.TabIndex = 16;
            this.epic.Tag = "https://launcher-public-service-prod06.ol.epicgames.com/launcher/api/installer/do" +
    "wnload/EpicGamesLauncherInstaller.msi";
            this.epic.Text = "Epic Games";
            this.epic.UseVisualStyleBackColor = true;
            // 
            // uconnect
            // 
            this.uconnect.AutoSize = true;
            this.uconnect.Location = new System.Drawing.Point(6, 122);
            this.uconnect.Name = "uconnect";
            this.uconnect.Size = new System.Drawing.Size(79, 19);
            this.uconnect.TabIndex = 15;
            this.uconnect.Tag = "https://ubi.li/4vxt9";
            this.uconnect.Text = "UConnect";
            this.uconnect.UseVisualStyleBackColor = true;
            // 
            // gog
            // 
            this.gog.AutoSize = true;
            this.gog.Location = new System.Drawing.Point(6, 97);
            this.gog.Name = "gog";
            this.gog.Size = new System.Drawing.Size(86, 19);
            this.gog.TabIndex = 14;
            this.gog.Tag = "https://webinstallers.gog-statics.com/download/GOG_Galaxy_2.0.exe";
            this.gog.Text = "GOGGalaxy";
            this.gog.UseVisualStyleBackColor = true;
            // 
            // steam
            // 
            this.steam.AutoSize = true;
            this.steam.Location = new System.Drawing.Point(6, 47);
            this.steam.Name = "steam";
            this.steam.Size = new System.Drawing.Size(59, 19);
            this.steam.TabIndex = 13;
            this.steam.Tag = "https://cdn.cloudflare.steamstatic.com/client/installer/SteamSetup.exe";
            this.steam.Text = "Steam";
            this.steam.UseVisualStyleBackColor = true;
            // 
            // origin
            // 
            this.origin.AutoSize = true;
            this.origin.Location = new System.Drawing.Point(6, 71);
            this.origin.Name = "origin";
            this.origin.Size = new System.Drawing.Size(59, 19);
            this.origin.TabIndex = 12;
            this.origin.Tag = "https://www.origin.com/pol/pl-pl/store/download";
            this.origin.Text = "Origin";
            this.origin.UseVisualStyleBackColor = true;
            // 
            // games
            // 
            this.games.AutoSize = true;
            this.games.Location = new System.Drawing.Point(360, 9);
            this.games.Name = "games";
            this.games.Size = new System.Drawing.Size(49, 15);
            this.games.TabIndex = 10;
            this.games.Text = "Games :";
            // 
            // systeminfo
            // 
            this.systeminfo.Controls.Add(this.hwmonitor);
            this.systeminfo.Controls.Add(this.powermax);
            this.systeminfo.Controls.Add(this.cpuz);
            this.systeminfo.Location = new System.Drawing.Point(533, 36);
            this.systeminfo.Name = "systeminfo";
            this.systeminfo.Size = new System.Drawing.Size(134, 99);
            this.systeminfo.TabIndex = 11;
            this.systeminfo.TabStop = false;
            this.systeminfo.Text = "Choose app:";
            // 
            // hwmonitor
            // 
            this.hwmonitor.AutoSize = true;
            this.hwmonitor.Location = new System.Drawing.Point(6, 48);
            this.hwmonitor.Name = "hwmonitor";
            this.hwmonitor.Size = new System.Drawing.Size(89, 19);
            this.hwmonitor.TabIndex = 2;
            this.hwmonitor.Tag = "https://download.cpuid.com/hwmonitor/hwmonitor_1.45.exe";
            this.hwmonitor.Text = "HWMonitor";
            this.hwmonitor.UseVisualStyleBackColor = true;
            // 
            // powermax
            // 
            this.powermax.AutoSize = true;
            this.powermax.Location = new System.Drawing.Point(6, 73);
            this.powermax.Name = "powermax";
            this.powermax.Size = new System.Drawing.Size(82, 19);
            this.powermax.TabIndex = 1;
            this.powermax.Tag = "https://download.cpuid.com/powermax/powermax_1.00_setup.exe";
            this.powermax.Text = "Powermax";
            this.powermax.UseVisualStyleBackColor = true;
            // 
            // cpuz
            // 
            this.cpuz.AutoSize = true;
            this.cpuz.Location = new System.Drawing.Point(6, 22);
            this.cpuz.Name = "cpuz";
            this.cpuz.Size = new System.Drawing.Size(67, 19);
            this.cpuz.TabIndex = 0;
            this.cpuz.Tag = "https://download.cpuid.com/cpu-z/cpu-z_1.99-en.exe";
            this.cpuz.Text = "CPU - Z";
            this.cpuz.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(533, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "System informations:";
            // 
            // exitapp
            // 
            this.exitapp.Location = new System.Drawing.Point(123, 349);
            this.exitapp.Name = "exitapp";
            this.exitapp.Size = new System.Drawing.Size(75, 23);
            this.exitapp.TabIndex = 13;
            this.exitapp.Text = "Exit";
            this.exitapp.UseVisualStyleBackColor = true;
            this.exitapp.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 385);
            this.Controls.Add(this.exitapp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.systeminfo);
            this.Controls.Add(this.games);
            this.Controls.Add(this.gamesapps);
            this.Controls.Add(this.apps);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gpudrivers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.browsers);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Install";
            this.browsers.ResumeLayout(false);
            this.browsers.PerformLayout();
            this.gpudrivers.ResumeLayout(false);
            this.gpudrivers.PerformLayout();
            this.apps.ResumeLayout(false);
            this.apps.PerformLayout();
            this.gamesapps.ResumeLayout(false);
            this.gamesapps.PerformLayout();
            this.systeminfo.ResumeLayout(false);
            this.systeminfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton opera;
        private RadioButton mozilla;
        private RadioButton chrome;
        private Button button1;
        private GroupBox gpudrivers;
        private RadioButton amd;
        private Label label2;
        private RadioButton nvidia;
        private Label label3;
        private CheckBox discord;
        private GroupBox apps;
        private CheckBox spotify;
        private CheckBox teams;
        private CheckBox java;
        private CheckBox netflix;
        private CheckBox ccleaner;
        private GroupBox groupBox4;
        private CheckBox epic;
        private CheckBox uconnect;
        private CheckBox gog;
        private CheckBox steam;
        private CheckBox origin;
        private Label games;
        private CheckBox winrar;
        private CheckBox zip;
        private CheckBox teamviewer;
        private CheckBox notepad;
        private GroupBox groupBox3;
        private Label label4;
        private CheckBox hwmonitor;
        private CheckBox powermax;
        private CheckBox cpuz;
        private Button exitapp;
        private GroupBox systeminfo;
        private GroupBox gamesapps;
        private GroupBox browsers;
    }
}