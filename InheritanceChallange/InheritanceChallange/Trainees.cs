using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceChallange
{
    class Trainees: Employee
    {
        protected int WorkingHours { get; set; }
        protected int SchoolHours { get; set; }

        public Trainees() { }

        public Trainees(string name, string firstName, int salary, int workingHours, int schoolHours) : base(name, firstName, salary)
        {
                       
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

       
        public void Learn()
        {
            Console.WriteLine("I'm learning for {0} hours!", SchoolHours);
        }
        public new void Work()
        {
            Console.WriteLine("I work for {0} hours", WorkingHours);
        }

        //public override string ToString()
        //{
        //    return String.Format("{0} {1} has {2}$ salary and {3} working hours and {4} school hours", this.FirstName, this.Name, this.Salary, this.WorkingHours, this.SchoolHours);
        //}
    }
}
