namespace UPX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double wins = 0;
        double lose = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            label2.Text = rnd.Next(0, 9).ToString();
            label3.Text = rnd.Next(0, 9).ToString();
            label4.Text = rnd.Next(0, 9).ToString();
            label5.Text = "";
            pictureBox1.Visible = false;

            if (label2.Text == "7" || label3.Text == "7" || label4.Text == "7")
            {
                label5.Text = "Джекпот!!!";
                wins += 1;
                pictureBox1.Visible = true;
            }
            else
            {
                lose += 1;
            }

            double wandl = Math.Round(wins / (wins + lose) * 100);
            label6.Text =$"Процент выигрышей: {wandl}%";
            label7.Text =$"Процент проигрышей: {100 - wandl}%";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}