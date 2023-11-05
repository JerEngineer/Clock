namespace Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            label2.Visible = false;
            if (DateTime.Now.ToString("MM/dd") == "12/31")
            {
                label2.Visible = true;
                label2.Text = "New Years Eve";
            }
            if (DateTime.Now.ToString("MM/dd") == "12/25")
            {
                label2.Visible = true;
                label2.Text = "Christmas Day";
            }
            if (DateTime.Now.ToString("MM/dd") == "10/31")
            {
                label2.Visible = true;
                label2.Text = "Halloween";
            }
        }
        public void Date_Click(object sender, EventArgs e)
        {
            label1.Visible = true;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToString("h:mm:ss tt");
            Date.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            label1.Text = DateTime.Now.ToString("M    /     dd    /      yyyy");
            Day.Text = DateTime.Now.ToString("dddd");
        }
    }
}