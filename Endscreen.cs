using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uusmang
{
    internal class Endscreen
    {
        public void Showendscreen(Dictionary<string, int> esimine, string key, int value)
        {
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("{0} your result is {1}",key,value);
            Points pointsObject = new Points();
            Console.WriteLine("");
            pointsObject.ShowLeaderboard(esimine);
            Console.ReadLine();
        }
    }
}
