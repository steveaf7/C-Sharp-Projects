using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    interface IWalkAway
    {
        // everything's public in an interface, therefore you don't have to declare it public. 

        void WalkAway(Player player);
    }
}
