using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new FacadeService(new FirstService(), new SecondService());
            service.DoOperation();
        }
    }
}
