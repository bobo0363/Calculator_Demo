using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float nums;
        float  st;
        int count;//пазим дадено число и после в switch-case проверяваме на кое отговаря и изпълняваме съответната функция

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void num0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;//присвояваме стойността
        }

        private void num1_Click(object sender, EventArgs e)//....
        {
            textBox1.Text = textBox1.Text + 1;
         
        }

        private void num2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
           
        }

        private void num3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
            
        }

        private void num4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
            
        }

        private void num5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
            
        }

        private void num6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
           
        }

        private void num7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
           
        }

        private void num8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
            
        }

        private void num9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
           
        }

        private void sum_Click(object sender, EventArgs e)//сумиране на елементите
        {
           
            nums = float.Parse(textBox1.Text);//парсваме числата от стринг във 
            textBox1.Clear();
            textBox1.Focus();
            count = 1;//използва за switch-case
        }

        private void min_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "")
            {
                nums = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 2;
            }
        }

        private void multi_Click(object sender, EventArgs e)
        {
           
            nums = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
        }

        private void sep_Click(object sender, EventArgs e)
        {
        
            nums = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
        }

        private void button15_Click(object sender, EventArgs e)
        {
           
            res(count);//запазваме стойносттта в променливата res

            void  res(int count)//създаваме метод
            {
                switch (count)
                {
                    case 2:
                        st = nums- float.Parse(textBox1.Text);
                        textBox1.Text = st.ToString();
                      
                        break;
                    case 1:
                        st = nums + float.Parse(textBox1.Text);
                        textBox1.Text = st.ToString();
                        break;
                    case 3:
                       st = nums * float.Parse(textBox1.Text);
                        textBox1.Text = st.ToString();
                        break;
                    case 4:
                      
                        st = nums / float.Parse(textBox1.Text);
                        textBox1.Text = st.ToString();
                        break;
                    default:
                        break;
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)// работа с десетични числа
        {
            int duljina = textBox1.TextLength;
            int point = 0;
            string text = textBox1.Text;
            for (int i = 0; i < duljina; i++)
            {
                if (text[i].ToString() == ",")
                {
                    point = 1; 
                   break;
                }
                else
                {
                    point = 0;
                }
            }
            if (point == 0)
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            textBox1.Clear();
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text== "∞")
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
