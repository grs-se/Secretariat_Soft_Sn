namespace Secretariat_Soft
{
    partial class MainForm
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
            TopPanel = new Panel();
            SidePanel = new Panel();
            bottom_panel = new Panel();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(300, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(748, 45);
            TopPanel.TabIndex = 1;
            TopPanel.Paint += TopPanel_Paint;
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.Gainsboro;
            SidePanel.Dock = DockStyle.Left;
            SidePanel.Location = new Point(0, 0);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(300, 585);
            SidePanel.TabIndex = 2;
            // 
            // bottom_panel
            // 
            bottom_panel.Dock = DockStyle.Bottom;
            bottom_panel.Location = new Point(300, 540);
            bottom_panel.Name = "bottom_panel";
            bottom_panel.Size = new Size(748, 45);
            bottom_panel.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 585);
            Controls.Add(TopPanel);
            Controls.Add(bottom_panel);
            Controls.Add(SidePanel);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private Panel SidePanel;
        private Panel bottom_panel;
    }
}