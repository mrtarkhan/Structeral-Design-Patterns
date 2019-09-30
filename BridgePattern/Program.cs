using System;

namespace BridgePattern
{
    class Program
    {
        //it will assign implementation at runtime
        static void Main(string[] args)
        {
            var abstraction = new Abstraction(new ComponentA());
            abstraction.DoOperation();

            abstraction = new Abstraction(new ComponentB());
            abstraction.DoOperation();


        }
    }
}
