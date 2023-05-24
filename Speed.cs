using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uusmang
{
    public class Speed
    {
        public (int,int) Speedchange(int speednow,int oldspeed)
        {
            if (speednow!=10)
            {
                speednow = speednow - 10;
                oldspeed = oldspeed - 10;
            }
            return (speednow, oldspeed);
        }
        
    }
}
