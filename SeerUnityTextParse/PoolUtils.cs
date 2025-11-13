using System.Collections.Generic;

public class PoolUtils<T> where T : new()
{
    private static PoolUtils<T> s_Shared;

    private static Stack<T> s_Pool = new Stack<T>(6);

    public static PoolUtils<T> Shared
    {
        get
        {
            if (s_Shared == null)
            {
                s_Shared = new PoolUtils<T>();
            }
            return s_Shared;
        }
    }

    public T Rent()
    {
        if (s_Pool.Count > 0)
        {
            return s_Pool.Pop();
        }
        return new T();
    }

    public void Return(T instance)
    {
        if (!s_Pool.Contains(instance))
        {
            s_Pool.Push(instance);
        }
    }

    public void ConsoleCount()
    {
    }
}
