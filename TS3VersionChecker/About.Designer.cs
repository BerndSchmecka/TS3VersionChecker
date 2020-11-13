namespace TS3VersionChecker
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.label1 = new System.Windows.Forms.Label();
            this.tcLayout = new System.Windows.Forms.TabControl();
            this.tpAbout = new System.Windows.Forms.TabPage();
            this.lblBuild = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLibraries = new System.Windows.Forms.TabPage();
            this.libPanel = new System.Windows.Forms.Panel();
            this.ProtoBufLink = new System.Windows.Forms.LinkLabel();
            this.ProtoBufAuthor = new System.Windows.Forms.Label();
            this.ProtoBufVersion = new System.Windows.Forms.Label();
            this.NaClLink = new System.Windows.Forms.LinkLabel();
            this.CEFredistLink = new System.Windows.Forms.LinkLabel();
            this.NaClAuthor = new System.Windows.Forms.Label();
            this.CEFredistVersion = new System.Windows.Forms.Label();
            this.NaClVersion = new System.Windows.Forms.Label();
            this.CEFredistAuthor = new System.Windows.Forms.Label();
            this.CEFLink = new System.Windows.Forms.LinkLabel();
            this.CEFVersion = new System.Windows.Forms.Label();
            this.CEFAuthor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SVGLink = new System.Windows.Forms.LinkLabel();
            this.SVGVersion = new System.Windows.Forms.Label();
            this.SVGAuthor = new System.Windows.Forms.Label();
            this.JsonLink = new System.Windows.Forms.LinkLabel();
            this.JsonAuthor = new System.Windows.Forms.Label();
            this.JsonVersion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbJson = new System.Windows.Forms.PictureBox();
            this.pbProtoBuf = new System.Windows.Forms.PictureBox();
            this.pbNaCl = new System.Windows.Forms.PictureBox();
            this.pbCEFredist = new System.Windows.Forms.PictureBox();
            this.pbCEF = new System.Windows.Forms.PictureBox();
            this.pbSVG = new System.Windows.Forms.PictureBox();
            this.tcLayout.SuspendLayout();
            this.tpAbout.SuspendLayout();
            this.tbLibraries.SuspendLayout();
            this.libPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProtoBuf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNaCl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCEFredist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCEF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSVG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copyright © 2020 Dunkelmann";
            // 
            // tcLayout
            // 
            this.tcLayout.Controls.Add(this.tpAbout);
            this.tcLayout.Controls.Add(this.tbLibraries);
            this.tcLayout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcLayout.Location = new System.Drawing.Point(12, 12);
            this.tcLayout.Name = "tcLayout";
            this.tcLayout.SelectedIndex = 0;
            this.tcLayout.Size = new System.Drawing.Size(425, 179);
            this.tcLayout.TabIndex = 1;
            // 
            // tpAbout
            // 
            this.tpAbout.Controls.Add(this.pictureBox1);
            this.tpAbout.Controls.Add(this.lblBuild);
            this.tpAbout.Controls.Add(this.label5);
            this.tpAbout.Controls.Add(this.lblVersion);
            this.tpAbout.Controls.Add(this.label3);
            this.tpAbout.Controls.Add(this.label2);
            this.tpAbout.Location = new System.Drawing.Point(4, 24);
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tpAbout.Size = new System.Drawing.Size(417, 151);
            this.tpAbout.TabIndex = 0;
            this.tpAbout.Text = "About";
            this.tpAbout.UseVisualStyleBackColor = true;
            // 
            // lblBuild
            // 
            this.lblBuild.AutoSize = true;
            this.lblBuild.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuild.Location = new System.Drawing.Point(63, 73);
            this.lblBuild.Name = "lblBuild";
            this.lblBuild.Size = new System.Drawing.Size(29, 15);
            this.lblBuild.TabIndex = 5;
            this.lblBuild.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Build:";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(63, 53);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(29, 15);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Version:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "TS3VersionChecker";
            // 
            // tbLibraries
            // 
            this.tbLibraries.Controls.Add(this.libPanel);
            this.tbLibraries.Location = new System.Drawing.Point(4, 24);
            this.tbLibraries.Name = "tbLibraries";
            this.tbLibraries.Padding = new System.Windows.Forms.Padding(3);
            this.tbLibraries.Size = new System.Drawing.Size(417, 151);
            this.tbLibraries.TabIndex = 1;
            this.tbLibraries.Text = "Used Libraries";
            this.tbLibraries.UseVisualStyleBackColor = true;
            // 
            // libPanel
            // 
            this.libPanel.AutoScroll = true;
            this.libPanel.Controls.Add(this.pbJson);
            this.libPanel.Controls.Add(this.JsonLink);
            this.libPanel.Controls.Add(this.JsonAuthor);
            this.libPanel.Controls.Add(this.JsonVersion);
            this.libPanel.Controls.Add(this.pbProtoBuf);
            this.libPanel.Controls.Add(this.ProtoBufLink);
            this.libPanel.Controls.Add(this.ProtoBufAuthor);
            this.libPanel.Controls.Add(this.ProtoBufVersion);
            this.libPanel.Controls.Add(this.pbNaCl);
            this.libPanel.Controls.Add(this.NaClLink);
            this.libPanel.Controls.Add(this.pbCEFredist);
            this.libPanel.Controls.Add(this.CEFredistLink);
            this.libPanel.Controls.Add(this.NaClAuthor);
            this.libPanel.Controls.Add(this.CEFredistVersion);
            this.libPanel.Controls.Add(this.NaClVersion);
            this.libPanel.Controls.Add(this.CEFredistAuthor);
            this.libPanel.Controls.Add(this.pbCEF);
            this.libPanel.Controls.Add(this.CEFLink);
            this.libPanel.Controls.Add(this.CEFVersion);
            this.libPanel.Controls.Add(this.CEFAuthor);
            this.libPanel.Controls.Add(this.pbSVG);
            this.libPanel.Controls.Add(this.label4);
            this.libPanel.Controls.Add(this.SVGLink);
            this.libPanel.Controls.Add(this.SVGVersion);
            this.libPanel.Controls.Add(this.SVGAuthor);
            this.libPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libPanel.Location = new System.Drawing.Point(3, 3);
            this.libPanel.Name = "libPanel";
            this.libPanel.Size = new System.Drawing.Size(411, 145);
            this.libPanel.TabIndex = 4;
            // 
            // ProtoBufLink
            // 
            this.ProtoBufLink.AutoSize = true;
            this.ProtoBufLink.Location = new System.Drawing.Point(76, 346);
            this.ProtoBufLink.Name = "ProtoBufLink";
            this.ProtoBufLink.Size = new System.Drawing.Size(257, 15);
            this.ProtoBufLink.TabIndex = 19;
            this.ProtoBufLink.TabStop = true;
            this.ProtoBufLink.Text = "https://github.com/protobuf-net/protobuf-net";
            this.ProtoBufLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ProtoBufLink_LinkClicked);
            // 
            // ProtoBufAuthor
            // 
            this.ProtoBufAuthor.AutoSize = true;
            this.ProtoBufAuthor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProtoBufAuthor.Location = new System.Drawing.Point(76, 331);
            this.ProtoBufAuthor.Name = "ProtoBufAuthor";
            this.ProtoBufAuthor.Size = new System.Drawing.Size(89, 15);
            this.ProtoBufAuthor.TabIndex = 18;
            this.ProtoBufAuthor.Text = "by Marc Gravell";
            // 
            // ProtoBufVersion
            // 
            this.ProtoBufVersion.AutoSize = true;
            this.ProtoBufVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProtoBufVersion.Location = new System.Drawing.Point(76, 316);
            this.ProtoBufVersion.Name = "ProtoBufVersion";
            this.ProtoBufVersion.Size = new System.Drawing.Size(118, 15);
            this.ProtoBufVersion.TabIndex = 17;
            this.ProtoBufVersion.Text = "protobuf-net 3.0.52";
            // 
            // NaClLink
            // 
            this.NaClLink.AutoSize = true;
            this.NaClLink.Location = new System.Drawing.Point(76, 276);
            this.NaClLink.Name = "NaClLink";
            this.NaClLink.Size = new System.Drawing.Size(259, 15);
            this.NaClLink.TabIndex = 15;
            this.NaClLink.TabStop = true;
            this.NaClLink.Text = "https://github.com/adamcaudill/libsodium-net";
            this.NaClLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NaClLink_LinkClicked);
            // 
            // CEFredistLink
            // 
            this.CEFredistLink.AutoSize = true;
            this.CEFredistLink.Location = new System.Drawing.Point(76, 206);
            this.CEFredistLink.Name = "CEFredistLink";
            this.CEFredistLink.Size = new System.Drawing.Size(218, 15);
            this.CEFredistLink.TabIndex = 11;
            this.CEFredistLink.TabStop = true;
            this.CEFredistLink.Text = "https://github.com/cefsharp/cef-binary";
            this.CEFredistLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CEFredistLink_LinkClicked);
            // 
            // NaClAuthor
            // 
            this.NaClAuthor.AutoSize = true;
            this.NaClAuthor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NaClAuthor.Location = new System.Drawing.Point(76, 261);
            this.NaClAuthor.Name = "NaClAuthor";
            this.NaClAuthor.Size = new System.Drawing.Size(88, 15);
            this.NaClAuthor.TabIndex = 14;
            this.NaClAuthor.Text = "by adamcaudill";
            // 
            // CEFredistVersion
            // 
            this.CEFredistVersion.AutoSize = true;
            this.CEFredistVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEFredistVersion.Location = new System.Drawing.Point(76, 176);
            this.CEFredistVersion.Name = "CEFredistVersion";
            this.CEFredistVersion.Size = new System.Drawing.Size(238, 15);
            this.CEFredistVersion.TabIndex = 9;
            this.CEFredistVersion.Text = "Chromium Embedded Framework 85.3.13";
            // 
            // NaClVersion
            // 
            this.NaClVersion.AutoSize = true;
            this.NaClVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NaClVersion.Location = new System.Drawing.Point(76, 246);
            this.NaClVersion.Name = "NaClVersion";
            this.NaClVersion.Size = new System.Drawing.Size(121, 15);
            this.NaClVersion.TabIndex = 13;
            this.NaClVersion.Text = "libsodium-net 0.10.0";
            // 
            // CEFredistAuthor
            // 
            this.CEFredistAuthor.AutoSize = true;
            this.CEFredistAuthor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CEFredistAuthor.Location = new System.Drawing.Point(76, 191);
            this.CEFredistAuthor.Name = "CEFredistAuthor";
            this.CEFredistAuthor.Size = new System.Drawing.Size(270, 15);
            this.CEFredistAuthor.TabIndex = 10;
            this.CEFredistAuthor.Text = "by The Chromium Embedded Framework Authors";
            // 
            // CEFLink
            // 
            this.CEFLink.AutoSize = true;
            this.CEFLink.Location = new System.Drawing.Point(76, 136);
            this.CEFLink.Name = "CEFLink";
            this.CEFLink.Size = new System.Drawing.Size(212, 15);
            this.CEFLink.TabIndex = 7;
            this.CEFLink.TabStop = true;
            this.CEFLink.Text = "https://github.com/cefsharp/CefSharp";
            this.CEFLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CEFLink_LinkClicked);
            // 
            // CEFVersion
            // 
            this.CEFVersion.AutoSize = true;
            this.CEFVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEFVersion.Location = new System.Drawing.Point(76, 106);
            this.CEFVersion.Name = "CEFVersion";
            this.CEFVersion.Size = new System.Drawing.Size(109, 15);
            this.CEFVersion.TabIndex = 5;
            this.CEFVersion.Text = "CefSharp 85.3.130";
            // 
            // CEFAuthor
            // 
            this.CEFAuthor.AutoSize = true;
            this.CEFAuthor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CEFAuthor.Location = new System.Drawing.Point(76, 121);
            this.CEFAuthor.Name = "CEFAuthor";
            this.CEFAuthor.Size = new System.Drawing.Size(138, 15);
            this.CEFAuthor.TabIndex = 6;
            this.CEFAuthor.Text = "by The CefSharp Authors";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Used Libraries:";
            // 
            // SVGLink
            // 
            this.SVGLink.AutoSize = true;
            this.SVGLink.Location = new System.Drawing.Point(76, 74);
            this.SVGLink.Name = "SVGLink";
            this.SVGLink.Size = new System.Drawing.Size(164, 15);
            this.SVGLink.TabIndex = 3;
            this.SVGLink.TabStop = true;
            this.SVGLink.Text = "https://github.com/vvvv/SVG";
            this.SVGLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SVGLink_LinkClicked);
            // 
            // SVGVersion
            // 
            this.SVGVersion.AutoSize = true;
            this.SVGVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SVGVersion.Location = new System.Drawing.Point(76, 29);
            this.SVGVersion.Name = "SVGVersion";
            this.SVGVersion.Size = new System.Drawing.Size(58, 15);
            this.SVGVersion.TabIndex = 1;
            this.SVGVersion.Text = "Svg 3.1.1";
            // 
            // SVGAuthor
            // 
            this.SVGAuthor.AutoSize = true;
            this.SVGAuthor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SVGAuthor.Location = new System.Drawing.Point(76, 44);
            this.SVGAuthor.Name = "SVGAuthor";
            this.SVGAuthor.Size = new System.Drawing.Size(271, 30);
            this.SVGAuthor.TabIndex = 2;
            this.SVGAuthor.Text = "by davescriven,jvenema,mrbean-bremen,H1Gdev,\r\nowaits,ddpruitt,Ralf1108,Tebjan Hal" +
    "m,and others";
            // 
            // JsonLink
            // 
            this.JsonLink.AutoSize = true;
            this.JsonLink.Location = new System.Drawing.Point(76, 416);
            this.JsonLink.Name = "JsonLink";
            this.JsonLink.Size = new System.Drawing.Size(191, 15);
            this.JsonLink.TabIndex = 23;
            this.JsonLink.TabStop = true;
            this.JsonLink.Text = "https://www.newtonsoft.com/json";
            this.JsonLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.JsonLink_LinkClicked);
            // 
            // JsonAuthor
            // 
            this.JsonAuthor.AutoSize = true;
            this.JsonAuthor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.JsonAuthor.Location = new System.Drawing.Point(76, 401);
            this.JsonAuthor.Name = "JsonAuthor";
            this.JsonAuthor.Size = new System.Drawing.Size(129, 15);
            this.JsonAuthor.TabIndex = 22;
            this.JsonAuthor.Text = "by James Newton-King";
            // 
            // JsonVersion
            // 
            this.JsonVersion.AutoSize = true;
            this.JsonVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JsonVersion.Location = new System.Drawing.Point(76, 386);
            this.JsonVersion.Name = "JsonVersion";
            this.JsonVersion.Size = new System.Drawing.Size(138, 15);
            this.JsonVersion.TabIndex = 21;
            this.JsonVersion.Text = "Newtonsoft.Json 12.0.3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TS3VersionChecker.Properties.Resources.TSVC_1281;
            this.pictureBox1.Location = new System.Drawing.Point(277, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pbJson
            // 
            this.pbJson.Image = global::TS3VersionChecker.Properties.Resources.icon;
            this.pbJson.Location = new System.Drawing.Point(6, 376);
            this.pbJson.Name = "pbJson";
            this.pbJson.Size = new System.Drawing.Size(64, 64);
            this.pbJson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbJson.TabIndex = 24;
            this.pbJson.TabStop = false;
            // 
            // pbProtoBuf
            // 
            this.pbProtoBuf.Image = global::TS3VersionChecker.Properties.Resources.protobuf;
            this.pbProtoBuf.Location = new System.Drawing.Point(6, 306);
            this.pbProtoBuf.Name = "pbProtoBuf";
            this.pbProtoBuf.Size = new System.Drawing.Size(64, 64);
            this.pbProtoBuf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProtoBuf.TabIndex = 20;
            this.pbProtoBuf.TabStop = false;
            // 
            // pbNaCl
            // 
            this.pbNaCl.Image = global::TS3VersionChecker.Properties.Resources.salt;
            this.pbNaCl.Location = new System.Drawing.Point(6, 236);
            this.pbNaCl.Name = "pbNaCl";
            this.pbNaCl.Size = new System.Drawing.Size(64, 64);
            this.pbNaCl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNaCl.TabIndex = 16;
            this.pbNaCl.TabStop = false;
            // 
            // pbCEFredist
            // 
            this.pbCEFredist.Image = global::TS3VersionChecker.Properties.Resources.Chromium_Embedded_Framework_Logo;
            this.pbCEFredist.Location = new System.Drawing.Point(6, 166);
            this.pbCEFredist.Name = "pbCEFredist";
            this.pbCEFredist.Size = new System.Drawing.Size(64, 64);
            this.pbCEFredist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCEFredist.TabIndex = 12;
            this.pbCEFredist.TabStop = false;
            // 
            // pbCEF
            // 
            this.pbCEF.Image = global::TS3VersionChecker.Properties.Resources.logo;
            this.pbCEF.Location = new System.Drawing.Point(6, 96);
            this.pbCEF.Name = "pbCEF";
            this.pbCEF.Size = new System.Drawing.Size(64, 64);
            this.pbCEF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCEF.TabIndex = 8;
            this.pbCEF.TabStop = false;
            // 
            // pbSVG
            // 
            this.pbSVG.Image = global::TS3VersionChecker.Properties.Resources.svg;
            this.pbSVG.Location = new System.Drawing.Point(6, 25);
            this.pbSVG.Name = "pbSVG";
            this.pbSVG.Size = new System.Drawing.Size(64, 64);
            this.pbSVG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSVG.TabIndex = 4;
            this.pbSVG.TabStop = false;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 221);
            this.Controls.Add(this.tcLayout);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            this.tcLayout.ResumeLayout(false);
            this.tpAbout.ResumeLayout(false);
            this.tpAbout.PerformLayout();
            this.tbLibraries.ResumeLayout(false);
            this.libPanel.ResumeLayout(false);
            this.libPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProtoBuf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNaCl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCEFredist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCEF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSVG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tcLayout;
        private System.Windows.Forms.TabPage tpAbout;
        private System.Windows.Forms.TabPage tbLibraries;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBuild;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SVGVersion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SVGAuthor;
        private System.Windows.Forms.LinkLabel SVGLink;
        private System.Windows.Forms.Panel libPanel;
        private System.Windows.Forms.PictureBox pbSVG;
        private System.Windows.Forms.PictureBox pbCEF;
        private System.Windows.Forms.LinkLabel CEFLink;
        private System.Windows.Forms.Label CEFVersion;
        private System.Windows.Forms.Label CEFAuthor;
        private System.Windows.Forms.PictureBox pbCEFredist;
        private System.Windows.Forms.LinkLabel CEFredistLink;
        private System.Windows.Forms.Label CEFredistVersion;
        private System.Windows.Forms.Label CEFredistAuthor;
        private System.Windows.Forms.PictureBox pbNaCl;
        private System.Windows.Forms.LinkLabel NaClLink;
        private System.Windows.Forms.Label NaClAuthor;
        private System.Windows.Forms.Label NaClVersion;
        private System.Windows.Forms.PictureBox pbProtoBuf;
        private System.Windows.Forms.LinkLabel ProtoBufLink;
        private System.Windows.Forms.Label ProtoBufAuthor;
        private System.Windows.Forms.Label ProtoBufVersion;
        private System.Windows.Forms.PictureBox pbJson;
        private System.Windows.Forms.LinkLabel JsonLink;
        private System.Windows.Forms.Label JsonAuthor;
        private System.Windows.Forms.Label JsonVersion;
    }
}