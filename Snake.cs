using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uusmang
{
    internal class Snake:Figure
    {
        Direction direction;
        public Snake(Point tall, int lenght, Direction derection)
        {
            direction= derection;
            plist = new List<Point>();
            for (int n = 0; n < lenght; n++)
            {
                Point p = new Point(tall);
                p.Move(n, derection);
                plist.Add(p);   
            }
        }

        public void Move()
        {
            Point tail = plist.First();
            plist.Remove(tail);
            Point head = GetNextPoint();
            plist.Add(head);
            tail.Clear();
            head.Draw();
        }
        public Point GetNextPoint()
        {
            Point head = plist.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
    }
}
