 
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
            Point p1 = new Point(1, 3, '*');
            p1.Draw();
           
            
            

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontallLines line = new HorizontallLines(5, 10, 8, '+');
            line.Drow();

            
            VertikalLines vline = new VertikalLines(5, 10, 0, '+');
            vline.Drow();



        }

    }
}
