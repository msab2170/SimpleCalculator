using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool afterEnter = false;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)  { }
  
        private void btn1_Click(object sender, EventArgs e)
        {
            if (result.Text.Equals("0") || afterEnter == true)  { result.Text = "1"; }      
            else { result.Text += 1; }
            afterEnter = false;
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (result.Text.Equals("0") || afterEnter == true) { result.Text = "2"; }
            else { result.Text += 2; }
            afterEnter = false;
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (result.Text.Equals("0") || afterEnter == true) { result.Text = "3"; }
            else { result.Text += 3; }
            afterEnter = false;
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (result.Text.Equals("0") || afterEnter == true) { result.Text = "4"; }
            else { result.Text += 4; }
            afterEnter = false;
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (result.Text.Equals("0") || afterEnter == true) { result.Text = "5"; }
            else { result.Text += 5; }
            afterEnter = false;
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (result.Text.Equals("0") || afterEnter == true) { result.Text = "6"; }
            else { result.Text += 6; }
            afterEnter = false;
        }
   
        private void btn7_Click(object sender, EventArgs e)
        {
            if (result.Text.Equals("0") || afterEnter == true) { result.Text = "7"; }
            else { 
                result.Text += 7; 
            }
            afterEnter = false;
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (result.Text.Equals("0") || afterEnter == true) { result.Text = "8"; }
            else { result.Text += 8; }
            afterEnter = false;
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (result.Text.Equals("0") || afterEnter == true) { result.Text = "9"; }
            else { result.Text += 9; }
            afterEnter = false;
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            if (result.Text.Equals("0") || afterEnter == true) { result.Text = "0"; }
            else { result.Text += 0; }
            afterEnter = false;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if(result.Text == "0으로 나눌 수 없습니다.")
            {
                result.Text = 0.ToString();
            }
            afterEnter = false;
            if (result.Text.Contains(" "))
            {
                btnEnter_Click(sender, e);
                afterEnter = false;
            }
            result.Text += " * ";
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (result.Text == "0으로 나눌 수 없습니다.")
            {
                result.Text = 0.ToString();
            }
            afterEnter = false;
            if (result.Text.Contains(" "))
            {
                btnEnter_Click(sender, e);
                afterEnter = false;
            }
            result.Text += " / ";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (result.Text == "0으로 나눌 수 없습니다.")
            {
                result.Text = 0.ToString();
            }
            afterEnter = false;
            if (result.Text.Contains(" "))
            {
                btnEnter_Click(sender, e);
                afterEnter = false;
            }
            result.Text += " - ";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (result.Text == "0으로 나눌 수 없습니다.")
            {
                result.Text = 0.ToString();
            }
            afterEnter = false;
            if(result.Text.Contains(" "))
            {
                btnEnter_Click(sender, e);
                afterEnter = false;
            }
            result.Text += " + ";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            String temp = result.Text;
            if (!temp.Contains(" ")) return;
            String[] arr = temp.Split(' ');
            int a = Int32.Parse(arr[0]);
            int b = Int32.Parse(arr[2]);
            afterEnter = true;
            if (arr[1] == "*")
            {
                result.Text = (a * b).ToString();
            } else if (arr[1] == "/")
            {
                if ( b == 0)
                {
                    result.Text = "0으로 나눌 수 없습니다.";
                    afterEnter = true;
                } else
                {
                    result.Text = (a / b).ToString();
                }
                
            } else if (arr[1] == "-")
            {
                result.Text = (a - b).ToString();
            } else if (arr[1] == "+")
            {
                result.Text = (a + b).ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }
    }
}
