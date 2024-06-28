using System.Collections;

namespace Task4;

public static class Extensions
{
    public static T[] GetArray<T>(this IEnumerable<T> list)
    {
        if (list is ICollection<T> collection)
        {
            T[] array = new T[collection.Count];
            collection.CopyTo(array,0);
            return array;
        }

        List<T> resultList = new List<T>();
        foreach (T item in list)
        {
            resultList.Add(item);
        }

        return resultList.ToArray();
    }
}