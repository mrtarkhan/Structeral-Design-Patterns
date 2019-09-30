using System;
using System.Collections.Generic;


namespace CompositePattern
{

    //this is the tree structure of our components
    public class Composite : IComponent
    {

        private readonly string _name;
        public Composite(string name)
        {
            _name = name;
        }

        public List<IComponent> Children = new List<IComponent>();

        public void Add(IComponent component)
        {
            Children.Add(component);
        }

        public void DoOperation()
        {
            Console.WriteLine($"this is the {_name} {nameof(Composite)}");
            List();
        }

        public bool IsLeaf()
        {
            return false;
        }

        public void List()
        {
            foreach (var item in Children)
            {
                item.DoOperation();
            }
        }

        public void Remove(IComponent component)
        {
            Children.Remove(component);
        }
    }
}