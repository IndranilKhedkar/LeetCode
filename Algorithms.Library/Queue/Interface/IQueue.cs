namespace Algorithms.Library.Queue.Interface
{
    public interface IQueue<T>
    {
        int Count { get; }

        bool IsEmpty();

        void Enqueue(T item);

        T Dequeue();

        T Peek();

        string ToString();
    }
}
