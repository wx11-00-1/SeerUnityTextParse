using System.Collections.Generic;

public class ByteArrayPool
{
    private static List<ByteArray> byteArrays = new List<ByteArray>();

    private static readonly object _lock = new object();

    public static ByteArray GetByteArray(int capacity = 0)
    {
        lock (_lock)
        {
            ByteArray byteArray = null;
            if (byteArrays.Count > 0)
            {
                int num = byteArrays.Count - 1;
                if (num >= 0)
                {
                    byteArray = byteArrays[num];
                    byteArrays.RemoveAt(num);
                }
            }
            if (byteArray == null)
            {
                byteArray = new ByteArray(capacity);
            }
            return byteArray;
        }
    }

    public static bool release(ByteArray tmp)
    {
        if (byteArrays.Contains(tmp))
        {
            return false;
        }
        if (tmp == null || tmp.locked)
        {
            return false;
        }
        tmp.Clear();
        byteArrays.Add(tmp);
        return true;
    }
}