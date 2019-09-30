
namespace BridgePattern
{
    public class Abstraction
    {
        private readonly IComponent _component;

        public Abstraction(IComponent component)
        {
            _component = component;
        }


        public void DoOperation() {
            _component.DoOperation();
        }

    }
}