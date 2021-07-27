using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismParameters
{
    class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        //Has a relationship
        protected CarIdInfo carIdInfo = new CarIdInfo();

        public void SetCarIDInfo(int idNum, string owner)
        {
            carIdInfo.IDNum = idNum;
            carIdInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine("The car has the ID of {0} and is owned by {1}", carIdInfo.IDNum, carIdInfo.Owner);
        }

        public Car() { }

        public Car (int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

       
        public  void ShowDetails()
        {
            Console.WriteLine("This car has {0}hp and {1} color", this.HP, this.Color);
        }
         public virtual void Repair()
        {
            Console.WriteLine("Car was repaired!");
        }
    }
}
