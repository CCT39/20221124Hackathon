using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbxInput.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbxInput.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbxInput.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbxInput.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbxInput.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbxInput.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbxInput.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbxInput.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbxInput.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (tbxInput.Text != "")
                tbxInput.Text += "0";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            tbxInput.Text += ".";
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            double input;
            bool isNum = double.TryParse(tbxInput.Text, out input);

            if (isNum)
            {
                if (rdbCtoF.Checked)
                {
                    lblOutput.Text = $"{input}℃ → {input / 5 * 9 + 32:N2}℉";
                }
                else if (rdbFtoC.Checked)
                {
                    lblOutput.Text = $"{input}℉ → {(input - 32) / 9 * 5:N2}℃";
                }
            }
            else
                MessageBox.Show("請輸入數字！");

            if (!(rdbCtoF.Checked || rdbFtoC.Checked))
                MessageBox.Show("請選擇攝氏或華氏轉換！");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxInput.Text = "";
        }
    }
}
