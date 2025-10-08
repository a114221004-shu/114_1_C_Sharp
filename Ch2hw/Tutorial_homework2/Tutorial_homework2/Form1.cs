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
            shownameLabel.Text = "Eight of Diamonds";
        }

        private void twoPictureBox_Click(object sender, EventArgs e)
        {
            shownameLabel.Text = "Two of Clubs";
        }

        private void thirteenPictureBox_Click(object sender, EventArgs e)
        {
            shownameLabel.Text = "King of Spades";
        }

        private void onePictureBox_Click(object sender, EventArgs e)
        {
            shownameLabel.Text = "Ace of Spades";
        }

        private void elevenPictureBox_Click(object sender, EventArgs e)
        {
            shownameLabel.Text = "Joker";
        }
    }
}
