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
            components = new System.ComponentModel.Container();
            TopPanel = new Panel();
            help_butt = new Button();
            tools_butt = new Button();
            reports_butt = new Button();
            data_entry_butt = new Button();
            min_btn = new Button();
            close_btn = new Button();
            SidePanel = new Panel();
            analogClock1 = new AnalogClock.AnalogClock();
            panel1 = new Panel();
            day_week_lbl = new Label();
            day_month_lbl = new Label();
            month_name_lbl = new Label();
            Year_num_lbl = new Label();
            bottom_panel = new Panel();
            button6 = new Button();
            bg_changer_button5 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            timer1 = new System.Windows.Forms.Timer(components);
            TopPanel.SuspendLayout();
            SidePanel.SuspendLayout();
            panel1.SuspendLayout();
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
            SidePanel.Controls.Add(analogClock1);
            SidePanel.Controls.Add(panel1);
            SidePanel.Dock = DockStyle.Left;
            SidePanel.Location = new Point(0, 0);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(180, 768);
            SidePanel.TabIndex = 2;
            // 
            // analogClock1
            // 
            analogClock1.DrawHourHand = true;
            analogClock1.DrawHourHandShadow = true;
            analogClock1.DrawMinuteHand = true;
            analogClock1.DrawMinuteHandShadow = true;
            analogClock1.DrawSecondHand = true;
            analogClock1.DropShadowColor = Color.Black;
            analogClock1.DropShadowOffset = new Point(0, 0);
            analogClock1.FaceColorHigh = Color.RoyalBlue;
            analogClock1.FaceColorLow = Color.SkyBlue;
            analogClock1.FaceGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            analogClock1.FaceImage = null;
            analogClock1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            analogClock1.HourHandColor = Color.Gainsboro;
            analogClock1.HourHandDropShadowColor = Color.Gray;
            analogClock1.Location = new Point(12, 12);
            analogClock1.MinuteHandColor = Color.WhiteSmoke;
            analogClock1.MinuteHandDropShadowColor = Color.Gray;
            analogClock1.MinuteHandTickStyle = AnalogClock.TickStyle.Normal;
            analogClock1.Name = "analogClock1";
            analogClock1.NumeralColor = Color.WhiteSmoke;
            analogClock1.RimColorHigh = Color.RoyalBlue;
            analogClock1.RimColorLow = Color.SkyBlue;
            analogClock1.RimGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            analogClock1.SecondHandColor = Color.Tomato;
            analogClock1.SecondHandDropShadowColor = Color.Gray;
            analogClock1.SecondHandEndCap = System.Drawing.Drawing2D.LineCap.Round;
            analogClock1.SecondHandTickStyle = AnalogClock.TickStyle.Normal;
            analogClock1.Size = new Size(154, 154);
            analogClock1.TabIndex = 2;
            analogClock1.Time = new DateTime(0L);
            analogClock1.Load += analogClock1_Load;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.calendar;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(day_week_lbl);
            panel1.Controls.Add(day_month_lbl);
            panel1.Controls.Add(month_name_lbl);
            panel1.Controls.Add(Year_num_lbl);
            panel1.Location = new Point(6, 182);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(167, 138);
            panel1.TabIndex = 1;
            // 
            // day_week_lbl
            // 
            day_week_lbl.BackColor = Color.Transparent;
            day_week_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            day_week_lbl.ForeColor = Color.Black;
            day_week_lbl.Location = new Point(17, 97);
            day_week_lbl.Name = "day_week_lbl";
            day_week_lbl.Size = new Size(130, 27);
            day_week_lbl.TabIndex = 3;
            day_week_lbl.Text = "Wednesday";
            day_week_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // day_month_lbl
            // 
            day_month_lbl.BackColor = Color.Transparent;
            day_month_lbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            day_month_lbl.ForeColor = Color.Black;
            day_month_lbl.Location = new Point(17, 57);
            day_month_lbl.Name = "day_month_lbl";
            day_month_lbl.Size = new Size(130, 31);
            day_month_lbl.TabIndex = 2;
            day_month_lbl.Text = "11";
            day_month_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // month_name_lbl
            // 
            month_name_lbl.AutoSize = true;
            month_name_lbl.BackColor = Color.Transparent;
            month_name_lbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            month_name_lbl.ForeColor = Color.White;
            month_name_lbl.Location = new Point(83, 29);
            month_name_lbl.Name = "month_name_lbl";
            month_name_lbl.Size = new Size(64, 19);
            month_name_lbl.TabIndex = 1;
            month_name_lbl.Text = "October";
            month_name_lbl.Click += month_name_lbl_Click;
            // 
            // Year_num_lbl
            // 
            Year_num_lbl.AutoSize = true;
            Year_num_lbl.BackColor = Color.Transparent;
            Year_num_lbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Year_num_lbl.ForeColor = Color.White;
            Year_num_lbl.Location = new Point(11, 29);
            Year_num_lbl.Name = "Year_num_lbl";
            Year_num_lbl.Size = new Size(41, 19);
            Year_num_lbl.TabIndex = 0;
            Year_num_lbl.Text = "2023";
            Year_num_lbl.Click += Year_num_lbl_Click;
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
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
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
            Load += MainForm_Load;
            TopPanel.ResumeLayout(false);
            SidePanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Label day_week_lbl;
        private Label day_month_lbl;
        private Label month_name_lbl;
        private Label Year_num_lbl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private AnalogClock.AnalogClock analogClock1;
        private System.Windows.Forms.Timer timer1;
    }
}