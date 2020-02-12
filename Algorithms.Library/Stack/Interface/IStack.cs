namespace Algorithms.Library.Stack.Interface
{
    public interface IStack<T>
    {
        int Count { get; }

        bool IsEmpty();

        void Push(T item);

        T Pop();

        T Peek();

        string ToString();
    }
}
