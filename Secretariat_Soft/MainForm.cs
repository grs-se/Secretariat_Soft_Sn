namespace Secretariat_Soft
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void data_entry_butt_Click(object sender, EventArgs e)
        {

        }

        private void Year_num_lbl_Click(object sender, EventArgs e)
        {

        }

        private void month_name_lbl_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //-------------load date----------------
            get_date_cal();
            //--------------------------------------
        }

        void get_date_cal()
        {
            this.Year_num_lbl.Text = System.DateTime.Now.Year.ToString();
            int mn = System.DateTime.Now.Month;
            string month_name;
            month_name = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mn);
            this.month_name_lbl.Text = month_name;
            this.day_month_lbl.Text = System.DateTime.Now.Day.ToString();
            this.day_week_lbl.Text = System.DateTime.Now.DayOfWeek.ToString();
        }

        private void analogClock1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.analogClock1.Time = System.DateTime.Now;
        }
    }
}
