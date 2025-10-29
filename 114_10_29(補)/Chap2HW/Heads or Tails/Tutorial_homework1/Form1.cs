namespace Tutorial_homework1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void headPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void tailPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void showheadsButton_Click(object sender, EventArgs e)
        {
            headPictureBox.Visible = true;
            tailPictureBox.Visible = false;
        }

        private void showtailsButton_Click(object sender, EventArgs e)
        {
            headPictureBox.Visible = false;
            tailPictureBox.Visible = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            headPictureBox.Visible = false;
            tailPictureBox.Visible = false;
        }
    }
}
