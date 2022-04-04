namespace BelPomagalo.Views
{
    partial class AddNewPublishedWork
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.authorListBox = new System.Windows.Forms.ListBox();
            this.genreListBox = new System.Windows.Forms.ListBox();
            this.themeListBox = new System.Windows.Forms.ListBox();
            this.addPublishedWorkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTextBox.Location = new System.Drawing.Point(253, 47);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(272, 35);
            this.nameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(253, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Име";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(142, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Автор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(318, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Жанр";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(497, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Тема";
            // 
            // authorListBox
            // 
            this.authorListBox.FormattingEnabled = true;
            this.authorListBox.ItemHeight = 15;
            this.authorListBox.Location = new System.Drawing.Point(142, 145);
            this.authorListBox.Name = "authorListBox";
            this.authorListBox.Size = new System.Drawing.Size(160, 154);
            this.authorListBox.TabIndex = 8;
            // 
            // genreListBox
            // 
            this.genreListBox.FormattingEnabled = true;
            this.genreListBox.ItemHeight = 15;
            this.genreListBox.Location = new System.Drawing.Point(318, 145);
            this.genreListBox.Name = "genreListBox";
            this.genreListBox.Size = new System.Drawing.Size(160, 154);
            this.genreListBox.TabIndex = 9;
            // 
            // themeListBox
            // 
            this.themeListBox.FormattingEnabled = true;
            this.themeListBox.ItemHeight = 15;
            this.themeListBox.Location = new System.Drawing.Point(497, 145);
            this.themeListBox.Name = "themeListBox";
            this.themeListBox.Size = new System.Drawing.Size(160, 154);
            this.themeListBox.TabIndex = 10;
            // 
            // addPublishedWorkButton
            // 
            this.addPublishedWorkButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addPublishedWorkButton.Location = new System.Drawing.Point(318, 323);
            this.addPublishedWorkButton.Name = "addPublishedWorkButton";
            this.addPublishedWorkButton.Size = new System.Drawing.Size(160, 66);
            this.addPublishedWorkButton.TabIndex = 11;
            this.addPublishedWorkButton.Text = "Добави";
            this.addPublishedWorkButton.UseVisualStyleBackColor = true;
            this.addPublishedWorkButton.Click += new System.EventHandler(this.addPublishedWorkButton_Click);
            // 
            // AddNewPublishedWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addPublishedWorkButton);
            this.Controls.Add(this.themeListBox);
            this.Controls.Add(this.genreListBox);
            this.Controls.Add(this.authorListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Name = "AddNewPublishedWork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добави Произведение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nameTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox authorListBox;
        private ListBox genreListBox;
        private ListBox themeListBox;
        private Button addPublishedWorkButton;
    }
}