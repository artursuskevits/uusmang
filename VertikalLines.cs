using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uusmang
{
    internal class VertikalLines:Figure
    {
        

        public VertikalLines(int xhigh, int xlow, int y, char sym)
        {
            plist = new List<Point>();
            for (int x = xhigh; x < xlow; x++)
            {
                Point p = new Point(y, x, sym);
                plist.Add(p);
            }
        }
         
    }
}
