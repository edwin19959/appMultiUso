using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appMultiUso
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
            
            this.FormClosing += new FormClosingEventHandler(Calculadora_FormClosing);
        }

        private void BACK2_Click(object sender, EventArgs e)
        {
            Form backFormulario = new Form1();
            backFormulario.Show();
            this.Hide();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void multip_Click(object sender, EventArgs e)
        {
            operador = "*";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
     

            if (string.IsNullOrEmpty(textBox1.Text) || textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }

            
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;

        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }


            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;

            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        //variables
        string operador = "";
        double num1 = 0;
        double num2 = 0;
        private void Calculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Form1 form1 = new Form1();
            form1.Show();

            /*
            
            e.Cancel = true;
            this.Hide(); */
        }


        private void btncero_Click(object sender, EventArgs e)
        {
            textBox1.Text= "0";
            num1 = 0;
            num2 = 0;
            operador = "";
        }
        Double resultado = 0;
        private void btnIgual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox1.Text);

            switch (operador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                       
                    }
                    else
                    {
                        
                        textBox1.Text = "Error: División por cero";
                        return;
                    }
                    break;
                    
            }

          
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo();
            numberFormatInfo.NumberDecimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            numberFormatInfo.NumberGroupSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator;
            numberFormatInfo.NumberDecimalDigits = resultado % 1 == 0 ? 0 : 2;

            textBox1.Text = resultado.ToString("N", numberFormatInfo);
        }

        private void btnba_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);

            }
            
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }


            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }


            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }


            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }


            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }


            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }


            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }


            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                textBox1.Text += CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            }
            textBox1.SelectionStart = textBox1.Text.Length;

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }

        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1= Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }
    }
    
}
