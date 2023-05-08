using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uusmang
{
    internal class VertikalLines
    {
        List<Point> plist;

        public VertikalLines(int xhigh, int xlow, int y, char sym)
        {
            plist = new List<Point>();
            for (int x = xhigh; x < xlow; x++)
            {
                Point p = new Point(y, x, sym);
                plist.Add(p);
            }
        }
        public void Drow()
        {
            foreach (Point p in plist)
            {
                p.Draw();
            }
        }
    }
}
