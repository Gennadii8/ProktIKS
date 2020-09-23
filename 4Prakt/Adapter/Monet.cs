using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Monet
    {
        Random r;

        public Monet()
        {
            r = new Random();
        }

        public int BrosokM()
        {
            //Случ число от 1 до 2
            int res = r.Next(2) + 1;
            return res;
        }
    }
}
