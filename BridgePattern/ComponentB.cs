using System; 

namespace BridgePattern
{
    public class ComponentB : IComponent
    {
        public void DoOperation() {
            Console.WriteLine($"this is the operation from {nameof(ComponentB)}");
        }
    }
}