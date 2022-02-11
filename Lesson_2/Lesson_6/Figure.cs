using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2.Lesson_6
{
    internal class Figure
    {
        public enum Status
        {
            Visible,
            UnVisible
        }

        private ConsoleColor _color;

        private Status _statusFigure;

        public Status StatusFigure
        {
            get { return _statusFigure; }
            set { _statusFigure = value; }
        }

        public ConsoleColor Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public Figure()
        {

        }
        public void MoveUp()
        {

        }

    }
}
