
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
            Point p1 = new Point();
            p1.x=1;
            p1.y=1;
            p1.sym = '*';
            p1.Draw();
            //int x1 =  1;
            //int y1 = 3;
            //char sym1 = '*'; 
            //Draw(x1, y1, sym1);

            Point p2 = new Point();
            p2.x = 4;
            p2.y = 5;
            p2.sym = '#';
            p2.Draw();
            //int x2 = 4;
            //int y2= 5;
            //char sym2 = '#';
            //Draw(x2, y2, sym2);
        }
    
    }
}
