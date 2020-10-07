namespace MTGDeckbuilder.Forms
{
    partial class SearchForm
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdvancedOptions = new System.Windows.Forms.Button();
            this.panelSearchBar = new System.Windows.Forms.Panel();
            this.panelSearchOptions = new System.Windows.Forms.Panel();
            this.panelSearchResult = new System.Windows.Forms.Panel();
            this.dgvTest = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panelSearchBar.SuspendLayout();
            this.panelSearchOptions.SuspendLayout();
            this.panelSearchResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(12, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(427, 24);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(477, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(26, 24);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "S";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnAdvancedOptions
            // 
            this.btnAdvancedOptions.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAdvancedOptions.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnAdvancedOptions.FlatAppearance.BorderSize = 0;
            this.btnAdvancedOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvancedOptions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdvancedOptions.Location = new System.Drawing.Point(445, 15);
            this.btnAdvancedOptions.Name = "btnAdvancedOptions";
            this.btnAdvancedOptions.Size = new System.Drawing.Size(26, 24);
            this.btnAdvancedOptions.TabIndex = 2;
            this.btnAdvancedOptions.Text = "A";
            this.btnAdvancedOptions.UseVisualStyleBackColor = false;
            this.btnAdvancedOptions.Click += new System.EventHandler(this.btnAdvancedOptions_Click);
            // 
            // panelSearchBar
            // 
            this.panelSearchBar.Controls.Add(this.txtSearch);
            this.panelSearchBar.Controls.Add(this.btnSearch);
            this.panelSearchBar.Controls.Add(this.btnAdvancedOptions);
            this.panelSearchBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchBar.Location = new System.Drawing.Point(0, 0);
            this.panelSearchBar.Name = "panelSearchBar";
            this.panelSearchBar.Size = new System.Drawing.Size(555, 52);
            this.panelSearchBar.TabIndex = 3;
            // 
            // panelSearchOptions
            // 
            this.panelSearchOptions.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelSearchOptions.Controls.Add(this.textBox5);
            this.panelSearchOptions.Controls.Add(this.textBox4);
            this.panelSearchOptions.Controls.Add(this.textBox3);
            this.panelSearchOptions.Controls.Add(this.textBox2);
            this.panelSearchOptions.Controls.Add(this.textBox1);
            this.panelSearchOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchOptions.Location = new System.Drawing.Point(0, 52);
            this.panelSearchOptions.Name = "panelSearchOptions";
            this.panelSearchOptions.Size = new System.Drawing.Size(555, 209);
            this.panelSearchOptions.TabIndex = 4;
            // 
            // panelSearchResult
            // 
            this.panelSearchResult.Controls.Add(this.dgvTest);
            this.panelSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearchResult.Location = new System.Drawing.Point(0, 261);
            this.panelSearchResult.Name = "panelSearchResult";
            this.panelSearchResult.Size = new System.Drawing.Size(555, 450);
            this.panelSearchResult.TabIndex = 5;
            // 
            // dgvTest
            // 
            this.dgvTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTest.Location = new System.Drawing.Point(12, 6);
            this.dgvTest.Name = "dgvTest";
            this.dgvTest.Size = new System.Drawing.Size(531, 432);
            this.dgvTest.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(80, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(30, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(344, 44);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(325, 103);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 4;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(555, 711);
            this.Controls.Add(this.panelSearchResult);
            this.Controls.Add(this.panelSearchOptions);
            this.Controls.Add(this.panelSearchBar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.panelSearchBar.ResumeLayout(false);
            this.panelSearchBar.PerformLayout();
            this.panelSearchOptions.ResumeLayout(false);
            this.panelSearchOptions.PerformLayout();
            this.panelSearchResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdvancedOptions;
        private System.Windows.Forms.Panel panelSearchBar;
        private System.Windows.Forms.Panel panelSearchOptions;
        private System.Windows.Forms.Panel panelSearchResult;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvTest;
    }
}