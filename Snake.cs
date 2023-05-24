using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace uusmang
{
    internal class Snake : Figure
    {
        public Direction direction;
        public Snake(Point tall, int lenght, Direction derection, string color)
        {
            direction = derection;
            plist = new List<Point>();
            for (int n = 0; n < lenght; n++)
            {
                Point p = new Point(tall);
                p.Move(n, derection);
                plist.Add(p);
                ConsoleColor consoleColor;
                if (Enum.TryParse(color, out consoleColor))
                {
                    Console.ForegroundColor = consoleColor;
                }
            }

        }

        public void Move(string color)
        {
            Point tail = plist.First();
            plist.Remove(tail);
            Point head = GetNextPoint();
            plist.Add(head);
            tail.Clear();
            head.DrawC(color);
        }
        public Point GetNextPoint()
        {
            Point head = plist.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
        public void HandleeKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }


        internal bool IsHitTail()
        {
            var head = plist.Last();
            for (int i = 0; i < plist.Count - 2; i++)
            {
                if (head.IsHit(plist[i]))
                {
                    return true;
                }
            }
            return false;
        }
        internal (int,int) SlowEat(int speed)
        {

            Point head = GetNextPoint();
            int oldspeed;
            oldspeed = speed;
            speed = speed * 2;

            return (speed, oldspeed);


        }
        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                Console.WriteLine();
                food.sym = head.sym;
                plist.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }
        internal bool SlowEatBool(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
