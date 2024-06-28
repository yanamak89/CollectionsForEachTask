using System;
using System.Collections;
using System.Collections.Generic;

public class MyDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
{
    private List<TKey> _keys;
    private List<TValue> _values;

    public MyDictionary()
    {
        _keys = new List<TKey>();
        _values = new List<TValue>();
    }

    // Метод для додавання елемента
    public void Add(TKey key, TValue value)
    {
        if (_keys.Contains(key))
        {
            throw new ArgumentException("An element with the same key already exists.");
        }
        _keys.Add(key);
        _values.Add(value);
    }

    // Індексатор для отримання значення за ключем
    public TValue this[TKey key]
    {
        get
        {
            int index = _keys.IndexOf(key);
            if (index == -1)
            {
                throw new KeyNotFoundException("The key was not found in the dictionary.");
            }
            return _values[index];
        }
    }

    // Властивість для отримання кількості елементів
    public int Count
    {
        get { return _keys.Count; }
    }

    // Реалізація інтерфейсу IEnumerable<KeyValuePair<TKey, TValue>>
    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
    {
        for (int i = 0; i < _keys.Count; i++)
        {
            yield return new KeyValuePair<TKey, TValue>(_keys[i], _values[i]);
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}