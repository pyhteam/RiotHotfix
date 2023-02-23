namespace RiotHotfix
{
    partial class fmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.nightForm1 = new ReaLTaiizor.Forms.NightForm();
            this.btnDownloadHotfix = new ReaLTaiizor.Controls.LostAcceptButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtStatusBar = new ReaLTaiizor.Controls.ForeverStatusBar();
            this.lostPanel1 = new ReaLTaiizor.Controls.LostPanel();
            this.dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            this.btnExit = new ReaLTaiizor.Controls.LostAcceptButton();
            this.btnCheckVersion = new ReaLTaiizor.Controls.LostAcceptButton();
            this.txtFolderGame = new ReaLTaiizor.Controls.DreamTextBox();
            this.btnPacth = new ReaLTaiizor.Controls.LostAcceptButton();
            this.nightForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.lostPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nightForm1
            // 
            this.nightForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.nightForm1.Controls.Add(this.btnDownloadHotfix);
            this.nightForm1.Controls.Add(this.pictureBox3);
            this.nightForm1.Controls.Add(this.pictureBox2);
            this.nightForm1.Controls.Add(this.pictureBox1);
            this.nightForm1.Controls.Add(this.txtStatusBar);
            this.nightForm1.Controls.Add(this.lostPanel1);
            this.nightForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nightForm1.DrawIcon = true;
            this.nightForm1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nightForm1.HeadColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.nightForm1.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.nightForm1.Location = new System.Drawing.Point(0, 0);
            this.nightForm1.MinimumSize = new System.Drawing.Size(100, 42);
            this.nightForm1.Name = "nightForm1";
            this.nightForm1.Padding = new System.Windows.Forms.Padding(0, 31, 0, 0);
            this.nightForm1.Size = new System.Drawing.Size(604, 307);
            this.nightForm1.TabIndex = 0;
            this.nightForm1.Text = "Riot | League Of Legends Hotfix";
            this.nightForm1.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Left;
            this.nightForm1.TitleBarTextColor = System.Drawing.Color.White;
            this.nightForm1.Click += new System.EventHandler(this.nightForm1_Click);
            // 
            // btnDownloadHotfix
            // 
            this.btnDownloadHotfix.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDownloadHotfix.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDownloadHotfix.ForeColor = System.Drawing.Color.White;
            this.btnDownloadHotfix.HoverColor = System.Drawing.Color.ForestGreen;
            this.btnDownloadHotfix.Image = null;
            this.btnDownloadHotfix.Location = new System.Drawing.Point(213, 5);
            this.btnDownloadHotfix.Name = "btnDownloadHotfix";
            this.btnDownloadHotfix.Size = new System.Drawing.Size(43, 19);
            this.btnDownloadHotfix.TabIndex = 4;
            this.btnDownloadHotfix.Text = "Update";
            this.btnDownloadHotfix.Click += new System.EventHandler(this.btnDownloadHotfix_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RiotHotfix.Properties.Resources.github;
            this.pictureBox3.Location = new System.Drawing.Point(563, 240);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RiotHotfix.Properties.Resources.facebook;
            this.pictureBox2.Location = new System.Drawing.Point(518, 240);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.pictureBox1.Image = global::RiotHotfix.Properties.Resources.logo_1;
            this.pictureBox1.Location = new System.Drawing.Point(421, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txtStatusBar
            // 
            this.txtStatusBar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtStatusBar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStatusBar.ForeColor = System.Drawing.Color.White;
            this.txtStatusBar.Location = new System.Drawing.Point(0, 284);
            this.txtStatusBar.Name = "txtStatusBar";
            this.txtStatusBar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.txtStatusBar.ShowTimeDate = false;
            this.txtStatusBar.Size = new System.Drawing.Size(604, 23);
            this.txtStatusBar.TabIndex = 5;
            this.txtStatusBar.Text = "Version Riot: v12.23.483.5208";
            this.txtStatusBar.TextColor = System.Drawing.Color.White;
            this.txtStatusBar.TimeColor = System.Drawing.Color.White;
            this.txtStatusBar.TimeFormat = "dd.MM.yyyy - HH:mm:ss";
            // 
            // lostPanel1
            // 
            this.lostPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.lostPanel1.Controls.Add(this.dungeonLabel1);
            this.lostPanel1.Controls.Add(this.btnExit);
            this.lostPanel1.Controls.Add(this.btnCheckVersion);
            this.lostPanel1.Controls.Add(this.txtFolderGame);
            this.lostPanel1.Controls.Add(this.btnPacth);
            this.lostPanel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lostPanel1.ForeColor = System.Drawing.Color.White;
            this.lostPanel1.Location = new System.Drawing.Point(12, 44);
            this.lostPanel1.Name = "lostPanel1";
            this.lostPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.lostPanel1.ShowText = true;
            this.lostPanel1.Size = new System.Drawing.Size(379, 128);
            this.lostPanel1.TabIndex = 4;
            // 
            // dungeonLabel1
            // 
            this.dungeonLabel1.AutoSize = true;
            this.dungeonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dungeonLabel1.ForeColor = System.Drawing.Color.White;
            this.dungeonLabel1.Location = new System.Drawing.Point(13, 10);
            this.dungeonLabel1.Name = "dungeonLabel1";
            this.dungeonLabel1.Size = new System.Drawing.Size(147, 20);
            this.dungeonLabel1.TabIndex = 1;
            this.dungeonLabel1.Text = "Choose Folder Game";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverColor = System.Drawing.Color.ForestGreen;
            this.btnExit.Image = null;
            this.btnExit.Location = new System.Drawing.Point(260, 68);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 32);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCheckVersion
            // 
            this.btnCheckVersion.BackColor = System.Drawing.Color.Coral;
            this.btnCheckVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheckVersion.ForeColor = System.Drawing.Color.White;
            this.btnCheckVersion.HoverColor = System.Drawing.Color.ForestGreen;
            this.btnCheckVersion.Image = null;
            this.btnCheckVersion.Location = new System.Drawing.Point(113, 68);
            this.btnCheckVersion.Name = "btnCheckVersion";
            this.btnCheckVersion.Size = new System.Drawing.Size(141, 32);
            this.btnCheckVersion.TabIndex = 3;
            this.btnCheckVersion.Text = "Check new version";
            this.btnCheckVersion.Click += new System.EventHandler(this.btnCheckVersion_Click);
            // 
            // txtFolderGame
            // 
            this.txtFolderGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtFolderGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFolderGame.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtFolderGame.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtFolderGame.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtFolderGame.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtFolderGame.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtFolderGame.ColorF = System.Drawing.Color.Black;
            this.txtFolderGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.txtFolderGame.Location = new System.Drawing.Point(13, 33);
            this.txtFolderGame.Name = "txtFolderGame";
            this.txtFolderGame.Size = new System.Drawing.Size(345, 29);
            this.txtFolderGame.TabIndex = 2;
            this.txtFolderGame.Click += new System.EventHandler(this.txtFolderGame_Click);
            // 
            // btnPacth
            // 
            this.btnPacth.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPacth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPacth.ForeColor = System.Drawing.Color.White;
            this.btnPacth.HoverColor = System.Drawing.Color.ForestGreen;
            this.btnPacth.Image = null;
            this.btnPacth.Location = new System.Drawing.Point(13, 68);
            this.btnPacth.Name = "btnPacth";
            this.btnPacth.Size = new System.Drawing.Size(94, 32);
            this.btnPacth.TabIndex = 3;
            this.btnPacth.Text = "Pacth";
            this.btnPacth.Click += new System.EventHandler(this.btnPacth_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 307);
            this.Controls.Add(this.nightForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1040);
            this.MinimumSize = new System.Drawing.Size(126, 50);
            this.Name = "fmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Riot | League Of Legends Hotfix";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.nightForm1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.lostPanel1.ResumeLayout(false);
            this.lostPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Forms.NightForm nightForm1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.ForeverStatusBar txtStatusBar;
        private ReaLTaiizor.Controls.LostPanel lostPanel1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.LostAcceptButton btnCheckVersion;
        private ReaLTaiizor.Controls.DreamTextBox txtFolderGame;
        private ReaLTaiizor.Controls.LostAcceptButton btnPacth;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.LostAcceptButton btnExit;
        private ReaLTaiizor.Controls.LostAcceptButton btnDownloadHotfix;
    }
}