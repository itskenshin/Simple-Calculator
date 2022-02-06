using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora1 
{   
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        clases.ClaseSuma calculos = new clases.ClaseSuma();
        
        
        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                textcal.Text += "*";
                textBox1.Text += "*";
            }
            catch (Exception)
            {
                
            }
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textcal.Text += "4";
            textBox1.Text += "4";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textcal.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textcal.Text +=  "1";
            textBox1.Text += "1";

        }

        private void button20_Click(object sender, EventArgs e)
        {
            textcal.Text += "+";
            textBox1.Text += "+";
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textcal.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textcal.Text = "";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            String textBox = textBox1.Text;
            Double  result = clases.ClaseSuma.Eval(textBox);
            textBox1.Text = result.ToString();
        }

        private void button24_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String textBo = textBox1.Text;
                Double resul = clases.ClaseSuma.Eval(textBo);
                textBox1.Text = resul.ToString();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textcal.Text += "2";
            textBox1.Text += "2";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textcal.Text += "3";
            textBox1.Text += "3";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textcal.Text += "0";
            textBox1.Text += "0";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textcal.Text += ".";
            textBox1.Text += ".";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textcal.Text = "-" + textcal.Text;
            textBox1.Text = "-" + textBox1.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textcal.Text += "5";
            textBox1.Text += "5";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textcal.Text += "6";
            textBox1.Text += "6";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textcal.Text += "-";
            textBox1.Text += "-";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textcal.Text += "7";
            textBox1.Text += "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textcal.Text += "8";
            textBox1.Text += "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textcal.Text += "9";
            textBox1.Text += "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textcal.Text += "/";
            textBox1.Text += "/";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text += "*" + textBox1.Text;
                textcal.Text += "*" + textcal.Text;
                button24.PerformClick();
            }
            catch (Exception)
            {

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Double raiz = Convert.ToDouble(textBox1.Text);
                Double resu = Math.Sqrt(raiz);
                textcal.Text = resu.ToString();
                button24.PerformClick();
            }
            catch (Exception)
            {

            }
            }      

        private void button5_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.BackColor = Color.Black;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try { 
                textcal.Text = textcal.Text.Remove(textcal.Text.Length - 1);
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);

            }
            catch (Exception)
            {

            }
        }


    }
}
