using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    public class Rectangle
    {
        double length = 0;
        double width = 0;

        public Rectangle(double length, double width)
        {
            if (length <= 0 || width <= 0)
            {
                throw new ArgumentException("Rectangle's length and width must be greater than zero!");
            }
            this.length = length;
            this.width = width;
        }

        public double getPerimeter()
        {
            return 2 * (length + width);
        }

        public double getArea()
        {
            return length * width;
        }
    }
}
