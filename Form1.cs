using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace HOMEWORK_5
{
    public partial class Form1 : Form
    {
     
        public string op;
        double sum1 = 0, subs1 = 0, multi1 = 1, div1 = 1;
        int sum2 = 0, subs2 = 0, multi2 = 1, div2 = 1;
        public Form1()

        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "1";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "7"; 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "9";
        }

        private void divi_Click(object sender, EventArgs e)
        {
            op = "/";
            if(textBox.Text.Contains("."))
            {
                div1 = Convert.ToDouble(textBox.Text);
            }
            else
            {
                div2 = Convert.ToInt32(textBox.Text);
            }
            textBox.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            sum1 = 0;
            subs1 = 0;
            multi1 = 1;
            div1 = 1;
            sum2 = 0; subs2 = 0; multi2 = 1; div2 = 1;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        
        private void button10_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + ".";
        }
        private void plus_Click(object sender, EventArgs e)
        {
            op = "+";
           if(textBox.Text.Contains("."))
            {
                sum1 = Convert.ToDouble(textBox.Text) + sum1;
            }
            else
            {
                sum2 = Convert.ToInt32(textBox.Text) + sum2;
            }
            textBox.Text = "";

        }

        private void multi_Click(object sender, EventArgs e)
        {
            op = "x";
            if(textBox.Text.Contains("."))
            {
                multi1 = Convert.ToDouble(textBox.Text) * multi1;
            }
            else
            {
                multi2 = Convert.ToInt32(textBox.Text) * multi2;
            }
            textBox.Text = "";
        }

        private void subs_Click(object sender, EventArgs e)
        {
            op = "-";
            if (textBox.Text.Contains("."))
            {
                subs1 = Convert.ToDouble(textBox.Text) - subs1;
            }
            else
            {
                subs2 = Convert.ToInt32(textBox.Text) - subs2;
            }
            textBox.Text = "";

        }

        private void eq_Click_1(object sender, EventArgs e)
        {
         switch(op)
            {
                case "+":
                    double s = Convert.ToDouble(textBox.Text);
                    double sum = sum1 + Convert.ToDouble(sum2) + s;
                    textBox.Text = Convert.ToString(sum);
                    sum = 0;
                    break;
                case "-":
                    if (subs1 == 0)
                    {
                        int g = Convert.ToInt32(textBox.Text);
                        int subs3 = subs2 - g;
                        textBox.Text = Convert.ToString(subs3);
                    }
                    else
                    {
                        double f = Convert.ToDouble(textBox.Text);
                        double subs = subs1 - f;
                        textBox.Text = Convert.ToString(subs);
                    }
                    break;
                case "x":
                    if(multi1 == 1)
                    {
                        int jad = Convert.ToInt32(textBox.Text);
                        int multi3 = multi2 * jad;
                        textBox.Text = Convert.ToString(multi3);
                    }
                    else
                    {
                        double d = Convert.ToDouble(textBox.Text);
                        double multi4 = multi1 * d;
                        textBox.Text = Convert.ToString(multi4);
                    }
                    break;
                case "/":
                    if(textBox.Text.Contains("."))
                        {
                        double div = div1 / (Convert.ToDouble(textBox.Text));
                        textBox.Text = Convert.ToString(div);
                    }
                    else if(Convert.ToDouble(textBox.Text) == 0)
                    {
                        errorProvider1.SetError(textBox,"this number is invalid");
                    }
                    else
                    {
                        int divs = div2 / (Convert.ToInt32(textBox.Text));
                        textBox.Text = Convert.ToString(divs);
                    }
                    break;
            }
        }
    }
    }

