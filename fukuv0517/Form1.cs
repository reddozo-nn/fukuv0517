namespace fukuv0517
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "���v�� �I��";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}