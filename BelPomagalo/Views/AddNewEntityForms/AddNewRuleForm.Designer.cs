namespace BelPomagalo.Views.AddNewEntityForms
{
    partial class AddNewRuleForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.addNewAuthorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ruleNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(210, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Описание";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionTextBox.Location = new System.Drawing.Point(210, 125);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.descriptionTextBox.Size = new System.Drawing.Size(295, 155);
            this.descriptionTextBox.TabIndex = 2;
            // 
            // addNewAuthorButton
            // 
            this.addNewAuthorButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addNewAuthorButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addNewAuthorButton.Location = new System.Drawing.Point(210, 286);
            this.addNewAuthorButton.Name = "addNewAuthorButton";
            this.addNewAuthorButton.Size = new System.Drawing.Size(295, 59);
            this.addNewAuthorButton.TabIndex = 3;
            this.addNewAuthorButton.Text = "Добави";
            this.addNewAuthorButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(210, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Име на правилото";
            // 
            // ruleNameTextBox
            // 
            this.ruleNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ruleNameTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ruleNameTextBox.Location = new System.Drawing.Point(210, 47);
            this.ruleNameTextBox.Name = "ruleNameTextBox";
            this.ruleNameTextBox.Size = new System.Drawing.Size(295, 35);
            this.ruleNameTextBox.TabIndex = 1;
            // 
            // AddNewRuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(166)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(687, 369);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.addNewAuthorButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ruleNameTextBox);
            this.Name = "AddNewRuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добави Правило";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private TextBox descriptionTextBox;
        private Button addNewAuthorButton;
        private Label label1;
        private TextBox ruleNameTextBox;
    }
}