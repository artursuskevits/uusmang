
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
            int x1 =  1;
            int y1 = 3;
            char sym1 = '*';
            Draw(x1, y1, sym1);

            int x2= 4;
            int y2= 5;
            char sym2 = '#';
            Draw(x2, y2, sym2);
        }
    static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
