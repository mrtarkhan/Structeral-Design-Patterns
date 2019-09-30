using System;

namespace FacadePattern
{
    public class FacadeService : IFacadeService
    {
        private readonly IFirstService _firstService; 
        private readonly ISecondService _secondService;

        public FacadeService(IFirstService firstService, ISecondService secondService)
        {
            _firstService = firstService;
            _secondService = secondService;
        }

        public void DoOperation()
        {
            Console.WriteLine("facade started.");
            _firstService.DoFirstOperation();
            Console.WriteLine("between services.");
            _secondService.DoSecondOperation();
            Console.WriteLine("facade finished.");
        }
    }
}