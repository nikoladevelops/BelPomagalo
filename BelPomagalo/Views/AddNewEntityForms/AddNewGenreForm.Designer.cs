﻿namespace BelPomagalo.Views
{
    partial class AddNewGenreForm
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
            this.addNewGenreButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.genreNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addNewGenreButton
            // 
            this.addNewGenreButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addNewGenreButton.Location = new System.Drawing.Point(28, 100);
            this.addNewGenreButton.Name = "addNewGenreButton";
            this.addNewGenreButton.Size = new System.Drawing.Size(295, 59);
            this.addNewGenreButton.TabIndex = 5;
            this.addNewGenreButton.Text = "Добави";
            this.addNewGenreButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Име на жанра";
            // 
            // genreNameTextBox
            // 
            this.genreNameTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genreNameTextBox.Location = new System.Drawing.Point(28, 50);
            this.genreNameTextBox.Name = "genreNameTextBox";
            this.genreNameTextBox.Size = new System.Drawing.Size(295, 35);
            this.genreNameTextBox.TabIndex = 3;
            // 
            // AddNewGenreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 201);
            this.Controls.Add(this.addNewGenreButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.genreNameTextBox);
            this.Name = "AddNewGenreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewGenreForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addNewGenreButton;
        private Label label1;
        private TextBox genreNameTextBox;
    }
}