//1.�������� ��������� �������� ���������� ����� ���� �a� � ���� �b� � ��������� ������������� ������.

namespace Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count_a = 0, count_b = 0;
            foreach (char s in textBox1.Text)
            {
                if (s == '�') count_a++;
                if (s=='�')count_b++;
            }
            textBox2.Text= count_a.ToString();
            textBox3.Text = count_b.ToString();
        }
    }
}