using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace uusmang
{
    internal class SnakeColor
    {
        
        List<string> colors = new List<string>()
        {
            "Black",
            "DarkBlue",
            "DarkGreen",
            "DarkRed",
            "DarkMagenta",
            "DarkYellow",
            "Gray",
            "DarkGray",
            "Blue",
            "Green",
            "Cyan",
            "Red",
            "Magenta",
            "Yellow"
        };

        public string ChooseColor()
        {
            Console.WriteLine();
            int count = 0;
            Console.WriteLine("Choose snake color");

            foreach (string item in colors)
            {
                count++;
                Console.WriteLine("{0} --> {1}", count, item);
            }

            int UserChoice = Convert.ToInt32(Console.ReadLine());
            int colorslength = colors.Count;

            if (UserChoice > colorslength + 1)
            {
                Console.WriteLine("SEE ON VIGA NUMBER!!!!");
                return "";  // Return an empty string in case of an invalid choice
            }
            else
            {
                string snakecolor = colors[UserChoice - 1];
                Console.WriteLine(snakecolor);
                return snakecolor;
            }
        }
    }
    
}
