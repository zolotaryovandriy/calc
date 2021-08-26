using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middle
{
    class Program
    {
        static void Main(string[] args)
            // Среднее арифметическое чисел
        {
            double firstValue, secondValue, thirdValue;

            Console.WriteLine("Введите первое число:");
            firstValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            secondValue = int.Parse(Console.ReadLine());

            thirdValue = ((firstValue + secondValue) / 2);

            Console.WriteLine("Среднее арифметическое чисел = " + thirdValue);

            Console.ReadLine();
        }
    }
}
