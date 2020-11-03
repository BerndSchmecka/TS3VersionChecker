namespace TS3VersionChecker
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tsMainForm = new System.Windows.Forms.ToolStrip();
            this.btnDatei = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.vtsslblVersionAddress = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblVersionAddress = new System.Windows.Forms.ToolStripStatusLabel();
            this.seperator01 = new System.Windows.Forms.ToolStripStatusLabel();
            this.vtsslblBadgeAddress = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblBadgeAddress = new System.Windows.Forms.ToolStripStatusLabel();
            this.seperator02 = new System.Windows.Forms.ToolStripStatusLabel();
            this.vtsslblGitAddress = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblGitAddress = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssMainForm = new System.Windows.Forms.StatusStrip();
            this.tsMainForm.SuspendLayout();
            this.ssMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMainForm
            // 
            this.tsMainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.tsMainForm.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDatei});
            this.tsMainForm.Location = new System.Drawing.Point(0, 0);
            this.tsMainForm.Name = "tsMainForm";
            this.tsMainForm.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tsMainForm.Size = new System.Drawing.Size(1541, 25);
            this.tsMainForm.TabIndex = 27;
            this.tsMainForm.Text = "toolStrip1";
            this.tsMainForm.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip1_ItemClicked);
            // 
            // btnDatei
            // 
            this.btnDatei.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.btnDatei.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDatei.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAbout,
            this.btnExit});
            this.btnDatei.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDatei.Name = "btnDatei";
            this.btnDatei.Size = new System.Drawing.Size(47, 22);
            this.btnDatei.Text = "&Datei";
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(180, 22);
            this.btnAbout.Text = "&About";
            this.btnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 22);
            this.btnExit.Text = "&Beenden";
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // vtsslblVersionAddress
            // 
            this.vtsslblVersionAddress.Name = "vtsslblVersionAddress";
            this.vtsslblVersionAddress.Size = new System.Drawing.Size(48, 17);
            this.vtsslblVersionAddress.Text = "Version:";
            // 
            // tsslblVersionAddress
            // 
            this.tsslblVersionAddress.IsLink = true;
            this.tsslblVersionAddress.LinkColor = System.Drawing.Color.DodgerBlue;
            this.tsslblVersionAddress.Name = "tsslblVersionAddress";
            this.tsslblVersionAddress.Size = new System.Drawing.Size(29, 17);
            this.tsslblVersionAddress.Text = "N/A";
            this.tsslblVersionAddress.Click += new System.EventHandler(this.TsslblVersionAddress_Click);
            // 
            // seperator01
            // 
            this.seperator01.Name = "seperator01";
            this.seperator01.Size = new System.Drawing.Size(10, 17);
            this.seperator01.Text = "|";
            // 
            // vtsslblBadgeAddress
            // 
            this.vtsslblBadgeAddress.Name = "vtsslblBadgeAddress";
            this.vtsslblBadgeAddress.Size = new System.Drawing.Size(48, 17);
            this.vtsslblBadgeAddress.Text = "Badges:";
            // 
            // tsslblBadgeAddress
            // 
            this.tsslblBadgeAddress.IsLink = true;
            this.tsslblBadgeAddress.LinkColor = System.Drawing.Color.DodgerBlue;
            this.tsslblBadgeAddress.Name = "tsslblBadgeAddress";
            this.tsslblBadgeAddress.Size = new System.Drawing.Size(29, 17);
            this.tsslblBadgeAddress.Text = "N/A";
            this.tsslblBadgeAddress.Click += new System.EventHandler(this.TsslblBadgeAddress_Click);
            // 
            // seperator02
            // 
            this.seperator02.Name = "seperator02";
            this.seperator02.Size = new System.Drawing.Size(10, 17);
            this.seperator02.Text = "|";
            // 
            // vtsslblGitAddress
            // 
            this.vtsslblGitAddress.Name = "vtsslblGitAddress";
            this.vtsslblGitAddress.Size = new System.Drawing.Size(74, 17);
            this.vtsslblGitAddress.Text = "Versionsliste:";
            // 
            // tsslblGitAddress
            // 
            this.tsslblGitAddress.IsLink = true;
            this.tsslblGitAddress.LinkColor = System.Drawing.Color.DodgerBlue;
            this.tsslblGitAddress.Name = "tsslblGitAddress";
            this.tsslblGitAddress.Size = new System.Drawing.Size(29, 17);
            this.tsslblGitAddress.Text = "N/A";
            this.tsslblGitAddress.Click += new System.EventHandler(this.TsslblGitAddress_Click);
            // 
            // ssMainForm
            // 
            this.ssMainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.ssMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vtsslblVersionAddress,
            this.tsslblVersionAddress,
            this.seperator01,
            this.vtsslblBadgeAddress,
            this.tsslblBadgeAddress,
            this.seperator02,
            this.vtsslblGitAddress,
            this.tsslblGitAddress});
            this.ssMainForm.Location = new System.Drawing.Point(0, 719);
            this.ssMainForm.Name = "ssMainForm";
            this.ssMainForm.Size = new System.Drawing.Size(1541, 22);
            this.ssMainForm.SizingGrip = false;
            this.ssMainForm.TabIndex = 26;
            this.ssMainForm.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1541, 741);
            this.Controls.Add(this.tsMainForm);
            this.Controls.Add(this.ssMainForm);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TeamSpeak Version Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tsMainForm.ResumeLayout(false);
            this.tsMainForm.PerformLayout();
            this.ssMainForm.ResumeLayout(false);
            this.ssMainForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tsMainForm;
        private System.Windows.Forms.ToolStripDropDownButton btnDatei;
        private System.Windows.Forms.ToolStripMenuItem btnAbout;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripStatusLabel vtsslblVersionAddress;
        private System.Windows.Forms.ToolStripStatusLabel tsslblVersionAddress;
        private System.Windows.Forms.ToolStripStatusLabel seperator01;
        private System.Windows.Forms.ToolStripStatusLabel vtsslblBadgeAddress;
        private System.Windows.Forms.ToolStripStatusLabel tsslblBadgeAddress;
        private System.Windows.Forms.ToolStripStatusLabel seperator02;
        private System.Windows.Forms.ToolStripStatusLabel vtsslblGitAddress;
        private System.Windows.Forms.ToolStripStatusLabel tsslblGitAddress;
        private System.Windows.Forms.StatusStrip ssMainForm;
    }
}

