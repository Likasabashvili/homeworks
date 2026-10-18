namespace generic.Models;

public class ArrayHelper<T>
{
    public ArrayHelper()
    {

    }

    public string PrintReverse(T[] array)
    {
        return string.Join(", ", array.Reverse());
    }
    public T GetFirstElement(T[] array)
    {
        return array[0];
    }

    public T GetLastElement(T[] array)
    {
        return array[array.Length - 1];
    }

    public bool ContainsElement(T[] array, T element)
    {
        return array.Contains(element);
    }

    public int CountElements(T[] array)
    {
        return array.Length;
    }
    
    public int FindIndex (T[] array, T element)
    {
        return Array.IndexOf(array, element);
    }
}