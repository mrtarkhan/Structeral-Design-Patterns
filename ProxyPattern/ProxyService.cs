using System;

namespace ProxyPattern
{

    //it is similar to decorator
    //the diff is in proxy we inject the concrete type
    //and also the big diff is the intentation, the proxy is proxy and 
    //the decorator is for adding functionality dynamically
    public class ProxyService : IService
    {

        private readonly Service _service;

        public ProxyService(Service service)
        {
            _service = service;
        }

        public void DoOperation()
        {
            _service.DoOperation();
            Console.WriteLine("operated in proxy");
        }
    }
}