namespace CompositePattern
{
    public interface IComponent
    {
        void DoOperation();

        void Add(IComponent component);

        void Remove(IComponent component);

        void List();

        bool IsLeaf();

    }
}