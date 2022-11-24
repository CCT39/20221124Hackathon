using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20221124Hackathon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入大於90的數字！");
            int input;
            bool isNum = int.TryParse(Console.ReadLine(), out input);
            var list = Enumerable.Range(1, input);
            foreach (var i in list)
            {
                if (isNum)
                {
                    if (i % 15 == 0)
                        Console.WriteLine("Dann");
                    else if (i % 5 == 0)
                        Console.WriteLine("School");
                    else if (i % 3 == 0)
                        Console.WriteLine("Build");
                    else
                        Console.WriteLine(i);
                }
                else
                    Console.WriteLine("請輸入大於90的數字！");
            }
            

            Console.ReadLine();
        }
    }
}
