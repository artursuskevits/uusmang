using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uusmang
{
    public class Speed
    {
        public int Speedchange(int speednow)
        {
            if (speednow>9)
            {
                speednow = speednow - 10;
            }
            return speednow; 
        }
        
    }
}
