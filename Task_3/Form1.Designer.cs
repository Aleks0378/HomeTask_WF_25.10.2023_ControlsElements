namespace Task_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            listBox2 = new ListBox();
            label3 = new Label();
            button1 = new Button();
            listBox3 = new ListBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(417, 44);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(86, 484);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(277, 9);
            label1.Name = "label1";
            label1.Size = new Size(226, 20);
            label1.TabIndex = 1;
            label1.Text = "Четные цифры массива:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(531, 9);
            label2.Name = "label2";
            label2.Size = new Size(247, 20);
            label2.TabIndex = 3;
            label2.Text = "Нечетные цифры массива:";
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(685, 44);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(93, 484);
            listBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 8);
            label3.Name = "label3";
            label3.Size = new Size(239, 20);
            label3.TabIndex = 5;
            label3.Text = "Массив случайных чисел:";
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(857, 44);
            button1.Name = "button1";
            button1.Size = new Size(128, 82);
            button1.TabIndex = 6;
            button1.Text = "Вывести числа";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox3
            // 
            listBox3.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 20;
            listBox3.Location = new Point(159, 44);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(86, 484);
            listBox3.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 584);
            Controls.Add(listBox3);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private ListBox listBox2;
        private Label label3;
        private Button button1;
        private ListBox listBox3;
    }
}