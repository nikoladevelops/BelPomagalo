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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.libraryMenuButton = new System.Windows.Forms.Button();
            this.gamesMenuButton = new System.Windows.Forms.Button();
            this.homeMenuButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(144)))), ((int)(((byte)(102)))));
            this.menuPanel.Controls.Add(this.libraryMenuButton);
            this.menuPanel.Controls.Add(this.gamesMenuButton);
            this.menuPanel.Controls.Add(this.homeMenuButton);
            this.menuPanel.Controls.Add(this.panel3);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(194, 490);
            this.menuPanel.TabIndex = 0;
            // 
            // libraryMenuButton
            // 
            this.libraryMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.libraryMenuButton.FlatAppearance.BorderSize = 0;
            this.libraryMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.libraryMenuButton.Location = new System.Drawing.Point(0, 198);
            this.libraryMenuButton.Name = "libraryMenuButton";
            this.libraryMenuButton.Size = new System.Drawing.Size(194, 49);
            this.libraryMenuButton.TabIndex = 24;
            this.libraryMenuButton.Text = "Библиотека";
            this.libraryMenuButton.UseVisualStyleBackColor = true;
            // 
            // gamesMenuButton
            // 
            this.gamesMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.gamesMenuButton.FlatAppearance.BorderSize = 0;
            this.gamesMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gamesMenuButton.Location = new System.Drawing.Point(0, 149);
            this.gamesMenuButton.Name = "gamesMenuButton";
            this.gamesMenuButton.Size = new System.Drawing.Size(194, 49);
            this.gamesMenuButton.TabIndex = 23;
            this.gamesMenuButton.Text = "Игри";
            this.gamesMenuButton.UseVisualStyleBackColor = true;
            // 
            // homeMenuButton
            // 
            this.homeMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeMenuButton.FlatAppearance.BorderSize = 0;
            this.homeMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeMenuButton.Location = new System.Drawing.Point(0, 100);
            this.homeMenuButton.Name = "homeMenuButton";
            this.homeMenuButton.Size = new System.Drawing.Size(194, 49);
            this.homeMenuButton.TabIndex = 22;
            this.homeMenuButton.Text = "Начало";
            this.homeMenuButton.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(95)))), ((int)(((byte)(65)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 100);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Помагало";
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(166)))), ((int)(((byte)(131)))));
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(194, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(702, 490);
            this.contentPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 490);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Помагало";
            this.menuPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel menuPanel;
        private Panel contentPanel;
        private Button gamesMenuButton;
        private Button homeMenuButton;
        private Panel panel3;
        private Label label1;
        private Button libraryMenuButton;
    }
}