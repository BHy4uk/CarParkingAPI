using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceChallange
{
    class Employee
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        public Employee()
        {
            this.Name = "N";
            this.FirstName = "Illia";
            this.Salary = 0;
        }
        public Employee( string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        public void Work()
        {
            Console.WriteLine("I'm working");
        }

        public void Pause()
        {
            Console.WriteLine("I'm having a break");
        }
        public override string ToString()
        {
            return String.Format("{0} {1} has {2}$ salary", this.FirstName, this.Name, this.Salary);
        }
    }
}
