namespace Datastrukturer.Interfaces;

public interface IRepository<T>
{
    void Add(T item);
    T Get(int index);
    void RemoveAt(int index);
    int Count { get; }
}