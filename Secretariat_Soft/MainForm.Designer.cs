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
            data_entry_butt = new Button();
            reports_butt = new Button();
            tools_butt = new Button();
            help_butt = new Button();
            bg_changer_button5 = new Button();
            button6 = new Button();
            TopPanel.SuspendLayout();
            bottom_panel.SuspendLayout();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.Silver;
            TopPanel.Controls.Add(help_butt);
            TopPanel.Controls.Add(tools_butt);
            TopPanel.Controls.Add(reports_butt);
            TopPanel.Controls.Add(data_entry_butt);
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
            bottom_panel.Controls.Add(button6);
            bottom_panel.Controls.Add(bg_changer_button5);
            bottom_panel.Dock = DockStyle.Bottom;
            bottom_panel.Location = new Point(180, 728);
            bottom_panel.Name = "bottom_panel";
            bottom_panel.Size = new Size(899, 40);
            bottom_panel.TabIndex = 3;
            // 
            // data_entry_butt
            // 
            data_entry_butt.BackColor = Color.Transparent;
            data_entry_butt.BackgroundImage = Properties.Resources.butt_background;
            data_entry_butt.BackgroundImageLayout = ImageLayout.Stretch;
            data_entry_butt.Cursor = Cursors.Hand;
            data_entry_butt.FlatAppearance.BorderSize = 0;
            data_entry_butt.FlatStyle = FlatStyle.Flat;
            data_entry_butt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            data_entry_butt.Image = Properties.Resources.top_input_butt;
            data_entry_butt.ImageAlign = ContentAlignment.TopCenter;
            data_entry_butt.Location = new Point(6, 12);
            data_entry_butt.Margin = new Padding(3, 2, 3, 2);
            data_entry_butt.Name = "data_entry_butt";
            data_entry_butt.Size = new Size(105, 52);
            data_entry_butt.TabIndex = 3;
            data_entry_butt.Text = "Data Entry F2";
            data_entry_butt.TextAlign = ContentAlignment.BottomCenter;
            data_entry_butt.UseVisualStyleBackColor = false;
            data_entry_butt.Click += data_entry_butt_Click;
            // 
            // reports_butt
            // 
            reports_butt.BackColor = Color.Transparent;
            reports_butt.BackgroundImage = Properties.Resources.butt_background;
            reports_butt.BackgroundImageLayout = ImageLayout.Stretch;
            reports_butt.Cursor = Cursors.Hand;
            reports_butt.FlatAppearance.BorderSize = 0;
            reports_butt.FlatStyle = FlatStyle.Flat;
            reports_butt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            reports_butt.Image = Properties.Resources.top_report_butt;
            reports_butt.ImageAlign = ContentAlignment.TopCenter;
            reports_butt.Location = new Point(117, 12);
            reports_butt.Margin = new Padding(3, 2, 3, 2);
            reports_butt.Name = "reports_butt";
            reports_butt.Size = new Size(98, 52);
            reports_butt.TabIndex = 4;
            reports_butt.Text = "Reports F3";
            reports_butt.TextAlign = ContentAlignment.BottomCenter;
            reports_butt.UseVisualStyleBackColor = false;
            // 
            // tools_butt
            // 
            tools_butt.BackColor = Color.Transparent;
            tools_butt.BackgroundImage = Properties.Resources.butt_background;
            tools_butt.BackgroundImageLayout = ImageLayout.Stretch;
            tools_butt.Cursor = Cursors.Hand;
            tools_butt.FlatAppearance.BorderSize = 0;
            tools_butt.FlatStyle = FlatStyle.Flat;
            tools_butt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tools_butt.Image = Properties.Resources.top_Tools_butt;
            tools_butt.ImageAlign = ContentAlignment.TopCenter;
            tools_butt.Location = new Point(221, 12);
            tools_butt.Margin = new Padding(3, 2, 3, 2);
            tools_butt.Name = "tools_butt";
            tools_butt.Size = new Size(98, 52);
            tools_butt.TabIndex = 5;
            tools_butt.Text = "Tools F4";
            tools_butt.TextAlign = ContentAlignment.BottomCenter;
            tools_butt.UseVisualStyleBackColor = false;
            // 
            // help_butt
            // 
            help_butt.BackColor = Color.Transparent;
            help_butt.BackgroundImage = Properties.Resources.butt_background;
            help_butt.BackgroundImageLayout = ImageLayout.Stretch;
            help_butt.Cursor = Cursors.Hand;
            help_butt.FlatAppearance.BorderSize = 0;
            help_butt.FlatStyle = FlatStyle.Flat;
            help_butt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            help_butt.Image = Properties.Resources.top_Help_butt;
            help_butt.ImageAlign = ContentAlignment.TopCenter;
            help_butt.Location = new Point(325, 12);
            help_butt.Margin = new Padding(3, 2, 3, 2);
            help_butt.Name = "help_butt";
            help_butt.Size = new Size(98, 52);
            help_butt.TabIndex = 6;
            help_butt.Text = "Help F5";
            help_butt.TextAlign = ContentAlignment.BottomCenter;
            help_butt.UseVisualStyleBackColor = false;
            // 
            // bg_changer_button5
            // 
            bg_changer_button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bg_changer_button5.BackgroundImage = Properties.Resources.butt_background;
            bg_changer_button5.BackgroundImageLayout = ImageLayout.Stretch;
            bg_changer_button5.Cursor = Cursors.Hand;
            bg_changer_button5.Image = Properties.Resources.background;
            bg_changer_button5.Location = new Point(782, 8);
            bg_changer_button5.Margin = new Padding(3, 2, 3, 2);
            bg_changer_button5.Name = "bg_changer_button5";
            bg_changer_button5.Size = new Size(105, 24);
            bg_changer_button5.TabIndex = 1;
            bg_changer_button5.Text = "Background";
            bg_changer_button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            bg_changer_button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button6.BackgroundImage = Properties.Resources.butt_background;
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.Cursor = Cursors.Hand;
            button6.Image = Properties.Resources.calc_butt;
            button6.Location = new Point(743, 8);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(33, 24);
            button6.TabIndex = 2;
            button6.UseVisualStyleBackColor = true;
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
            bottom_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private Panel SidePanel;
        private Panel bottom_panel;
        private Button close_btn;
        private Button min_btn;
        private Button data_entry_butt;
        private Button reports_butt;
        private Button tools_butt;
        private Button help_butt;
        private Button bg_changer_button5;
        private Button button6;
    }
}