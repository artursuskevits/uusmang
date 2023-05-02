
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
           

            Point p2 = new Point();
            p2.x = 4;
            p2.y = 5;
            p2.sym = '#';
            p2.Draw();
            
        }
    
    }
}
