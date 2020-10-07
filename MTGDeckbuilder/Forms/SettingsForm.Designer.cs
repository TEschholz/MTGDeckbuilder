namespace MTGDeckbuilder.Forms
{
    partial class SettingsForm
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
            this.lblDeckFolder = new System.Windows.Forms.Label();
            this.lblFormat = new System.Windows.Forms.Label();
            this.fbdDeckFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDeckFolder = new System.Windows.Forms.Button();
            this.txtDeckFolder = new System.Windows.Forms.TextBox();
            this.cmbFormat = new System.Windows.Forms.ComboBox();
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.lblView = new System.Windows.Forms.Label();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.lblCardSource = new System.Windows.Forms.Label();
            this.txtCardSource = new System.Windows.Forms.TextBox();
            this.btnCardSource = new System.Windows.Forms.Button();
            this.lblDownload = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.progressBarDownload = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblDeckFolder
            // 
            this.lblDeckFolder.AutoSize = true;
            this.lblDeckFolder.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeckFolder.Location = new System.Drawing.Point(12, 10);
            this.lblDeckFolder.Name = "lblDeckFolder";
            this.lblDeckFolder.Size = new System.Drawing.Size(158, 16);
            this.lblDeckFolder.TabIndex = 0;
            this.lblDeckFolder.Text = "Deck-Ordner angeben:";
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormat.Location = new System.Drawing.Point(12, 80);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(127, 16);
            this.lblFormat.TabIndex = 1;
            this.lblFormat.Text = "Standard-Format:";
            // 
            // btnDeckFolder
            // 
            this.btnDeckFolder.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeckFolder.Location = new System.Drawing.Point(228, 41);
            this.btnDeckFolder.Name = "btnDeckFolder";
            this.btnDeckFolder.Size = new System.Drawing.Size(80, 20);
            this.btnDeckFolder.TabIndex = 2;
            this.btnDeckFolder.Text = "Auswählen";
            this.btnDeckFolder.UseVisualStyleBackColor = true;
            this.btnDeckFolder.Click += new System.EventHandler(this.btnDeckFolder_Click);
            // 
            // txtDeckFolder
            // 
            this.txtDeckFolder.Location = new System.Drawing.Point(15, 41);
            this.txtDeckFolder.Name = "txtDeckFolder";
            this.txtDeckFolder.Size = new System.Drawing.Size(207, 20);
            this.txtDeckFolder.TabIndex = 3;
            // 
            // cmbFormat
            // 
            this.cmbFormat.FormattingEnabled = true;
            this.cmbFormat.Location = new System.Drawing.Point(15, 111);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(293, 21);
            this.cmbFormat.TabIndex = 4;
            // 
            // cmbView
            // 
            this.cmbView.FormattingEnabled = true;
            this.cmbView.Location = new System.Drawing.Point(15, 182);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(293, 21);
            this.cmbView.TabIndex = 6;
            // 
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblView.Location = new System.Drawing.Point(12, 150);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(130, 16);
            this.lblView.TabIndex = 5;
            this.lblView.Text = "Standard-Ansicht:";
            // 
            // cmbSort
            // 
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Location = new System.Drawing.Point(15, 252);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(293, 21);
            this.cmbSort.TabIndex = 8;
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.Location = new System.Drawing.Point(12, 220);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(149, 16);
            this.lblSort.TabIndex = 7;
            this.lblSort.Text = "Standard-Sortierung:";
            // 
            // lblCardSource
            // 
            this.lblCardSource.AutoSize = true;
            this.lblCardSource.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardSource.Location = new System.Drawing.Point(12, 290);
            this.lblCardSource.Name = "lblCardSource";
            this.lblCardSource.Size = new System.Drawing.Size(152, 16);
            this.lblCardSource.TabIndex = 9;
            this.lblCardSource.Text = "Quelle für alle Karten:";
            // 
            // txtCardSource
            // 
            this.txtCardSource.Location = new System.Drawing.Point(15, 322);
            this.txtCardSource.Name = "txtCardSource";
            this.txtCardSource.Size = new System.Drawing.Size(207, 20);
            this.txtCardSource.TabIndex = 12;
            // 
            // btnCardSource
            // 
            this.btnCardSource.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCardSource.Location = new System.Drawing.Point(228, 321);
            this.btnCardSource.Name = "btnCardSource";
            this.btnCardSource.Size = new System.Drawing.Size(80, 20);
            this.btnCardSource.TabIndex = 11;
            this.btnCardSource.Text = "Auswählen";
            this.btnCardSource.UseVisualStyleBackColor = true;
            // 
            // lblDownload
            // 
            this.lblDownload.AutoSize = true;
            this.lblDownload.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDownload.Location = new System.Drawing.Point(12, 360);
            this.lblDownload.Name = "lblDownload";
            this.lblDownload.Size = new System.Drawing.Size(195, 16);
            this.lblDownload.TabIndex = 13;
            this.lblDownload.Text = "Karten erneut herunterladen";
            // 
            // btnDownload
            // 
            this.btnDownload.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Location = new System.Drawing.Point(228, 358);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(80, 20);
            this.btnDownload.TabIndex = 14;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // progressBarDownload
            // 
            this.progressBarDownload.Location = new System.Drawing.Point(15, 384);
            this.progressBarDownload.Name = "progressBarDownload";
            this.progressBarDownload.Size = new System.Drawing.Size(293, 23);
            this.progressBarDownload.TabIndex = 15;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 566);
            this.Controls.Add(this.progressBarDownload);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.lblDownload);
            this.Controls.Add(this.txtCardSource);
            this.Controls.Add(this.btnCardSource);
            this.Controls.Add(this.lblCardSource);
            this.Controls.Add(this.cmbSort);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.cmbView);
            this.Controls.Add(this.lblView);
            this.Controls.Add(this.cmbFormat);
            this.Controls.Add(this.txtDeckFolder);
            this.Controls.Add(this.btnDeckFolder);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.lblDeckFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeckFolder;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.FolderBrowserDialog fbdDeckFolder;
        private System.Windows.Forms.Button btnDeckFolder;
        private System.Windows.Forms.TextBox txtDeckFolder;
        private System.Windows.Forms.ComboBox cmbFormat;
        private System.Windows.Forms.ComboBox cmbView;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.Label lblCardSource;
        private System.Windows.Forms.TextBox txtCardSource;
        private System.Windows.Forms.Button btnCardSource;
        private System.Windows.Forms.Label lblDownload;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.ProgressBar progressBarDownload;
    }
}