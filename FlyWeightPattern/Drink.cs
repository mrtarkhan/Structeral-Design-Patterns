using System;

namespace FlyWeightPattern
{
    public class Drink: Flyweight
    {
        public Drink()
        {
            Name = "drink";
            Description = "this is a drink";
        }
        public string Place { get; set; }


        public void SetPlace (string location) {
            this.Place = location;
        }

        public override void DoOperation() {
            Console.WriteLine($"the name is {Name} and the description is  \"{Description}\" in {Place}");
        }
    }
}