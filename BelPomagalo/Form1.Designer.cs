namespace BelPomagalo
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // authorsListBox
            // 
            this.authorsListBox.FormattingEnabled = true;
            this.authorsListBox.ItemHeight = 15;
            this.authorsListBox.Location = new System.Drawing.Point(12, 116);
            this.authorsListBox.Name = "authorsListBox";
            this.authorsListBox.Size = new System.Drawing.Size(382, 199);
            this.authorsListBox.TabIndex = 0;
            this.authorsListBox.SelectedIndexChanged += new System.EventHandler(this.SelectedAuthorChanged);
            // 
            // publishedWorkListBox
            // 
            this.publishedWorkListBox.FormattingEnabled = true;
            this.publishedWorkListBox.ItemHeight = 15;
            this.publishedWorkListBox.Location = new System.Drawing.Point(406, 116);
            this.publishedWorkListBox.Name = "publishedWorkListBox";
            this.publishedWorkListBox.Size = new System.Drawing.Size(382, 199);
            this.publishedWorkListBox.TabIndex = 1;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.authorLabel.Location = new System.Drawing.Point(12, 92);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(53, 21);
            this.authorLabel.TabIndex = 2;
            this.authorLabel.Text = "Автор";
            // 
            // publishedWorkLabel
            // 
            this.publishedWorkLabel.AutoSize = true;
            this.publishedWorkLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.publishedWorkLabel.Location = new System.Drawing.Point(406, 92);
            this.publishedWorkLabel.Name = "publishedWorkLabel";
            this.publishedWorkLabel.Size = new System.Drawing.Size(114, 21);
            this.publishedWorkLabel.TabIndex = 3;
            this.publishedWorkLabel.Text = "Произведения";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(325, 321);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(149, 61);
            this.showButton.TabIndex = 4;
            this.showButton.Text = "Покажи";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.publishedWorkLabel);
            this.Controls.Add(this.publishedWorkListBox);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.authorsListBox);
            this.Name = "Form1";
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
    }
}