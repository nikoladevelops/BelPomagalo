namespace BelPomagalo
{
    partial class MainForm
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.libraryMenuButton = new System.Windows.Forms.Button();
            this.gamesMenuButton = new System.Windows.Forms.Button();
            this.homeMenuButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.publishedWorkLabel = new System.Windows.Forms.Label();
            this.addNewOppositionButton = new System.Windows.Forms.Button();
            this.authorsListBox = new System.Windows.Forms.ListBox();
            this.addNewCharacterButton = new System.Windows.Forms.Button();
            this.addNewThemeButton = new System.Windows.Forms.Button();
            this.authorLabel = new System.Windows.Forms.Label();
            this.addNewGenreButton = new System.Windows.Forms.Button();
            this.publishedWorkListBox = new System.Windows.Forms.ListBox();
            this.addNewAuthorButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.addNewPublishedWorkButton = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(144)))), ((int)(((byte)(102)))));
            this.menuPanel.Controls.Add(this.libraryMenuButton);
            this.menuPanel.Controls.Add(this.gamesMenuButton);
            this.menuPanel.Controls.Add(this.homeMenuButton);
            this.menuPanel.Controls.Add(this.panel3);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(194, 490);
            this.menuPanel.TabIndex = 0;
            // 
            // libraryMenuButton
            // 
            this.libraryMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.libraryMenuButton.FlatAppearance.BorderSize = 0;
            this.libraryMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.libraryMenuButton.Location = new System.Drawing.Point(0, 198);
            this.libraryMenuButton.Name = "libraryMenuButton";
            this.libraryMenuButton.Size = new System.Drawing.Size(194, 49);
            this.libraryMenuButton.TabIndex = 24;
            this.libraryMenuButton.Text = "Библиотека";
            this.libraryMenuButton.UseVisualStyleBackColor = true;
            // 
            // gamesMenuButton
            // 
            this.gamesMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.gamesMenuButton.FlatAppearance.BorderSize = 0;
            this.gamesMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gamesMenuButton.Location = new System.Drawing.Point(0, 149);
            this.gamesMenuButton.Name = "gamesMenuButton";
            this.gamesMenuButton.Size = new System.Drawing.Size(194, 49);
            this.gamesMenuButton.TabIndex = 23;
            this.gamesMenuButton.Text = "Игри";
            this.gamesMenuButton.UseVisualStyleBackColor = true;
            // 
            // homeMenuButton
            // 
            this.homeMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeMenuButton.FlatAppearance.BorderSize = 0;
            this.homeMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeMenuButton.Location = new System.Drawing.Point(0, 100);
            this.homeMenuButton.Name = "homeMenuButton";
            this.homeMenuButton.Size = new System.Drawing.Size(194, 49);
            this.homeMenuButton.TabIndex = 22;
            this.homeMenuButton.Text = "Начало";
            this.homeMenuButton.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(95)))), ((int)(((byte)(65)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 100);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Помагало";
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(166)))), ((int)(((byte)(131)))));
            this.contentPanel.Controls.Add(this.publishedWorkLabel);
            this.contentPanel.Controls.Add(this.addNewOppositionButton);
            this.contentPanel.Controls.Add(this.authorsListBox);
            this.contentPanel.Controls.Add(this.addNewCharacterButton);
            this.contentPanel.Controls.Add(this.addNewThemeButton);
            this.contentPanel.Controls.Add(this.authorLabel);
            this.contentPanel.Controls.Add(this.addNewGenreButton);
            this.contentPanel.Controls.Add(this.publishedWorkListBox);
            this.contentPanel.Controls.Add(this.addNewAuthorButton);
            this.contentPanel.Controls.Add(this.showButton);
            this.contentPanel.Controls.Add(this.addNewPublishedWorkButton);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(194, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(702, 490);
            this.contentPanel.TabIndex = 1;
            // 
            // publishedWorkLabel
            // 
            this.publishedWorkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.publishedWorkLabel.AutoSize = true;
            this.publishedWorkLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.publishedWorkLabel.Location = new System.Drawing.Point(169, 253);
            this.publishedWorkLabel.Name = "publishedWorkLabel";
            this.publishedWorkLabel.Size = new System.Drawing.Size(114, 21);
            this.publishedWorkLabel.TabIndex = 14;
            this.publishedWorkLabel.Text = "Произведения";
            // 
            // addNewOppositionButton
            // 
            this.addNewOppositionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addNewOppositionButton.Location = new System.Drawing.Point(6, 297);
            this.addNewOppositionButton.Name = "addNewOppositionButton";
            this.addNewOppositionButton.Size = new System.Drawing.Size(141, 49);
            this.addNewOppositionButton.TabIndex = 21;
            this.addNewOppositionButton.Text = "Добави Опозиция";
            this.addNewOppositionButton.UseVisualStyleBackColor = true;
            // 
            // authorsListBox
            // 
            this.authorsListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.authorsListBox.FormattingEnabled = true;
            this.authorsListBox.ItemHeight = 15;
            this.authorsListBox.Location = new System.Drawing.Point(169, 50);
            this.authorsListBox.Name = "authorsListBox";
            this.authorsListBox.Size = new System.Drawing.Size(382, 199);
            this.authorsListBox.TabIndex = 11;
            // 
            // addNewCharacterButton
            // 
            this.addNewCharacterButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addNewCharacterButton.Location = new System.Drawing.Point(6, 242);
            this.addNewCharacterButton.Name = "addNewCharacterButton";
            this.addNewCharacterButton.Size = new System.Drawing.Size(141, 49);
            this.addNewCharacterButton.TabIndex = 20;
            this.addNewCharacterButton.Text = "Добави Герой";
            this.addNewCharacterButton.UseVisualStyleBackColor = true;
            // 
            // addNewThemeButton
            // 
            this.addNewThemeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addNewThemeButton.Location = new System.Drawing.Point(6, 187);
            this.addNewThemeButton.Name = "addNewThemeButton";
            this.addNewThemeButton.Size = new System.Drawing.Size(141, 49);
            this.addNewThemeButton.TabIndex = 19;
            this.addNewThemeButton.Text = "Добави Тема";
            this.addNewThemeButton.UseVisualStyleBackColor = true;
            // 
            // authorLabel
            // 
            this.authorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.authorLabel.Location = new System.Drawing.Point(169, 26);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(53, 21);
            this.authorLabel.TabIndex = 13;
            this.authorLabel.Text = "Автор";
            // 
            // addNewGenreButton
            // 
            this.addNewGenreButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addNewGenreButton.Location = new System.Drawing.Point(6, 133);
            this.addNewGenreButton.Name = "addNewGenreButton";
            this.addNewGenreButton.Size = new System.Drawing.Size(141, 49);
            this.addNewGenreButton.TabIndex = 18;
            this.addNewGenreButton.Text = "Добави Жанр";
            this.addNewGenreButton.UseVisualStyleBackColor = true;
            // 
            // publishedWorkListBox
            // 
            this.publishedWorkListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.publishedWorkListBox.FormattingEnabled = true;
            this.publishedWorkListBox.ItemHeight = 15;
            this.publishedWorkListBox.Location = new System.Drawing.Point(169, 277);
            this.publishedWorkListBox.Name = "publishedWorkListBox";
            this.publishedWorkListBox.Size = new System.Drawing.Size(382, 199);
            this.publishedWorkListBox.TabIndex = 12;
            // 
            // addNewAuthorButton
            // 
            this.addNewAuthorButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addNewAuthorButton.Location = new System.Drawing.Point(6, 78);
            this.addNewAuthorButton.Name = "addNewAuthorButton";
            this.addNewAuthorButton.Size = new System.Drawing.Size(141, 49);
            this.addNewAuthorButton.TabIndex = 17;
            this.addNewAuthorButton.Text = "Добави Автор";
            this.addNewAuthorButton.UseVisualStyleBackColor = true;
            // 
            // showButton
            // 
            this.showButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showButton.Location = new System.Drawing.Point(557, 230);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(142, 61);
            this.showButton.TabIndex = 15;
            this.showButton.Text = "Покажи";
            this.showButton.UseVisualStyleBackColor = true;
            // 
            // addNewPublishedWorkButton
            // 
            this.addNewPublishedWorkButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addNewPublishedWorkButton.Location = new System.Drawing.Point(6, 23);
            this.addNewPublishedWorkButton.Name = "addNewPublishedWorkButton";
            this.addNewPublishedWorkButton.Size = new System.Drawing.Size(141, 49);
            this.addNewPublishedWorkButton.TabIndex = 16;
            this.addNewPublishedWorkButton.Text = "Добави Произведение";
            this.addNewPublishedWorkButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 490);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Помагало";
            this.menuPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel menuPanel;
        private Panel contentPanel;
        private Label publishedWorkLabel;
        private Button addNewOppositionButton;
        private ListBox authorsListBox;
        private Button addNewCharacterButton;
        private Button addNewThemeButton;
        private Label authorLabel;
        private Button addNewGenreButton;
        private ListBox publishedWorkListBox;
        private Button addNewAuthorButton;
        private Button showButton;
        private Button addNewPublishedWorkButton;
        private Button gamesMenuButton;
        private Button homeMenuButton;
        private Panel panel3;
        private Label label1;
        private Button libraryMenuButton;
    }
}