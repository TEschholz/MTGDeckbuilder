namespace MTGDeckbuilder
{
    partial class MainForm
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSlideForm = new System.Windows.Forms.Panel();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnDecks = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnViewSort = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMain.Location = new System.Drawing.Point(451, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(704, 750);
            this.panelMain.TabIndex = 5;
            // 
            // panelSlideForm
            // 
            this.panelSlideForm.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelSlideForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlideForm.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSlideForm.Location = new System.Drawing.Point(71, 0);
            this.panelSlideForm.Name = "panelSlideForm";
            this.panelSlideForm.Size = new System.Drawing.Size(380, 750);
            this.panelSlideForm.TabIndex = 4;
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelSideMenu.Controls.Add(this.btnSave);
            this.panelSideMenu.Controls.Add(this.btnExport);
            this.panelSideMenu.Controls.Add(this.btnDecks);
            this.panelSideMenu.Controls.Add(this.btnSettings);
            this.panelSideMenu.Controls.Add(this.btnStats);
            this.panelSideMenu.Controls.Add(this.btnViewSort);
            this.panelSideMenu.Controls.Add(this.btnSearch);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(71, 750);
            this.panelSideMenu.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(0, 558);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 48);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExport
            // 
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExport.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(0, 606);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(71, 48);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnDecks
            // 
            this.btnDecks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDecks.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecks.Location = new System.Drawing.Point(0, 654);
            this.btnDecks.Name = "btnDecks";
            this.btnDecks.Size = new System.Drawing.Size(71, 48);
            this.btnDecks.TabIndex = 5;
            this.btnDecks.Text = "Decks";
            this.btnDecks.UseVisualStyleBackColor = true;
            this.btnDecks.Click += new System.EventHandler(this.btnDecks_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Location = new System.Drawing.Point(0, 702);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(71, 48);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnStats
            // 
            this.btnStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStats.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStats.Location = new System.Drawing.Point(0, 96);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(71, 48);
            this.btnStats.TabIndex = 3;
            this.btnStats.Text = "Stats";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnViewSort
            // 
            this.btnViewSort.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewSort.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSort.Location = new System.Drawing.Point(0, 48);
            this.btnViewSort.Name = "btnViewSort";
            this.btnViewSort.Size = new System.Drawing.Size(71, 48);
            this.btnViewSort.TabIndex = 1;
            this.btnViewSort.Text = "View/Sort";
            this.btnViewSort.UseVisualStyleBackColor = true;
            this.btnViewSort.Click += new System.EventHandler(this.btnViewSort_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(0, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 48);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 750);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSlideForm);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MTG Deckbuilder";
            this.panelSideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelSlideForm;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnDecks;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnViewSort;
        private System.Windows.Forms.Button btnSearch;
    }
}

