using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2.Lesson_6
{
    internal class Figure
    {
        string _figure = string.Empty;

        public enum Status
        {
            Visible,
            UnVisible
        }

        public enum Colors
        {            
            Red,
            Green,
            Blue
        }

        private double _sizeHeight;

        private double _sizeWidth;

        private ConsoleColor _color;

        private Status _statusFigure;

        public double SizeWidth
        {
            get { return _sizeWidth; }
            set { _sizeWidth = value; }
        }

        public double SizeHeight
        {
            get { return _sizeHeight; }
            set { _sizeHeight = value; }
        }

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
        public Figure(string figure, double sizeHeight, double sizeWidth)
        {
            _figure = figure;
            SizeWidth = sizeWidth;
            SizeHeight = sizeHeight;
        }
        public void MoveUp()
        {
            if (SizeHeight > 0)
            {
                SizeHeight--;
            }
            Write(_figure, SizeWidth, SizeHeight);
        }

        public void MoveDown()
        {
            SizeHeight++;
            Write(_figure, SizeWidth, SizeHeight);
        }

        public void MoveLeft()
        {
            SizeHeight++;
            Write(_figure, SizeWidth, SizeHeight);
        }
        public void MoveRight()
        {
            SizeWidth++;
            Write(_figure, SizeWidth, SizeHeight);
        }

        public void MoveColorVisible()
        {
                    Random random = new Random();
                    var move = random.Next(-1, 3);
                    switch (move)
                    {
                        case 0:
                            MoveDown();
                            break;
                        case 1:
                            MoveLeft();
                            break;
                        case 2:
                            MoveRight();
                            break;
                        case 3:
                            MoveUp();
                            break;
                    }
                    move = random.Next(-1, 2);
                    switch (move)
                    {
                        case 0:
                            Color = ConsoleColor.Red;
                            break;
                        case 1:
                            Color = ConsoleColor.Green;
                            break;
                        case 2:
                            Color = ConsoleColor.Blue;
                            break;
                    }
        }

        private void Write(string toWrite, double SizeWidth = 0, double SizeHeight = 0)
        {
            try
            {
                if (SizeWidth >= 0 && SizeHeight >= 0) // 0-based
                {
                    Console.Clear();
                    Console.SetCursorPosition((int)SizeWidth, (int)SizeHeight);
                    Console.Write(toWrite);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
