namespace Clock
{
    public partial class Clock : Form
    {
        public Clock()
        {
            InitializeComponent();
        }

        private void Clock_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clock_desplay.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
