using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uusmang
{
    internal class Snake:Figure
    {
        public Snake(Point tall, int lenght, Direction derection)
        {
            plist = new List<Point>();
            for (int n = 0; n < lenght; n++)
            {
                Point p = new Point(tall);
                p.Move(n, derection);
                plist.Add(p);   
            }
        }
    }
}
