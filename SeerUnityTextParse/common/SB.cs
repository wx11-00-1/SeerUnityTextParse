using System.Text;
using System.Threading;
using common;

public class SB
{
    private static SB instance;

    private StringBuilder sb;

    private static Thread singletonThread;

    private static SB Small => Create(64);

    private static SB Meduim => Create(256);

    private static SB Large => Create(1024);

    public static SB Empty
    {
        get
        {
            if (singletonThread == null)
            {
                singletonThread = Thread.CurrentThread;
            }
            if (singletonThread != Thread.CurrentThread)
            {
                return Small;
            }
            instance.sb.Length = 0;
            return instance;
        }
    }

    static SB()
    {
        instance = Large;
    }

    public override string ToString()
    {
        if (sb == null)
        {
            return string.Empty;
        }
        return sb.ToString();
    }

    private static SB Create(int capacity)
    {
        return new SB(capacity);
    }

    private SB(int capacity)
    {
        sb = new StringBuilder(capacity);
    }

    public static implicit operator string(SB t)
    {
        return t.sb.ToString();
    }

    public static SB operator +(SB t, int n)
    {
        t.sb.Append(n);
        return t;
    }

    public static SB operator +(SB t, string str)
    {
        t.sb.Append(str);
        return t;
    }

    public static SB operator +(SB t, StringBuilder sb)
    {
        t.sb.Append(sb);
        return t;
    }
}
