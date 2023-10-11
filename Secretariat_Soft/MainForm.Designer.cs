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
            min_btn = new Button();
            close_btn = new Button();
            SidePanel = new Panel();
            bottom_panel = new Panel();
            TopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.Controls.Add(min_btn);
            TopPanel.Controls.Add(close_btn);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(180, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(899, 75);
            TopPanel.TabIndex = 1;
            TopPanel.Paint += TopPanel_Paint;
            // 
            // min_btn
            // 
            min_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            min_btn.BackgroundImage = Properties.Resources.min_butt;
            min_btn.BackgroundImageLayout = ImageLayout.Zoom;
            min_btn.Cursor = Cursors.Hand;
            min_btn.Location = new Point(821, 12);
            min_btn.Name = "min_btn";
            min_btn.Size = new Size(30, 30);
            min_btn.TabIndex = 0;
            min_btn.UseVisualStyleBackColor = true;
            min_btn.Click += MinBtn_Click;
            // 
            // close_btn
            // 
            close_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close_btn.BackgroundImage = Properties.Resources.Close_butt;
            close_btn.BackgroundImageLayout = ImageLayout.Zoom;
            close_btn.Cursor = Cursors.Hand;
            close_btn.Location = new Point(857, 12);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(30, 30);
            close_btn.TabIndex = 0;
            close_btn.UseVisualStyleBackColor = true;
            close_btn.Click += CloseBtn_Click;
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.Gainsboro;
            SidePanel.Dock = DockStyle.Left;
            SidePanel.Location = new Point(0, 0);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(180, 768);
            SidePanel.TabIndex = 2;
            // 
            // bottom_panel
            // 
            bottom_panel.Dock = DockStyle.Bottom;
            bottom_panel.Location = new Point(180, 728);
            bottom_panel.Name = "bottom_panel";
            bottom_panel.Size = new Size(899, 40);
            bottom_panel.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 768);
            Controls.Add(TopPanel);
            Controls.Add(bottom_panel);
            Controls.Add(SidePanel);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(1024, 768);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            WindowState = FormWindowState.Maximized;
            TopPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private Panel SidePanel;
        private Panel bottom_panel;
        private Button close_btn;
        private Button min_btn;
    }
}