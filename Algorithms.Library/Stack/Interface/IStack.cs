namespace Algorithms.Library.Stack.Interface
{
    public interface IStack<T>
    {
        int Count { get; }

        T Top { get; }

        bool IsEmpty();

        void Push(T item);

        T Pop();

        string ToString();
    }
}
