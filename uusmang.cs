
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
           

            Point p2 = new Point(4,5,'#');
            
            p2.Draw();

            List<int> numlist = new List<int>();
            numlist.Add(0);
            numlist.Add(1);
            numlist.Add(2);
            numlist.Add(3);
            numlist.Add(4);
            int x = numlist[0];
            int y = numlist[1];
            int z = numlist[2];

            Console.WriteLine();
            foreach (int i in numlist)
            {
                Console.WriteLine(i);
            }
            numlist.Remove(4);
            List<Point> plist = new List<Point>();
            plist.Add(p1);
            plist.Add(p2);  
        }
    
    }
}
