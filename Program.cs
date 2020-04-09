//5. Написать программу, вычисляющую угол между часовой и минутной стрелками для задаваемого с консоли значения времени.


using System;

namespace YanaClock
{
    class Program
    {
        static void Main(string[] args)
        {
            double h, m, degrees;

            Console.WriteLine("Введите количество часов в 12 часовом формате");
            h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите количество минут");
            m = Convert.ToDouble(Console.ReadLine());

            if (h==12)
            h = 0;

            degrees = Math.Abs((h*5*6)-(m*6));

            Console.WriteLine("угол между часовой и минутной стрелкой = " + degrees + " градус." );
        }
    }
}
