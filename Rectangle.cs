using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    class Rectangle
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        
        public Rectangle(double side1, double side2) // Конструктор с параметрами
        {
            Side1 = side1;
            Side2 = side2;
        }

        
        public double PerimeterCalculator() //Периметр
        {
            return 2 * (Side1 + Side2);
        }

        
        public double AreaCalculator() // Площадь
        {
            return Side1 * Side2;  
        }

        public double Perimeter => PerimeterCalculator();
        public double Area => AreaCalculator();
    }
}
