using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    public class Countdown
    {
        public int[] countdown(int start)
        {
            if (start <= 0)
                throw new ArgumentException("Countdown cannot start below or at zero.");

            int[] result = new int[start + 1];
            for (int count = start; count > 0; count--)
            {
                result[start - count] = count;
            }
            return result;
        }
    }
}
