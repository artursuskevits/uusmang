 
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace uusmang
{
    public class uusmang
    {
        public static void Main(string[] args)
        {
            
            Console.SetWindowSize(80, 25); 
            Console.Clear();
            HorizontallLines upline = new HorizontallLines(0, 78, 0, '+');
            upline.Drow(); 
            HorizontallLines downline = new HorizontallLines(0, 78, 24, '+');
            downline.Drow();
            VertikalLines leftline = new VertikalLines(0, 24, 0, '+');
            leftline.Drow();
            VertikalLines rightline = new VertikalLines(0, 24, 78, '+');
            rightline.Drow();

            Point p1 = new Point(4, 5, '*');
            Snake snake = new Snake(p1, 4, Direction.RIGHT);
            snake.Drow();
            
            snake.Move();
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleeKey(key.Key);
                }
                Thread.Sleep(50);
                snake.Move();
            }


        }

    }
}
