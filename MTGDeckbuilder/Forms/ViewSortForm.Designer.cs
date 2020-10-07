namespace MTGDeckbuilder.Forms
{
    partial class ViewSortForm
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
            this.lblViews = new System.Windows.Forms.Label();
            this.lblSorting = new System.Windows.Forms.Label();
            this.panelView = new System.Windows.Forms.Panel();
            this.panelSorting = new System.Windows.Forms.Panel();
            this.panelView.SuspendLayout();
            this.panelSorting.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblViews
            // 
            this.lblViews.AutoSize = true;
            this.lblViews.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViews.Location = new System.Drawing.Point(12, 9);
            this.lblViews.Name = "lblViews";
            this.lblViews.Size = new System.Drawing.Size(79, 16);
            this.lblViews.TabIndex = 0;
            this.lblViews.Text = "Ansichten:";
            // 
            // lblSorting
            // 
            this.lblSorting.AutoSize = true;
            this.lblSorting.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSorting.Location = new System.Drawing.Point(12, 12);
            this.lblSorting.Name = "lblSorting";
            this.lblSorting.Size = new System.Drawing.Size(82, 16);
            this.lblSorting.TabIndex = 1;
            this.lblSorting.Text = "Sortierung:";
            // 
            // panelView
            // 
            this.panelView.Controls.Add(this.lblViews);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelView.Location = new System.Drawing.Point(0, 0);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(450, 250);
            this.panelView.TabIndex = 3;
            // 
            // panelSorting
            // 
            this.panelSorting.Controls.Add(this.lblSorting);
            this.panelSorting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSorting.Location = new System.Drawing.Point(0, 250);
            this.panelSorting.Name = "panelSorting";
            this.panelSorting.Size = new System.Drawing.Size(450, 250);
            this.panelSorting.TabIndex = 4;
            // 
            // ViewSortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 500);
            this.Controls.Add(this.panelSorting);
            this.Controls.Add(this.panelView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewSortForm";
            this.Text = "ViewSortForm";
            this.panelView.ResumeLayout(false);
            this.panelView.PerformLayout();
            this.panelSorting.ResumeLayout(false);
            this.panelSorting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblViews;
        private System.Windows.Forms.Label lblSorting;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Panel panelSorting;
    }
}