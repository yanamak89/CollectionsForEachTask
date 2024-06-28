using System.Collections;

namespace Task2;

public class MyList<T> : IEnumerable<T>
{
    private T[] _items;
    private int _count;

    public MyList()
    {
        _items = new T[4];
        _count = 0;
    }

    // Метод для додавання елемента
    public void Add(T item)
    {
        if (_count == _items.Length)
        {
            Array.Resize(ref _items, _items.Length * 2);
        }
        _items[_count++] = item;
    }

    // Індексатор для отримання елемента за індексом
    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= _count)
            {
                throw new IndexOutOfRangeException("Index was out of range.");
            }

            return _items[index];
        }
    }

    // Властивість для отримання кількості елементів
    public int Count
    {
        get { return _count; }
    }

    // Реалізація інтерфейсу IEnumerable<T>
    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < _count; i++)
        {
            yield return _items[i];
        }
    }
    // Необхідно також реалізувати метод IEnumerable.GetEnumerator()

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }


}