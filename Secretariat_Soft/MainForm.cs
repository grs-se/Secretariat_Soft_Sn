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

        private void DataEntryBtn_Click(object sender, EventArgs e)
        {
            this.Tree_Panel.Visible = !this.Tree_Panel.Visible;
        }

        private void Year_num_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Month_name_lbl_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //-------------load date----------------
            Get_date_cal();
            //--------------------------------------
            this.Tree_Panel.Visible = false;
            this.MainTree_View.ExpandAll();
        }

        void Get_date_cal()
        {
            this.Year_num_lbl.Text = System.DateTime.Now.Year.ToString();
            int mn = System.DateTime.Now.Month;
            string month_name;
            month_name = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mn);
            this.month_name_lbl.Text = month_name;
            this.day_month_lbl.Text = System.DateTime.Now.Day.ToString();
            this.day_week_lbl.Text = System.DateTime.Now.DayOfWeek.ToString();
        }

        private void AnalogClock1_Load(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.analogClock1.Time = System.DateTime.Now;
        }

        private void User_name_lbl_Click(object sender, EventArgs e)
        {

        }

        private void TreePanel_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void ExpandBtn_Click(object sender, EventArgs e)
        {
            this.MainTree_View.ExpandAll();
        }

        private void CollapseBtn_Click(object sender, EventArgs e)
        {
            this.MainTree_View.CollapseAll();
        }
    }
}
