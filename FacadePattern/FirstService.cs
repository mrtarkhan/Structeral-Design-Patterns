using System;

namespace FacadePattern
{
    public class FirstService : IFirstService
    {
        public void DoFirstOperation()
        {
            Console.WriteLine("do first operation");
        }
    }
}