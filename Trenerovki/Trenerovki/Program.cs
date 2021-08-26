using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trenerovki
{
    class Program
    {
        static void Main(string[] args)
        {
            uint oddNumber = 0; //нечетные
            uint evenNumber = 0; //четные

            Console.WriteLine("Первое число диапазона:");
            int curruentValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Второе число диапазона:");
            int limit = int.Parse(Console.ReadLine());

            while (curruentValue <= limit)
            {
                if (curruentValue % 2 == 0)
                {
                    evenNumber++;
                }
                else
                {
                    oddNumber++;
                }
                curruentValue++;
            }

            Console.WriteLine("Нечетных чисел:" + oddNumber);
            Console.WriteLine("Четных чисел:" + evenNumber);
            Console.ReadLine();
        }
    }
}