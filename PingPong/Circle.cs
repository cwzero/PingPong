using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    public class Circle
        
    {
        double radius;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Circle's radius must be greater than zero!");
            this.radius = radius;   
        }


        public double getPerimeter()
        {
            return this.radius * Math.PI * 2;
            
        }

        public double getArea()
        {
            return (this.radius * this.radius) * Math.PI;
        }
    }
}
