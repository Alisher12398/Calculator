using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num;
        double num2, ans=0;
        double percentage = 0.1;
        int count;
        double m1 = 0;



        private void button3_Click(object sender, EventArgs e)
        {
            calculate();

        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(','))
            {
                textBox1.Text += ',';
            }

            textBox1.ForeColor = Color.White;
        }


        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void number_click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0") textBox1.Clear();
            if (textBox1.Text.Contains(ans.ToString()) || textBox1.Text.Contains("E") ) textBox1.Clear();
            if (textBox1.Text.Contains(num.ToString())) textBox1.Clear();
            
            Button btn = sender as Button;
            textBox1.Text += btn.Text;
        }

        public void calculate()
        {
        switch(count)
        {
         case 1:


            if (textBox1.Text.Contains(ans.ToString()))
                    {
                        ans = ans + num2;
                        textBox1.Text = ans.ToString();
                    }
                    else
                    {
                        if (textBox1.Text == " ") num2 = num;
                        else
                        {
                            num2 = double.Parse(textBox1.Text);
                        }
                        ans = num + num2;
                        textBox1.Text = ans.ToString();
                    }
            break;
          case 2:
                    if (textBox1.Text.Contains(ans.ToString()))
                    {
                        ans = ans - num2;
                        textBox1.Text = ans.ToString();
                    }
                    else
                    {
                        if (textBox1.Text == " ") num2 = num;
                        else
                        {
                            num2 = double.Parse(textBox1.Text);
                        }
                        ans = num - num2;
                        textBox1.Text = ans.ToString();
                    }
                    break;

          case 3:
                    if (textBox1.Text.Contains(ans.ToString()))
                    {
                        ans = ans * num2;
                        textBox1.Text = ans.ToString();
                    }
                    else
                    {

                        if (textBox1.Text == " ") num2 = num;
                        else
                        {
                            num2 = double.Parse(textBox1.Text);
                        }

                        ans = num * num2;
                        textBox1.Text = ans.ToString();
                    }
                    break;
          case 4:
                    if (textBox1.Text.Contains(ans.ToString()))
                    {
                        ans = ans / num2;
                        if (num2 == 0) textBox1.Text = "Error";
   
                        else
                        textBox1.Text = ans.ToString();
                    }
                    else
                    {

                        if (textBox1.Text == " ") num2 = num;
                        else
                        {
                            num2 = double.Parse(textBox1.Text);
                        }

                        ans = num / num2;
                        if (num2 == 0) textBox1.Text = "Error";
                        else
                            textBox1.Text = ans.ToString();
                    }
                    break;
          /*case 5:
            ans = num *  percentage * double.Parse (textBox1.Text);
            textBox1.Text = ans.ToString();
            break;
          /*case 6:
            ans = (num * num) * 1;
            textBox1.Text = ans.ToString();
            break;
           /* case 7:
            ans = Math.Sqrt(num);
            textBox1.Text = ans.ToString();
            break;*/
            /*
            case 8:
            ans = (1) / (num);
            textBox1.Text = ans.ToString();
            break; */
          
            


            default:
            break;
            
        }
    }

        private void button8_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            //    textBox1.Clear();
            count = 2;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            //textBox1.Clear();
            count = 3;
        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
           // textBox1.Clear();
            count = 4;
      
        }

        private void button9_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            //textBox1.Clear();
           count = 1;          
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Text = ans.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
                textBox1.Text = textBox1.Text + text[i];
            if (textBox1.TextLength == 0 ) textBox1.Text = "0";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            ans = num * percentage * double.Parse(textBox1.Text);
            textBox1.Text = ans.ToString();
           // textBox1.Clear();
            //textBox1.Focus();
         //   count = 5;
        
        }

        private void button23_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            ans = num * num;
            textBox1.Text = ans.ToString();

           // textBox1.Focus();
           // count = 6;
          
        }

        private void button24_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);

            ans = Math.Sqrt(num);
            textBox1.Text = ans.ToString();
          //  textBox1.Clear();
           // textBox1.Focus();
           // count = 7; 
        }

        private void button22_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            ans = (1) / (num);
            textBox1.Text = ans.ToString();
           
            //textBox1.Focus();
            //count = 8;
      
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            m1 = 0;
            ans =0;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains('-'))
            {
                textBox1.Text = '-' + textBox1.Text;
            }
            else
            {

                textBox1.Text = textBox1.Text.Trim('-');
            }
        }

  
        
        private void button27_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            m1= m1 + num;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            m1= m1 - num;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            m1 = double.Parse(textBox1.Text);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            m1 = 0;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = m1.ToString();
        }
        



    }
}
