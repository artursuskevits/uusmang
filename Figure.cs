﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uusmang
{
    internal class Figure
    {
        protected List<Point> plist;
        public void Drow()
        {
            foreach (Point p in plist)
            {
                p.Draw();
            }
        }
        public void DrowCol(string color)
        {
            foreach (Point p in plist)
            {
                ConsoleColor consoleColor;
                if (Enum.TryParse(color, out consoleColor))
                {
                    Console.ForegroundColor = consoleColor;
                }
                p.Draw();
            }
        }
        internal bool IsHit(Figure figure)

        {
            foreach (var p in plist)
            {
                if (figure.IsHit(p))
                    return true;
            }
            return false;
        }
        private bool IsHit(Point point)

        {
            foreach (var p in plist)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }
    }
}
