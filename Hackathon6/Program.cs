using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<decimal> ceilValues = new List<decimal> { 540000, 1210000, 2420000, 4530000, 10310000 };
            List<decimal> taxRate = new List<decimal> { .05m, .12m, .20m, .30m, .40m, .50m };

            List<decimal> target = new List<decimal> { 100000, 540000, 540001, 1210000, 1218000, 2420000, 2500000, 4530000, 5530000, 10310000, 10710000, };

            // 累進差額
            List<decimal> diff = new List<decimal>() { 0m };
            for (int i = 0; i < ceilValues.Count; i++)
            {
                // diff[i]是多扣的所以要加回來
                diff.Add(ceilValues[i] * (taxRate[i + 1] - taxRate[i]) + diff[i]);
            }

            Console.WriteLine("請輸入年收入：");
            string result;
            //bool isDecimal = decimal.TryParse(Console.ReadLine(), out decimal income);

            foreach (var income in target)
            {
                int level = 0;

                for (int i = 0; i < ceilValues.Count; i++)
                {
                    if (income > ceilValues[ceilValues.Count - 1])
                    {
                        level = ceilValues.Count;
                        break;
                    }
                    else if (income <= ceilValues[i])
                    {
                        level = i;
                        break;
                    }
                }

                result = $"年收入{income:C2} 應繳稅額：" + (income * taxRate[level] - diff[level]).ToString("C2");

                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
