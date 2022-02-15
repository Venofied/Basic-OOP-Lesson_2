using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2.Lesson_6
{
    internal class Circle : Point
    {

        private double _area;

        public double Area
        {
            get { return AreaOfCircle(); }
        }

        public Circle(double sizeHeight) : base(sizeHeight, 0)
        {
            Drawer();
            Console.WriteLine($"Площадь окружности:  {Area}");
        }

        public void Drawer()
        {
            //Console.WindowHeight = 70;
            //Console.WindowWidth = 110;
            int x = 0;
            for (int y = 0; y < SizeHeight; ++y)
            {
                x = (int)Math.Round(2 * Math.Sqrt((Math.Pow(SizeHeight, 2) - Math.Pow(y, 2))));

                Console.SetCursorPosition((int)(x + SizeHeight), (int)(y + SizeHeight));
                Console.Write(FigurePoint);
                Console.SetCursorPosition((int)(x + SizeHeight), (int)(-y + SizeHeight));
                Console.Write(FigurePoint);
                Console.SetCursorPosition((int)(-x + 2 * SizeHeight), (int)(-y + SizeHeight));
                Console.Write(FigurePoint);
                Console.SetCursorPosition((int)(-x + 2 * SizeHeight), (int)(y + SizeHeight));
                Console.Write(FigurePoint);
            }


            Console.SetCursorPosition(0, (int)SizeHeight * 2 + 2);
            MoveColorVisible();
            Console.Clear();
        }


        private double AreaOfCircle()
        {
            var Area = Math.PI * (SizeHeight / 2);
            return Area;
        }
    }
}
