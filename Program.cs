using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Введите первое число: ");
            double side1 = Convert.ToDouble( Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            double side2 = Convert.ToDouble( Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);

            Console.WriteLine($"Площадь прямоугольника: {rectangle.Area}");
            Console.WriteLine($"Периметр прямоугольника: {rectangle.Perimeter}");
            Console.ReadLine();


        }
    }
}
