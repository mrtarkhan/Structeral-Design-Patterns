using System; 

namespace BridgePattern
{
    public class ComponentA : IComponent
    {
        public void DoOperation() {
            Console.WriteLine($"this is the operation from {nameof(ComponentA)}");
        }
    }
}