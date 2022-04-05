namespace BelPomagalo.Views
{
    partial class AddNewThemeForm
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
            this.themeNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addNewThemeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // themeNameTextBox
            // 
            this.themeNameTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.themeNameTextBox.Location = new System.Drawing.Point(23, 54);
            this.themeNameTextBox.Name = "themeNameTextBox";
            this.themeNameTextBox.Size = new System.Drawing.Size(295, 35);
            this.themeNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Име на темата";
            // 
            // addNewThemeButton
            // 
            this.addNewThemeButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addNewThemeButton.Location = new System.Drawing.Point(23, 265);
            this.addNewThemeButton.Name = "addNewThemeButton";
            this.addNewThemeButton.Size = new System.Drawing.Size(295, 59);
            this.addNewThemeButton.TabIndex = 2;
            this.addNewThemeButton.Text = "Добави";
            this.addNewThemeButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Описание";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionTextBox.Location = new System.Drawing.Point(23, 128);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(295, 131);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // AddNewThemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 349);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.addNewThemeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.themeNameTextBox);
            this.Name = "AddNewThemeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добави Тема";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox themeNameTextBox;
        private Label label1;
        private Button addNewThemeButton;
        private Label label2;
        private TextBox descriptionTextBox;
    }
}