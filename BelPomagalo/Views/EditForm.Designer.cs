namespace BelPomagalo.Views
{
    partial class EditForm
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
            this.entityListBox = new System.Windows.Forms.ListBox();
            this.editPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(166)))), ((int)(((byte)(131)))));
            this.panel1.Controls.Add(this.entityListBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 163);
            this.panel1.TabIndex = 3;
            // 
            // entityListBox
            // 
            this.entityListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.entityListBox.FormattingEnabled = true;
            this.entityListBox.ItemHeight = 15;
            this.entityListBox.Location = new System.Drawing.Point(236, 3);
            this.entityListBox.Name = "entityListBox";
            this.entityListBox.Size = new System.Drawing.Size(196, 154);
            this.entityListBox.TabIndex = 0;
            // 
            // editPanel
            // 
            this.editPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(166)))), ((int)(((byte)(131)))));
            this.editPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.editPanel.Location = new System.Drawing.Point(0, 163);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(646, 339);
            this.editPanel.TabIndex = 4;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(166)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(646, 502);
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.panel1);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private ListBox entityListBox;
        private Panel editPanel;
    }
}