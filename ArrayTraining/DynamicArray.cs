using System.Collections;

namespace ArrayTraining;

public class DynamicArray<T> : IEnumerable
{
    private T[] _items = new T[4];
    private int _counter = -1;

    public void Add(T item)
    {
        int nextIndex = _counter + 1;
        if (nextIndex == _items.Length)
        {
            T[] resized = new T[_items.Length * 2];
            Array.Copy(_items, resized, _items.Length);
            _items = resized;
        }

        _items[nextIndex] = item;

        _counter = nextIndex;
    }

    public void Delete(int index)
    {
        for (int a = index; a < _items.Length - 1; a++)
        {
            _items[a] = _items[a + 1];
        }

        _counter--;

        Array.Resize(ref _items, _items.Length - 1);
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index > _counter)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }

            return _items[index];
        }
        set
        {
            if (index < 0 || index > _counter)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }

            _items[index] = value;
        }
    }

    public IEnumerator GetEnumerator()
    {
        return _items.GetEnumerator();
    }
}