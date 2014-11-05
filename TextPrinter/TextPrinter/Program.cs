using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            rpgText("May the force be with you.");

            Console.ReadKey();
        }
        static void rpgText(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i]);
                Thread.Sleep(100);
            }
            
        }
    }
}
