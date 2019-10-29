using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            Console.WriteLine("The rectangle has length, width " + r1.getLength() + "," + " " + r1.getWidth() + " " 
                + "and area of " + r1.getArea() + " " + "Perimeter " + r1.Perimeter());

            Rectangle r2 = new Rectangle(2, 6);
            Console.WriteLine("The rectangle has length, width " +  r2.getLength() + "," + " " + r2.getWidth() + " " 
                + "and area of " + r2.getArea() + " " + "Perimeter " + r2.Perimeter());
        }
    }
}
