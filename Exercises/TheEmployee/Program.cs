using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees e1 = new Employees(14027, "Hoang", "Trung", 12000000);
            Console.WriteLine("Employee " + "ID:" + e1.getID() + " " + "Name:" + e1.getName() + " " + "Salary:" + e1.getSalary() + " "
                + "Annual Salary:" + e1.getAnnualSalary() + " " + "Raise Salary:" + e1.raiseSalary(20));

            Employees e2 = new Employees(22222, "Teo", "Kun", 100000000);
            Console.WriteLine("Employee " + "ID:" + e2.getID() + " " + "Name:" + e2.getName() + " " + "Salary:" + e2.getSalary() + " "
    + "Annual Salary:" + e2.getAnnualSalary() + " " + "Raise Salary:" + e2.raiseSalary(20));
        }
    }
}
