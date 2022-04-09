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
            this.authorsListBox = new System.Windows.Forms.ListBox();
            this.publishedWorkListBox = new System.Windows.Forms.ListBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.publishedWorkLabel = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.addNewPublishedWorkButton = new System.Windows.Forms.Button();
            this.addNewAuthorButton = new System.Windows.Forms.Button();
            this.addNewGenreButton = new System.Windows.Forms.Button();
            this.addNewThemeButton = new System.Windows.Forms.Button();
            this.addNewCharacterButton = new System.Windows.Forms.Button();
            this.addNewOppositionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authorsListBox
            // 
            this.authorsListBox.FormattingEnabled = true;
            this.authorsListBox.ItemHeight = 15;
            this.authorsListBox.Location = new System.Drawing.Point(56, 127);
            this.authorsListBox.Name = "authorsListBox";
            this.authorsListBox.Size = new System.Drawing.Size(382, 199);
            this.authorsListBox.TabIndex = 0;
            // 
            // publishedWorkListBox
            // 
            this.publishedWorkListBox.FormattingEnabled = true;
            this.publishedWorkListBox.ItemHeight = 15;
            this.publishedWorkListBox.Location = new System.Drawing.Point(450, 127);
            this.publishedWorkListBox.Name = "publishedWorkListBox";
            this.publishedWorkListBox.Size = new System.Drawing.Size(382, 199);
            this.publishedWorkListBox.TabIndex = 1;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.authorLabel.Location = new System.Drawing.Point(56, 103);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(53, 21);
            this.authorLabel.TabIndex = 2;
            this.authorLabel.Text = "Автор";
            // 
            // publishedWorkLabel
            // 
            this.publishedWorkLabel.AutoSize = true;
            this.publishedWorkLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.publishedWorkLabel.Location = new System.Drawing.Point(450, 103);
            this.publishedWorkLabel.Name = "publishedWorkLabel";
            this.publishedWorkLabel.Size = new System.Drawing.Size(114, 21);
            this.publishedWorkLabel.TabIndex = 3;
            this.publishedWorkLabel.Text = "Произведения";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(369, 332);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(149, 61);
            this.showButton.TabIndex = 4;
            this.showButton.Text = "Покажи";
            this.showButton.UseVisualStyleBackColor = true;
            // 
            // addNewPublishedWorkButton
            // 
            this.addNewPublishedWorkButton.Location = new System.Drawing.Point(12, 12);
            this.addNewPublishedWorkButton.Name = "addNewPublishedWorkButton";
            this.addNewPublishedWorkButton.Size = new System.Drawing.Size(141, 49);
            this.addNewPublishedWorkButton.TabIndex = 5;
            this.addNewPublishedWorkButton.Text = "Добави Произведение";
            this.addNewPublishedWorkButton.UseVisualStyleBackColor = true;
            // 
            // addNewAuthorButton
            // 
            this.addNewAuthorButton.Location = new System.Drawing.Point(159, 12);
            this.addNewAuthorButton.Name = "addNewAuthorButton";
            this.addNewAuthorButton.Size = new System.Drawing.Size(141, 49);
            this.addNewAuthorButton.TabIndex = 6;
            this.addNewAuthorButton.Text = "Добави Автор";
            this.addNewAuthorButton.UseVisualStyleBackColor = true;
            // 
            // addNewGenreButton
            // 
            this.addNewGenreButton.Location = new System.Drawing.Point(306, 12);
            this.addNewGenreButton.Name = "addNewGenreButton";
            this.addNewGenreButton.Size = new System.Drawing.Size(141, 49);
            this.addNewGenreButton.TabIndex = 7;
            this.addNewGenreButton.Text = "Добави Жанр";
            this.addNewGenreButton.UseVisualStyleBackColor = true;
            // 
            // addNewThemeButton
            // 
            this.addNewThemeButton.Location = new System.Drawing.Point(453, 12);
            this.addNewThemeButton.Name = "addNewThemeButton";
            this.addNewThemeButton.Size = new System.Drawing.Size(141, 49);
            this.addNewThemeButton.TabIndex = 8;
            this.addNewThemeButton.Text = "Добави Тема";
            this.addNewThemeButton.UseVisualStyleBackColor = true;
            // 
            // addNewCharacterButton
            // 
            this.addNewCharacterButton.Location = new System.Drawing.Point(600, 12);
            this.addNewCharacterButton.Name = "addNewCharacterButton";
            this.addNewCharacterButton.Size = new System.Drawing.Size(141, 49);
            this.addNewCharacterButton.TabIndex = 9;
            this.addNewCharacterButton.Text = "Добави Герой";
            this.addNewCharacterButton.UseVisualStyleBackColor = true;
            // 
            // addNewOppositionButton
            // 
            this.addNewOppositionButton.Location = new System.Drawing.Point(747, 12);
            this.addNewOppositionButton.Name = "addNewOppositionButton";
            this.addNewOppositionButton.Size = new System.Drawing.Size(141, 49);
            this.addNewOppositionButton.TabIndex = 10;
            this.addNewOppositionButton.Text = "Добави Опозиция";
            this.addNewOppositionButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 450);
            this.Controls.Add(this.addNewOppositionButton);
            this.Controls.Add(this.addNewCharacterButton);
            this.Controls.Add(this.addNewThemeButton);
            this.Controls.Add(this.addNewGenreButton);
            this.Controls.Add(this.addNewAuthorButton);
            this.Controls.Add(this.addNewPublishedWorkButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.publishedWorkLabel);
            this.Controls.Add(this.publishedWorkListBox);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.authorsListBox);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Помагало";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox authorsListBox;
        private ListBox publishedWorkListBox;
        private Label authorLabel;
        private Label publishedWorkLabel;
        private Button showButton;
        private Button addNewPublishedWorkButton;
        private Button addNewAuthorButton;
        private Button addNewGenreButton;
        private Button addNewThemeButton;
        private Button addNewCharacterButton;
        private Button addNewOppositionButton;
    }
}