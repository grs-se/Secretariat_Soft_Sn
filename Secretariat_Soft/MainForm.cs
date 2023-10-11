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
    }
}
