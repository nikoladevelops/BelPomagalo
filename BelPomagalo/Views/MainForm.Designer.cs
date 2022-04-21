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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // authorsListBox
            // 
            this.authorsListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.authorsListBox.FormattingEnabled = true;
            this.authorsListBox.ItemHeight = 15;
            this.authorsListBox.Location = new System.Drawing.Point(43, 118);
            this.authorsListBox.Name = "authorsListBox";
            this.authorsListBox.Size = new System.Drawing.Size(382, 199);
            this.authorsListBox.TabIndex = 0;
            // 
            // publishedWorkListBox
            // 
            this.publishedWorkListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.publishedWorkListBox.FormattingEnabled = true;
            this.publishedWorkListBox.ItemHeight = 15;
            this.publishedWorkListBox.Location = new System.Drawing.Point(437, 118);
            this.publishedWorkListBox.Name = "publishedWorkListBox";
            this.publishedWorkListBox.Size = new System.Drawing.Size(382, 199);
            this.publishedWorkListBox.TabIndex = 1;
            // 
            // authorLabel
            // 
            this.authorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.authorLabel.Location = new System.Drawing.Point(43, 94);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(53, 21);
            this.authorLabel.TabIndex = 2;
            this.authorLabel.Text = "Автор";
            // 
            // publishedWorkLabel
            // 
            this.publishedWorkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.publishedWorkLabel.AutoSize = true;
            this.publishedWorkLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.publishedWorkLabel.Location = new System.Drawing.Point(437, 94);
            this.publishedWorkLabel.Name = "publishedWorkLabel";
            this.publishedWorkLabel.Size = new System.Drawing.Size(114, 21);
            this.publishedWorkLabel.TabIndex = 3;
            this.publishedWorkLabel.Text = "Произведения";
            // 
            // showButton
            // 
            this.showButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showButton.Location = new System.Drawing.Point(356, 323);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(149, 61);
            this.showButton.TabIndex = 4;
            this.showButton.Text = "Покажи";
            this.showButton.UseVisualStyleBackColor = true;
            // 
            // addNewPublishedWorkButton
            // 
            this.addNewPublishedWorkButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addNewPublishedWorkButton.Location = new System.Drawing.Point(12, 3);
            this.addNewPublishedWorkButton.Name = "addNewPublishedWorkButton";
            this.addNewPublishedWorkButton.Size = new System.Drawing.Size(141, 49);
            this.addNewPublishedWorkButton.TabIndex = 5;
            this.addNewPublishedWorkButton.Text = "Добави Произведение";
            this.addNewPublishedWorkButton.UseVisualStyleBackColor = true;
            // 
            // addNewAuthorButton
            // 
            this.addNewAuthorButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addNewAuthorButton.Location = new System.Drawing.Point(153, 3);
            this.addNewAuthorButton.Name = "addNewAuthorButton";
            this.addNewAuthorButton.Size = new System.Drawing.Size(141, 49);
            this.addNewAuthorButton.TabIndex = 6;
            this.addNewAuthorButton.Text = "Добави Автор";
            this.addNewAuthorButton.UseVisualStyleBackColor = true;
            // 
            // addNewGenreButton
            // 
            this.addNewGenreButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addNewGenreButton.Location = new System.Drawing.Point(294, 3);
            this.addNewGenreButton.Name = "addNewGenreButton";
            this.addNewGenreButton.Size = new System.Drawing.Size(141, 49);
            this.addNewGenreButton.TabIndex = 7;
            this.addNewGenreButton.Text = "Добави Жанр";
            this.addNewGenreButton.UseVisualStyleBackColor = true;
            // 
            // addNewThemeButton
            // 
            this.addNewThemeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addNewThemeButton.Location = new System.Drawing.Point(435, 3);
            this.addNewThemeButton.Name = "addNewThemeButton";
            this.addNewThemeButton.Size = new System.Drawing.Size(141, 49);
            this.addNewThemeButton.TabIndex = 8;
            this.addNewThemeButton.Text = "Добави Тема";
            this.addNewThemeButton.UseVisualStyleBackColor = true;
            // 
            // addNewCharacterButton
            // 
            this.addNewCharacterButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addNewCharacterButton.Location = new System.Drawing.Point(576, 3);
            this.addNewCharacterButton.Name = "addNewCharacterButton";
            this.addNewCharacterButton.Size = new System.Drawing.Size(141, 49);
            this.addNewCharacterButton.TabIndex = 9;
            this.addNewCharacterButton.Text = "Добави Герой";
            this.addNewCharacterButton.UseVisualStyleBackColor = true;
            // 
            // addNewOppositionButton
            // 
            this.addNewOppositionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addNewOppositionButton.Location = new System.Drawing.Point(717, 3);
            this.addNewOppositionButton.Name = "addNewOppositionButton";
            this.addNewOppositionButton.Size = new System.Drawing.Size(141, 49);
            this.addNewOppositionButton.TabIndex = 10;
            this.addNewOppositionButton.Text = "Добави Опозиция";
            this.addNewOppositionButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.127396F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.8726F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(896, 450);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.publishedWorkLabel);
            this.panel1.Controls.Add(this.addNewOppositionButton);
            this.panel1.Controls.Add(this.authorsListBox);
            this.panel1.Controls.Add(this.addNewCharacterButton);
            this.panel1.Controls.Add(this.addNewThemeButton);
            this.panel1.Controls.Add(this.authorLabel);
            this.panel1.Controls.Add(this.addNewGenreButton);
            this.panel1.Controls.Add(this.publishedWorkListBox);
            this.panel1.Controls.Add(this.addNewAuthorButton);
            this.panel1.Controls.Add(this.showButton);
            this.panel1.Controls.Add(this.addNewPublishedWorkButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(13, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 444);
            this.panel1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Помагало";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
    }
}