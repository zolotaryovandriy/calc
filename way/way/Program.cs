using System;


namespace way
{
    class Program
    {
        static void Main(string[] args)
        // 21.08.21 Hard way is open *day 1*
        {
            double firstValue, secondValue;
            string action;

             Console.WriteLine("Что будем делать?: '+'  '-'  '/'  '*'  ");
            action = Console.ReadLine();

            Console.WriteLine("первое число");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("второе число");
            secondValue = double.Parse(Console.ReadLine());


            switch (action)
            {
                case "+":
                    Console.WriteLine(firstValue + secondValue);
                    break;

                case "-":
                    Console.WriteLine(firstValue - secondValue);
                    break;

                case "/":
                    if (secondValue == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя :(");
                    }
                    else
                    {
                        Console.WriteLine(firstValue / secondValue);
                    }
                    break;

                case "*":
                    Console.WriteLine(firstValue * secondValue);
                    break;

                default:
                    Console.WriteLine("Ошибка :)");
                    break;
            }
            Console.ReadLine();
        }
    }
}
