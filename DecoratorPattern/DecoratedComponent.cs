using System;

namespace DecoratorPattern {
    public class DecoratedComponent : IComponent {

        private readonly IComponent _component;

        public DecoratedComponent(IComponent component) {
            _component = component;
        }

        public void DoOperation () {

            Console.WriteLine($"before base class. {nameof(DecoratedComponent)}");
            _component.DoOperation();
            Console.WriteLine($"after base class. {nameof(DecoratedComponent)}");
        }
    }
}