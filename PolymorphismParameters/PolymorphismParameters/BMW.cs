using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismParameters
{
    // a BMW is a Car
    class BMW : Car
    {
        public string Model { get; set; }

        private string brand = "BMW";
        

        public BMW ( string model, int hp, string color) : base (hp, color)
        {
            this.Model = model;           
          
        }
        public new void ShowDetails()
        {
            Console.WriteLine("Brand " + brand +  HP + " HP " + " color " + Color);
        }
        public sealed override void Repair()
        {
            Console.WriteLine("Car {0} was repaired!", Model);
        }
    }
}
