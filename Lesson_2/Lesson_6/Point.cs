using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2.Lesson_6
{
    internal class Point : Figure
    {
        public const string FigurePoint = ".";
        
        public Point() : base(FigurePoint, sizeHeight: 1, sizeWidth: 1) 
        {

        }
        public Point(double sizeFigureX, double sizeFigureY) : base(FigurePoint, sizeFigureX, sizeFigureY)
        {

        }
    }
}
