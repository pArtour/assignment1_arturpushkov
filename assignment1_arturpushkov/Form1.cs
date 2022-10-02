namespace assignment1_arturpushkov
{
    public partial class asignment1Form : Form
    {
        public asignment1Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label1.Text = "Ace";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Text = "Jack";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label1.Text = "King";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label1.Text = "Queen";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label1.Text = "Two";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}