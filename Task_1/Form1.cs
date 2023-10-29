//�������� Windows Forms ���������� ��� ������� ������� �� ���������� �������. 
//������������ ������ ����� ����������� ������� ��������� ����� ������, ���������� ������ � ���� ������ � �����. 
//����� ���� ��� ������������ ���� ������, ���������� ������ ���������� �������� ����� � �������� �� TextBox.
//� ��������� ���������� ������������:

//1) ������ ����������: Panel ��� TableLayoutPanel
//2) �������� ����������: TextBox, Numeric, Label, RadioButton or Checkbox � �.�.
//3) �������� ��������� ������.


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
            textBox1.Text = $"{sum + result:F2} ������.";
        }
    }
}