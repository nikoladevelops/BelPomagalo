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
            this.entityListBox = new System.Windows.Forms.ListBox();
            this.editPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // entityListBox
            // 
            this.entityListBox.FormattingEnabled = true;
            this.entityListBox.ItemHeight = 15;
            this.entityListBox.Location = new System.Drawing.Point(251, 12);
            this.entityListBox.Name = "entityListBox";
            this.entityListBox.Size = new System.Drawing.Size(196, 154);
            this.entityListBox.TabIndex = 0;
            // 
            // editPanel
            // 
            this.editPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.editPanel.Location = new System.Drawing.Point(0, 188);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(646, 314);
            this.editPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.entityListBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 182);
            this.panel1.TabIndex = 2;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.editPanel);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox entityListBox;
        private Panel editPanel;
        private Panel panel1;
    }
}