using System;

namespace InheritanceChallange
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee illia = new Employee("Illia", "Rossoneri", 15000);
            illia.Work();
            illia.Pause();

            Boss boss = new Boss("Illia", "Necheporenko", 2500 , "Audi E-tron");
            boss.Lead();

            Trainees trainee = new Trainees("Alex", "Dumkopf", 1100, 150, 650);
            trainee.Work();
            trainee.Learn();
                       
           
         

            Console.ReadLine();
        }
    }
}
