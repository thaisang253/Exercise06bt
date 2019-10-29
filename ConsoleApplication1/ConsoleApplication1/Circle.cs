using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Circle
    {
        private double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public void setRadius(double r)
        {
            radius = r;
        }
        public double getRadius()
        {
            return radius;
        }

        public double Area()
        {
            return (radius * radius * Math.PI;
        }

        public double getCircumference()
        {
            return 2 * radius * Math.PI; 
        }

        public string toString()
        {
            return "Circle[radius=" + radius +"]";
        }

    }
}
