//Создайте Windows Forms приложение для расчета прибыли от банковских вкладов. 
//Пользователь должен иметь возможность вводить начальную сумму вклада, процентную ставку и срок вклада в годах. 
//После того как пользователь ввел данные, приложение должно рассчитать конечную сумму и показать ее TextBox.
//В программе необходимо использовать:

//1) Панели управления: Panel или TableLayoutPanel
//2) Элементы управления: TextBox, Numeric, Label, RadioButton or Checkbox и т.д.
//3) Проверку введенных данных.


namespace Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal period = Convert.ToDecimal(groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(e => e.Checked).Tag.ToString());
            decimal sum = numericUpDown1.Value;
            decimal rate = numericUpDown2.Value;

            decimal result = sum * (rate / 100) * (period / 12);
            textBox1.Text = $"{sum + result:F2} гривен.";
        }
    }
}