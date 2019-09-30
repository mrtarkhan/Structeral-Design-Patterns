using System;

namespace FacadePattern
{
    public class SecondService : ISecondService
    {
        public void DoSecondOperation()
        {
            Console.WriteLine("do second operation");
        }
    }
}