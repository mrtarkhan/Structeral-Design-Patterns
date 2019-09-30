using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var component = new Component();
            var decorated = new DecoratedComponent(component);
            decorated.DoOperation();
        }
    }
}
