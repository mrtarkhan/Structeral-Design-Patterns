using System;

namespace DecoratorPattern {
    public class Component : IComponent {
        public void DoOperation () {
            Console.WriteLine($"this is the base class. {nameof(Component)}");
        }
    }
}