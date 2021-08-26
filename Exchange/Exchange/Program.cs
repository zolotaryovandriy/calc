using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange
{
    class Program
    {
        static void Main(string[] args)
            //      GRIVNA TO DOLLAR
        {
            double first, second, third;

            Console.WriteLine("Введите кол-во гривны для конвертации в доллары");
            first = int.Parse(Console.ReadLine());

            second = 0.037;
            third = (first * second);

            Console.WriteLine(third);

            
        }
    }
}
