using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    public class TeaParty
    {
        public String welcome(String lastName, Boolean isWoman, Boolean isSir)
        {
            if (isWoman && isSir)
            {
                throw new ArgumentException(lastName + " should not be both a lady and a sir.");
            }

            if (isWoman)
            {
                return "Hello Ms. " + lastName;
            }
            else if (isSir)
            {
                return "Hello Sir " + lastName;
            }
            else
            {
                return "Hello Mr. " + lastName;
            }
        }
    }
}
