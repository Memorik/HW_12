using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Normar_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            string chose;
            while (true) 
            {

                Console.Write("Enter expression: "); 
                Console.WriteLine(Calculator.Calculate(Console.ReadLine()));
                Console.WriteLine("If u want to exit write: '-+-' ");
                Console.WriteLine("If u want to calculate: Enter");
                chose = Console.ReadLine();
                if (chose == "-+-")
                {
                    break;
                }
            }
        }
    }
}
