using System;

namespace FlyWeightPattern
{
    public class Food : Flyweight
    {
        public Food()
        {
            Name = "food";
            Description = "this is a food";
        }
        
        public int Number { get; private set; }

        public void SetNumber (int num) {
            this.Number = num;
        }

        public override void DoOperation() {
            Console.WriteLine($"the name is {Name} and the description is \"{Description}\" and number is {Number}");
        }
    }
}