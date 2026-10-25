namespace delegates;

public static class CollectionHelper
{
    public static IEnumerable<T> FilterCollection<T>(this IEnumerable<T> collection, Func<T, bool>predicate)
    {
        List<T> result = new List<T>();
        foreach (var item in collection)
        {
            if (predicate(item))
            {
                result.Add(item);
            }
        }
        return result;
    }

    public static T firstOrDefault<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        foreach (var item in collection)
        {
            if (predicate(item))
            {
                return item;
            }
        }
        return default(T);
    }

    public static bool any<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        foreach (var item in collection)
        {
            if (predicate(item))
            {
                return true;
            }
        }
        return false;
    }

    public static bool all<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        foreach (var item in collection)
        {
            if (!predicate(item))
            {
                return false;
            }
        }
        return true;
    }

    public static int count<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        int count = 0;
        foreach (var item in collection)
        {
            if (predicate(item))
            {
                count++;
            }
        }
        return count;
    }
}