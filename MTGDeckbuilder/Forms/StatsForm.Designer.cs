namespace MTGDeckbuilder.Forms
{
    partial class StatsForm
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
            this.panelManaCurve = new System.Windows.Forms.Panel();
            this.panelManaCost = new System.Windows.Forms.Panel();
            this.panelCardType = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelManaCurve
            // 
            this.panelManaCurve.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelManaCurve.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelManaCurve.Location = new System.Drawing.Point(0, 420);
            this.panelManaCurve.Name = "panelManaCurve";
            this.panelManaCurve.Size = new System.Drawing.Size(524, 291);
            this.panelManaCurve.TabIndex = 0;
            // 
            // panelManaCost
            // 
            this.panelManaCost.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelManaCost.Location = new System.Drawing.Point(0, 0);
            this.panelManaCost.Name = "panelManaCost";
            this.panelManaCost.Size = new System.Drawing.Size(264, 420);
            this.panelManaCost.TabIndex = 1;
            // 
            // panelCardType
            // 
            this.panelCardType.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelCardType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCardType.Location = new System.Drawing.Point(264, 0);
            this.panelCardType.Name = "panelCardType";
            this.panelCardType.Size = new System.Drawing.Size(260, 420);
            this.panelCardType.TabIndex = 2;
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(524, 711);
            this.Controls.Add(this.panelCardType);
            this.Controls.Add(this.panelManaCost);
            this.Controls.Add(this.panelManaCurve);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelManaCurve;
        private System.Windows.Forms.Panel panelManaCost;
        private System.Windows.Forms.Panel panelCardType;
    }
}