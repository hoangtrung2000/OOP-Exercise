using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplifiedCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            Console.WriteLine("The circle has radius" + " " + c1.getRadius() + " " + " and area of" + " " + c1.getArea());

            Circle c2 = new Circle(2.0);
            Console.Write("The circle has radius" + " " + c2.getRadius() + " " + " and area of" + " " + c2.getCircumference());
        }
    }
}
