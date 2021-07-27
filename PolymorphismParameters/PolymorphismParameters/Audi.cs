using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismParameters
{
    // a Audi is a Car
    class Audi : Car
    {
        public string Model { get; set; }

        private string brand = "Audi";
        public Audi() { }

        public Audi(string brand, string model, int hp, string color) : base(hp, color)
        {
            this.Model = model;
        }
        public new void ShowDetails()
        {
            Console.WriteLine("It is a {0}, model- {1} has {2}hp and {3} color", brand, this.Model, this.HP, this.Color);
        }
        public override void Repair()
        {
            Console.WriteLine("Car {0} was repaired!", brand);
        }
    }
}
