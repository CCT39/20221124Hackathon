using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random ran = new Random();
        string[] ans = new string[4];
        int a = -1;
        List<string> gameHistory;

        private void btnStart_Click(object sender, EventArgs e)
        {
            ForBegin();
            gameHistory = new List<string>();

            int temp;
            do
            {
                temp = ran.Next(1000, 10000);
            } while (temp.ToString().ToCharArray().Distinct().Count() < 4);

            ans = ConvertToStringArray(temp.ToString());
            a = temp;

            gameHistory.Add("開始遊戲！");

            listBox1.DataSource = gameHistory;
        }

        private void btnCheckAns_Click(object sender, EventArgs e)
        {
            bool isNum = int.TryParse(tbxInput.Text, out int guess);

            if (isNum && guess >= 0 && guess < 10000)
            {
                var temp = ConvertToStringArray(guess.ToString("D4"));
                int[] countAB = { 0, 0 };

                for (int i = 0; i < ans.Length; i++)
                {
                    if (ans[i] == temp[i])
                        countAB[0] += 1;
                    else if (ans.Contains(temp[i]))
                        countAB[1] += 1;
                }
                gameHistory.Add($"{guess.ToString("D4")}：{countAB[0]}A{countAB[1]}B");

                if (a == guess)
                {
                    gameHistory.Add("過關！");
                    MessageBox.Show("過關！");
                    GameOver();
                }
                ChangeData();
            }
            else
                MessageBox.Show("請輸入4位數字！", "錯誤");
        }

        private string[] ConvertToStringArray(string source)
        {
            return string.Join("%", source.ToString().ToCharArray()).Split('%');
        }

        private void ChangeData()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = gameHistory;
        }

        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            GameOver();
            ChangeData();
        }

        private void ForBegin()
        {
            btnCheckAns.Enabled = true;
            btnGiveUp.Enabled = true;
            btnGetAns.Enabled = true;
            tbxInput.Enabled = true;

            btnStart.Enabled = false;

            tbxInput.Text = "";
        }

        private void GameOver()
        {
            btnCheckAns.Enabled = false;
            btnGiveUp.Enabled = false;
            btnGetAns.Enabled = false;
            tbxInput.Enabled = false;

            btnStart.Enabled = true;
        }

        private void btnGetAns_Click(object sender, EventArgs e)
        {
            MessageBox.Show(a.ToString());
            
            /*
            gameHistory.Add($"答案是：{a}");
            GameOver();
            ChangeData();*/
        }
    }
}
