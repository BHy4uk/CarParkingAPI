using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceChallange
{
    class Boss : Employee
    {
        protected string CompanyCar { get; set; }

        public Boss() { }

        public Boss(string name, string firstName, int salary, string companyCar): base(name, firstName, salary)
        {
           
            this.CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine("I'm boss! I have {0}$ salary and {1} car", Salary, CompanyCar);

        }
        //public override string ToString()
        //{
        //    return String.Format("{0} {1} has {2}$ salary and {3} company car", this.FirstName, this.Name, this.Salary, this.CompanyCar);
        //}
    }
}
