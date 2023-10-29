//–азработать программу, котора€ сохран€ет текст, набранный в поле textBox1 в файл,
//им€ которого задано в текстовом поле textBox2.

using System.Text;

namespace Task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string path = textBox1.Text;
            using (FileStream fs = new FileStream(textBox2.Text, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                {
                    sw.WriteLine(textBox1.Text);
                }
                fs.Close();
            }

        }
    }
}