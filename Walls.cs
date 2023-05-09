using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uusmang
{
    internal class Walls
    {
        List<Figure> wallist;
        public Walls(int mapWidth, int mapHeight)

        {
            wallist = new List<Figure>();
            HorizontallLines upline = new HorizontallLines(0, 78, 0, '+');
            HorizontallLines downline = new HorizontallLines(0, 78, 24, '+');
            VertikalLines leftline = new VertikalLines(0, 24, 0, '+');
            VertikalLines rightline = new VertikalLines(0, 24, 78, '+');
            wallist.Add(upline);
            wallist.Add(downline);
            wallist.Add(leftline);
            wallist.Add(rightline) ;


        }
        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallist)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallist)
            {
                wall.Drow();
            }
        }
    } 
}
