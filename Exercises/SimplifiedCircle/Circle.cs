using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplifiedCircle
{
    class Circle
    {
        private double radius;
        private double π = 3.14159265359;
        public Circle()
        {
            radius = 1.0;
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double getRadius()
        {
            return radius;
        }
        public void setRadius(double radious)
        {
            this.radius = radius;
        }
        public double getArea()
        {
            return radius * radius * Math.PI;
        }
        public override string ToString()
        {
            return String.Format("Circle[radius = {0}", radius);
            //return.base.Tostring();
        }
        public double getCircumference()
        {
            return radius * radius * π;
        }

    }
}
