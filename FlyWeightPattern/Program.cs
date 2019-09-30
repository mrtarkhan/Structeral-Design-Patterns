using System;

namespace FlyWeightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var food1 = FlyWeightFactory.GetFlyweight<Food>();
            food1.SetNumber(10);
            food1.DoOperation();

            var food2 = FlyWeightFactory.GetFlyweight<Food>();
            food2.SetNumber(20);
            food2.DoOperation();

            var food3 = FlyWeightFactory.GetFlyweight<Food>();
            food3.SetNumber(30);
            food3.DoOperation();




            var drink1 = FlyWeightFactory.GetFlyweight<Drink>();
            drink1.SetPlace("Tehran");
            drink1.DoOperation();

            var drink2 = FlyWeightFactory.GetFlyweight<Drink>();
            drink2.SetPlace("Uppsala");
            drink2.DoOperation();

            var drink3 = FlyWeightFactory.GetFlyweight<Drink>();
            drink3.SetPlace("Tokyo");
            drink3.DoOperation();





        }
    }
}
