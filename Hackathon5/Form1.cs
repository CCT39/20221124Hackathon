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

namespace Hackathon5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            DateTime target = dateTimePicker1.Value;

            string input = target.ToString("yyyy") + target.ToString("MM") + target.ToString("dd");
            string date = AddByDigits(input);

            int magicNum = CountMagicNum(date);
            var zodiac = GetZodiac(target);
            Analysis(zodiac, magicNum);
        }

        private int CountMagicNum(string s)
        {
            do
            {
                s = AddByDigits(s);
            } while (int.Parse(s) > 9);

            return Convert.ToInt32(s);
        }

        private string AddByDigits(string s)
        {
            List<int> ints = new List<int>();

            char[] splitted = s.ToCharArray();
            foreach (char d in splitted)
            {
                ints.Add(Convert.ToInt32(d - '0'));
            }

            return ints.Sum().ToString();
        }

        private void Analysis(Zodiacs z, int magicNumber)
        {
            string zodiac = GetZodiacName(z);

            string source = "生命靈數.txt";
            var database = File.ReadLines(source);

            int indexZ = (int)z * 20 + 1;
            int indexM = magicNumber * 2;
            string result = string.Empty;

            result = Enumerable.ElementAt(database, indexZ + indexM - 1);

            lblResult.Text = $"{zodiac}、{result.TrimStart()}";
        }

        private string GetZodiacName(Zodiacs z)
        {
            List<string> zodiacs = new List<string>()
            {
                "水瓶座", "雙魚座", "牧羊座", "金牛座",
                "雙子座", "巨蟹座", "獅子座", "處女座",
                "天秤座", "天蠍座", "射手座", "摩羯座",
            };

            return zodiacs[(int)z];
        }

        private Zodiacs GetZodiac(DateTime dt)
        {
            Zodiacs zodiac = new Zodiacs();
            dt = dt.AddYears(1970 - dt.Year);

            List<DateTime> dateFloors = new List<DateTime>()
            {
                new DateTime(1970, 1, 20),
                new DateTime(1970, 2, 19),
                new DateTime(1970, 3, 21),
                new DateTime(1970, 4, 20),
                new DateTime(1970, 5, 21),
                new DateTime(1970, 6, 21),
                new DateTime(1970, 7, 23),
                new DateTime(1970, 8, 23),
                new DateTime(1970, 9, 23),
                new DateTime(1970, 10, 23),
                new DateTime(1970, 11, 21),
                new DateTime(1970, 12, 21),
            };

            if (dt > dateFloors[dateFloors.Count() - 1] || dt < dateFloors[0])
                zodiac = Zodiacs.Capricorn;
            else
            {
                for (int i = 0; i < dateFloors.Count() - 1; i++)
                {
                    if (dt > dateFloors[i] && dt < dateFloors[i + 1])
                    {
                        zodiac = (Zodiacs)i;
                        break;
                    }
                }
            }

            return zodiac;
        }
    }

    internal enum Zodiacs
    {
        Aquarius, Pieces, Aries, Taurus, Gemini, Cancer, 
        Leo, Virgo, Libra, Scorpio, Sagittarius, Capricorn
    }
}
