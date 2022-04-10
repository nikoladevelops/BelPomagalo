namespace BelPomagalo.Views.AddNewEntityForms
{
    partial class AddNewOppositionForm
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
            this.addNewOppositionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.oppositionNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addNewOppositionButton
            // 
            this.addNewOppositionButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addNewOppositionButton.Location = new System.Drawing.Point(23, 280);
            this.addNewOppositionButton.Name = "addNewOppositionButton";
            this.addNewOppositionButton.Size = new System.Drawing.Size(295, 59);
            this.addNewOppositionButton.TabIndex = 5;
            this.addNewOppositionButton.Text = "Добави";
            this.addNewOppositionButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Име на опозицията";
            // 
            // oppositionNameTextBox
            // 
            this.oppositionNameTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oppositionNameTextBox.Location = new System.Drawing.Point(23, 52);
            this.oppositionNameTextBox.Name = "oppositionNameTextBox";
            this.oppositionNameTextBox.Size = new System.Drawing.Size(295, 35);
            this.oppositionNameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Описание";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionTextBox.Location = new System.Drawing.Point(23, 130);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(295, 144);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // AddNewOppositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 349);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.addNewOppositionButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oppositionNameTextBox);
            this.Name = "AddNewOppositionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добави Опозиция";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addNewOppositionButton;
        private Label label1;
        private TextBox oppositionNameTextBox;
        private Label label2;
        private TextBox descriptionTextBox;
    }
}