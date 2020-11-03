namespace TS3VersionChecker
{
    partial class VersionList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VersionList));
            this.dgvVersions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVersions)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVersions
            // 
            this.dgvVersions.AllowUserToAddRows = false;
            this.dgvVersions.AllowUserToDeleteRows = false;
            this.dgvVersions.AllowUserToResizeColumns = false;
            this.dgvVersions.AllowUserToResizeRows = false;
            this.dgvVersions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVersions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVersions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVersions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVersions.Location = new System.Drawing.Point(0, 0);
            this.dgvVersions.Name = "dgvVersions";
            this.dgvVersions.ReadOnly = true;
            this.dgvVersions.Size = new System.Drawing.Size(1122, 588);
            this.dgvVersions.TabIndex = 0;
            this.dgvVersions.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvVersions_DataBindingComplete);
            this.dgvVersions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvVersions_KeyDown);
            // 
            // VersionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 588);
            this.Controls.Add(this.dgvVersions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VersionList";
            this.Text = "Versionsliste";
            this.Load += new System.EventHandler(this.VersionList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVersions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVersions;
    }
}