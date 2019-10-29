using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheEmployee
{
    class Employees
    {
        private int id;
        private string firstName;
        private string lastName;
        private int salary;
        public Employees(int id, string firstName, string lastName, int salary)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
        }
        public int getID()
        {
            return id;
        }
        public string getFirstName()
        {
            return firstName;
        }
        public string getLastName()
        {
            return lastName;
        }
        public string getName()
        {
            return firstName + lastName;
        }
        public int getSalary()
        {
            return salary;
        }
        public void setSalary(int salary)
        {
            this.salary = salary;
        }
        public int getAnnualSalary()
        {
            return salary * 12;
        }
        public double raiseSalary(int percent)
        {
            int bonus = (salary * percent) / 100;
            salary = salary + bonus;
            return salary;
        }
        public override string ToString()
        {
            return String.Format("Employees[id = {0}, name = firsName lastName , salary = {0}]", id, salary);
            //return base.ToString();
        }
    }
}
