namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��� 1-21 ������ ������� 18 ���");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int number1 = int.Parse(textBox1.Text);
                int number2 = int.Parse(textBox2.Text);
                int sum = number1 + number2;
                textBox3.Text = sum.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("����������, ������� ����� � ��� ����.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}