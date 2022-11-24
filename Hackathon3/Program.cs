using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入有意義的英文敘述字串（不區分大小寫）：");
            Dictionary<string, int> dic = new Dictionary<string, int>();

            var input = Console.ReadLine().ToLower().TrimEnd('.').Split(' ').ToList();

            foreach (var i in input)
                if (string.IsNullOrEmpty(i))
                    input.Remove(i);

            var types = input.Distinct();

            foreach (var type in types)
            {
                var count = input.FindAll(x => x == type).Count();
                Console.WriteLine($"{type}：{count}個");
            }

            Console.ReadLine();
        }
    }
}
