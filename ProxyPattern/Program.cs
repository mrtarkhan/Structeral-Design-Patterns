using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var proxy = new ProxyService(new Service());
            proxy.DoOperation();
        }
    }
}
