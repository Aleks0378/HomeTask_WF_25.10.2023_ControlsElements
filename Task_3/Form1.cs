//Добавить на форму 2 listBox и 1 кнопку.
//При загрузке формы, создать и заполнить массив.
//По нажатию на кнопку, вывести четные элементы массива в первый listBox, нечетные - во второй.

using System.Text;

namespace Task_3
{
    public partial class Form1 : Form
    {
        int[] arr = new int[30];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            foreach (var item in arr)
            {
                if (item%2==0)
                    listBox1.Items.Add($"{item}, ");
                else
                    listBox2.Items.Add($"{item}, ");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(1, 50);
                listBox3.Items.Add($"{arr[i]}, ");
            }
        }
    }
}