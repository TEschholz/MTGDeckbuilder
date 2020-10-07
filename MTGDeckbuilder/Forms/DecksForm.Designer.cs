namespace MTGDeckbuilder.Forms
{
    partial class DecksForm
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
            this.panelDecksTop = new System.Windows.Forms.Panel();
            this.lblAddDeck = new System.Windows.Forms.Label();
            this.panelDecksBottom = new System.Windows.Forms.Panel();
            this.dgvDecks = new System.Windows.Forms.DataGridView();
            this.txtAddDeck = new System.Windows.Forms.TextBox();
            this.btnAddDeck = new System.Windows.Forms.Button();
            this.lblDecks = new System.Windows.Forms.Label();
            this.panelDecksTop.SuspendLayout();
            this.panelDecksBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDecks)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDecksTop
            // 
            this.panelDecksTop.Controls.Add(this.btnAddDeck);
            this.panelDecksTop.Controls.Add(this.txtAddDeck);
            this.panelDecksTop.Controls.Add(this.lblAddDeck);
            this.panelDecksTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDecksTop.Location = new System.Drawing.Point(0, 0);
            this.panelDecksTop.Name = "panelDecksTop";
            this.panelDecksTop.Size = new System.Drawing.Size(473, 72);
            this.panelDecksTop.TabIndex = 0;
            // 
            // lblAddDeck
            // 
            this.lblAddDeck.AutoSize = true;
            this.lblAddDeck.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDeck.Location = new System.Drawing.Point(12, 9);
            this.lblAddDeck.Name = "lblAddDeck";
            this.lblAddDeck.Size = new System.Drawing.Size(167, 16);
            this.lblAddDeck.TabIndex = 1;
            this.lblAddDeck.Text = "Neues Deck hinzufügen:";
            // 
            // panelDecksBottom
            // 
            this.panelDecksBottom.Controls.Add(this.lblDecks);
            this.panelDecksBottom.Controls.Add(this.dgvDecks);
            this.panelDecksBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDecksBottom.Location = new System.Drawing.Point(0, 72);
            this.panelDecksBottom.Name = "panelDecksBottom";
            this.panelDecksBottom.Size = new System.Drawing.Size(473, 378);
            this.panelDecksBottom.TabIndex = 1;
            // 
            // dgvDecks
            // 
            this.dgvDecks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDecks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDecks.Location = new System.Drawing.Point(12, 45);
            this.dgvDecks.Name = "dgvDecks";
            this.dgvDecks.Size = new System.Drawing.Size(449, 321);
            this.dgvDecks.TabIndex = 0;
            // 
            // txtAddDeck
            // 
            this.txtAddDeck.Location = new System.Drawing.Point(15, 28);
            this.txtAddDeck.Name = "txtAddDeck";
            this.txtAddDeck.Size = new System.Drawing.Size(225, 20);
            this.txtAddDeck.TabIndex = 2;
            // 
            // btnAddDeck
            // 
            this.btnAddDeck.Location = new System.Drawing.Point(246, 28);
            this.btnAddDeck.Name = "btnAddDeck";
            this.btnAddDeck.Size = new System.Drawing.Size(49, 20);
            this.btnAddDeck.TabIndex = 3;
            this.btnAddDeck.Text = "Add";
            this.btnAddDeck.UseVisualStyleBackColor = true;
            // 
            // lblDecks
            // 
            this.lblDecks.AutoSize = true;
            this.lblDecks.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecks.Location = new System.Drawing.Point(12, 17);
            this.lblDecks.Name = "lblDecks";
            this.lblDecks.Size = new System.Drawing.Size(123, 16);
            this.lblDecks.TabIndex = 1;
            this.lblDecks.Text = "Decks verwalten:";
            // 
            // DecksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.panelDecksBottom);
            this.Controls.Add(this.panelDecksTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DecksForm";
            this.Text = "DecksForm";
            this.panelDecksTop.ResumeLayout(false);
            this.panelDecksTop.PerformLayout();
            this.panelDecksBottom.ResumeLayout(false);
            this.panelDecksBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDecks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDecksTop;
        private System.Windows.Forms.Label lblAddDeck;
        private System.Windows.Forms.Panel panelDecksBottom;
        private System.Windows.Forms.DataGridView dgvDecks;
        private System.Windows.Forms.Button btnAddDeck;
        private System.Windows.Forms.TextBox txtAddDeck;
        private System.Windows.Forms.Label lblDecks;
    }
}