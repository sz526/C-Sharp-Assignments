namespace Datastrukturer.Models;
using Datastrukturer.Interfaces;

public class DataContainer<T> : IRepository<T>
{
    private List<T> _items = new List<T>();

    public int Count => _items.Count;

    public void Add(T item)
    {
        _items.Add(item);
    }

    public T Get(int index)
    {
        if (index < 0 || index >= _items.Count)
            throw new IndexOutOfRangeException();
            
        return _items[index];
    }

    public void RemoveAt(int index)
    {
        _items.RemoveAt(index);
    }
}