using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcIFelse
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;
            string action;

            Console.WriteLine("Выберете действие: '+'  '-'  '/'  '*' ");
            action = Console.ReadLine();

            Console.WriteLine("Первое число");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Втрое число");
            secondValue = double.Parse(Console.ReadLine());

            if (action == "+")
            {
                Console.WriteLine(firstValue + secondValue);                
            }
            if (action == "-")
            {
                Console.WriteLine(firstValue - secondValue);
            }
            if (action == "/")
            {
                Console.WriteLine(firstValue / secondValue);
            }
            if (action == "*")
            {
                Console.WriteLine(firstValue * secondValue);
            }
        }
    }
}
