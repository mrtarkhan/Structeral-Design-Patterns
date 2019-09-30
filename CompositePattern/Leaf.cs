using System;

namespace CompositePattern
{
    public class Leaf : IComponent
    {
        public void Add(IComponent component)
        {
            throw new Exception("this is the leaf");
        }

        public void DoOperation()
        {
            Console.WriteLine($"this is the {nameof(Leaf)}");
        }

        public void List()
        {
            Console.WriteLine($"this is the {nameof(Leaf)}");
        }

        public void Remove(IComponent component)
        {
            throw new Exception("this is the leaf");
        }

        public bool IsLeaf()
        {
            return true;
        }

    }
}