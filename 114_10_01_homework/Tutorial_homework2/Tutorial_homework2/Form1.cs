namespace Tutorial_homework2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eightPictureBox_Click(object sender, EventArgs e)
        {
            shownameLabel.Text = "¤è¶ô¤K";
        }

        private void twoPictureBox_Click(object sender, EventArgs e)
        {
            shownameLabel.Text = "±öªá¤G";
        }

        private void thirteenPictureBox_Click(object sender, EventArgs e)
        {
            shownameLabel.Text = "¶Â®çK";
        }

        private void onePictureBox_Click(object sender, EventArgs e)
        {
            shownameLabel.Text = "¶Â®çA";
        }

        private void elevenPictureBox_Click(object sender, EventArgs e)
        {
            shownameLabel.Text = "°­µP";
        }
    }
}
