using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2.Lesson_6
{
    internal class Rectangle : Point
    {
        private double _area;

        public double Area
        {
            get { return AreaOfRectangle(); }
        }
        public Rectangle(double sizeHeight, double sizeWidth) : base(sizeHeight, sizeWidth)
        {
            Console.WriteLine($"Площадь Прямоугольника:  {Area}");
            Drawer();
        }
        public void Drawer()
        {
            for (int i = 0; i <= SizeHeight; i++)
            {
                for (int j = 0; j <= SizeWidth; j++)
                {
                        Console.Write(FigurePoint);
                }
                Console.WriteLine();
            }
        }
        private double AreaOfRectangle()
        {           
            return SizeHeight * SizeWidth;
        }
    }
}
