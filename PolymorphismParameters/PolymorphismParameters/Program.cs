using System;
using System.Collections.Generic;

namespace PolymorphismParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
           {
               new Audi ("Audi", "A4", 200, "blue"),
               new BMW( "M3", 190, "red")
           };
            
            foreach (var car in cars)
            {
                car.Repair();
            }


            BMW bmwZ4 = new BMW("Z4", 200, "black");
            Audi audiA3 = new Audi("Audi", "A3", 220, "green");
            bmwZ4.ShowDetails();
            audiA3.ShowDetails();

            //Has a relation
            bmwZ4.SetCarIDInfo(1234, "Illia N");
            audiA3.SetCarIDInfo(1235, "Paul P");
            bmwZ4.GetCarIDInfo();
            audiA3.GetCarIDInfo();

            Car carB = (Car)bmwZ4;
            carB.ShowDetails();

            M3 myM3 = new M3("M3", 260, "gold");
            myM3.Repair();
            
            
            //Car car1 = new Car(354, "black");
            //car1.ShowDetails();
            //car1.Repair();

            //Audi etron = new Audi("Audi", "E-tron", 586, "dark green");
            //etron.ShowDetails();
            //etron.Repair();

            //BMW bmw328i = new BMW("328i", 340, "white");
            //bmw328i.ShowDetails();
            //bmw328i.Repair();

            Console.ReadKey();
        }
    }
}
