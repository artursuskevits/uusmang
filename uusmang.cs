 
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace uusmang
{
    public class uusmang
    {
        public static void Main(string[] args)
        {
            
            Console.SetWindowSize(80, 25); 
            HorizontallLines upline = new HorizontallLines(0, 8, 0, '+');
            upline.Drow();
            HorizontallLines downline = new HorizontallLines(0, 78, 24, '+');
            downline.Drow();
            VertikalLines leftline = new VertikalLines(0, 24, 0, '+');
            leftline.Drow();
            VertikalLines rightline = new VertikalLines(0, 24, 78, '+');
            rightline.Drow();

            Point p1 = new Point(1, 3, '*');
            p1.Draw();
           
            
            

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            


        }

    }
}
