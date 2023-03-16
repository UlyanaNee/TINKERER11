using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double a, b;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text += button0.Text;
            else
                textBox1.Text += button0.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "2")
                textBox1.Text += button2.Text;
            else
                textBox1.Text += button2.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "3")
                textBox1.Text += button3.Text;
            else
                textBox1.Text += button3.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "4")
                textBox1.Text += button4.Text;
            else
                textBox1.Text += button4.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "5")
                textBox1.Text += button5.Text;
            else
                textBox1.Text += button5.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "6")
                textBox1.Text += button6.Text;
            else
                textBox1.Text += button6.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "7")
                textBox1.Text += button7.Text;
            else
                textBox1.Text += button7.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "8")
                textBox1.Text += button8.Text;
            else
                textBox1.Text += button8.Text;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "9")
                textBox1.Text += button9.Text;
            else
                textBox1.Text += button9.Text;

        }

        private void buttonRavno_Click(object sender, EventArgs e)
        {
            // равно 
            bool flag = true;
            try
            {
                if (op != "√ ")
                {
                    b = Convert.ToDouble(textBox1.Text);
                }
            }
            catch (Exception ex)
            {
                textBox1.Text = "0";
                MessageBox.Show("Введено не числовое значение", "Ошибка");
            }
            switch(op)
            {
                case "+":
                    a = a + b;
                    break;
                case "-":
                    a = a - b;
                    break;
                case "*":
                    a = a * b;
                    break;
                case "^":
                    a = Math.Pow(a, b);
                    break;
                case "/":
                    {
                        if (b == 0)
                        {
                            textBox1.Text = " ";
                            flag = false;
                            MessageBox.Show("На ноль деление невозможно", "Ошибка");

                        }
                        else
                            a = a / b;
                    }
                    break;
            }
            if (flag == true)
                textBox1.Text = a.ToString();
            //if (g == true)
            //    textBox1.Text = a.ToString();
        }

        private void buttonYmnoj_Click(object sender, EventArgs e)
            // кнопка умножение
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                op = "*";
                textBox1.Text = " ";
            }
            catch (Exception ex)
            {
                textBox1.Text = " ";
                MessageBox.Show("Введено не числовое значение", "Ошибка");
            }
        }

        private void button10_Click(object sender, EventArgs e)
            // кнопка деление 
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                op = "/";
                textBox1.Text = " ";
            }
            catch (Exception ex)
            {
                textBox1.Text = " ";
                MessageBox.Show("Введено не числовое значение", "Ошибка");
            }
        }

        private void button11_Click(object sender, EventArgs e)
            // кнопка минус
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                op = "-";
                textBox1.Text = " ";
            }
            catch (Exception ex)
            {
                textBox1.Text = " ";
                MessageBox.Show("Введено не числовое значение", "Ошибка");
            }
        }

        private void button12_Click(object sender, EventArgs e)
            // кнопка плюс 
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                op = "+";
                textBox1.Text = " ";
            }
            catch (Exception ex)
            {
                textBox1.Text = " ";
                MessageBox.Show("Введено не числовое значение", "Ошибка");
            }
        }

        private void button13_Click(object sender, EventArgs e)
            //  очиска
        {
            textBox1.Text = " ";
        }

        private void buttonlen_Click(object sender, EventArgs e)
        {
            //удаляет с позицией последней 1 символ
            int len = textBox1.Text.Length;
            if (len > 0)
            {
                textBox1.Text = textBox1.Text.Remove(len - 1, 1); 
            }
            else
                textBox1.Text = " ";
        }

        private void buttoncomma_Click(object sender, EventArgs e)
        {
            // запятая
            if (textBox1.Text.IndexOf(",") == -1)
            {
                textBox1.Text += ",";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // плюс и минус 
            string s = textBox1.Text;
            if (s[0] == '-')
            {
                s = s.Remove(0, 1); // 0 с какйо позицией, 1 - кол-во символов удаляем
                textBox1.Text = s;
            }
            else  if (!((s == "0") || (s =="0,")))
            {
                    s = "-" + s;
                    textBox1.Text = s;
            }
        }
        
        private void button15_Click(object sender, EventArgs e)
        {
            // корень 
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                op = "√ ";
                textBox1.Text = " ";
                if (a < 0)
                {
                    textBox1.Text = " ";
                    //g = false;
                    MessageBox.Show("Введено не числовое значение", "Ошибка");
                }
                else
                    a = Math.Sqrt(a);

            }
            catch (Exception ex)
            {
                textBox1.Text = " ";
                MessageBox.Show("Введено не числовое значение", "Ошибка!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
                textBox1.Text += button1.Text;
            else
                textBox1.Text += button1.Text;

        }
    }
}
