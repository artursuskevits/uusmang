using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uusmang
{
    internal class HorizontallLines : Figure
    {
         
        public HorizontallLines(int xleft, int xright, int y, char sym)
        {
            plist = new List<Point>();
            for (int x = xleft; x < xright; x++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }
        }

    }
}
