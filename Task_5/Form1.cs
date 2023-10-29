//Разработать программу, которая запрещает ввод в компонент textBox1 подряд двух одинаковых символов.

using System.Text;

namespace Task_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str= textBox1.Text;
            for (int i = str.Length-1;i>0;i--)
            {
                if (str[i] == str[i - 1])
                {
                    textBox1.Text=str.Remove(i);
                    textBox1.Select(i,0);
                }
            }
        }
    }
}