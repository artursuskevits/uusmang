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
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tall);
                p.Move(i, derection);
                plist.Add(p);   
            }
        }
    }
}
