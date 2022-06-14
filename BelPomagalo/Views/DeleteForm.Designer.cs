namespace BelPomagalo.Views
{
    partial class DeleteForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.additionalLabel = new System.Windows.Forms.Label();
            this.additionalListBox = new System.Windows.Forms.ListBox();
            this.entityLabel = new System.Windows.Forms.Label();
            this.entityListBox = new System.Windows.Forms.ListBox();
            this.editPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(166)))), ((int)(((byte)(131)))));
            this.panel1.Controls.Add(this.additionalLabel);
            this.panel1.Controls.Add(this.additionalListBox);
            this.panel1.Controls.Add(this.entityLabel);
            this.panel1.Controls.Add(this.entityListBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 239);
            this.panel1.TabIndex = 3;
            // 
            // additionalLabel
            // 
            this.additionalLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.additionalLabel.AutoSize = true;
            this.additionalLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.additionalLabel.Location = new System.Drawing.Point(34, 27);
            this.additionalLabel.Name = "additionalLabel";
            this.additionalLabel.Size = new System.Drawing.Size(82, 25);
            this.additionalLabel.TabIndex = 3;
            this.additionalLabel.Text = "Избери ";
            this.additionalLabel.Visible = false;
            // 
            // additionalListBox
            // 
            this.additionalListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.additionalListBox.FormattingEnabled = true;
            this.additionalListBox.ItemHeight = 15;
            this.additionalListBox.Location = new System.Drawing.Point(34, 55);
            this.additionalListBox.Name = "additionalListBox";
            this.additionalListBox.Size = new System.Drawing.Size(196, 154);
            this.additionalListBox.TabIndex = 2;
            this.additionalListBox.Visible = false;
            // 
            // entityLabel
            // 
            this.entityLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.entityLabel.AutoSize = true;
            this.entityLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entityLabel.Location = new System.Drawing.Point(236, 27);
            this.entityLabel.Name = "entityLabel";
            this.entityLabel.Size = new System.Drawing.Size(82, 25);
            this.entityLabel.TabIndex = 1;
            this.entityLabel.Text = "Избери ";
            // 
            // entityListBox
            // 
            this.entityListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.entityListBox.FormattingEnabled = true;
            this.entityListBox.ItemHeight = 15;
            this.entityListBox.Location = new System.Drawing.Point(236, 55);
            this.entityListBox.Name = "entityListBox";
            this.entityListBox.Size = new System.Drawing.Size(196, 154);
            this.entityListBox.TabIndex = 0;
            // 
            // editPanel
            // 
            this.editPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(166)))), ((int)(((byte)(131)))));
            this.editPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.editPanel.Location = new System.Drawing.Point(0, 239);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(646, 229);
            this.editPanel.TabIndex = 4;
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(166)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(646, 528);
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.panel1);
            this.Name = "DeleteForm";
            this.Text = "DeleteForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private ListBox entityListBox;
        private Panel editPanel;
        private Label entityLabel;
        private Label additionalLabel;
        private ListBox additionalListBox;
    }
}