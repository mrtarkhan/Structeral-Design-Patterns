using System;

namespace ProxyPattern
{
    public class Service : IService
    {
        public void DoOperation() {
            Console.WriteLine($"this is the operation from {nameof(Service)}");
        }
    }
}