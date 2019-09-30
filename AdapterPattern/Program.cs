using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var adaptee = new Adapter(new Adaptee());
            adaptee.ShowVersion();
            
        }
    }
}
