using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Rectangle
    {
        private float width;
        private float length;
        public Rectangle(float w, float l)
        {
            width = w;
            length = l;
        }

        public float getLength()
        {
            return length;
        }

        public void setLength(float l)
        {
            length = l;
        }

        public float getWidth()
        {
            return length;
        }

        public void setWidth(float w)
        {
            width = w;
        }

        public double getArea()
        {
            return width * length;
        }

        public double getPerimeter()
        {
            return (width + length) * 2;
        }

        public string toString()
        {
            return "Rectangle[width =" + width + ", length = " + length + "]";
        }
    }
}
