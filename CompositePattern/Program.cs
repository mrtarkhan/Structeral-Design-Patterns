using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var leaf = new Leaf();

            var mainTree = new Composite("main tree");
            var subTree1 = new Composite("sub tree 1");
            subTree1.Add(new Leaf());
            subTree1.Add(new Leaf());

            var subTree2 = new Composite("sub tree 2");
            subTree2.Add(new Leaf());

            mainTree.Add(subTree1);
            mainTree.Add(subTree2);

            mainTree.DoOperation();
            
        }      
            
    }
}
