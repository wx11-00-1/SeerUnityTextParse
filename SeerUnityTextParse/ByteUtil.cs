using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;

// Token: 0x0200002E RID: 46
public static class ByteUtil
{
    // Token: 0x060001C8 RID: 456 RVA: 0x00009A54 File Offset: 0x00007C54
    public static bool[] ToBitArray(uint value, int length)
    {
        bool[] array = new bool[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = ((value & 1U) == 1U);
            value >>= 1;
        }
        return array;
    }

    // Token: 0x060001C9 RID: 457 RVA: 0x00009A83 File Offset: 0x00007C83
    public static byte ReadUnsignedByte(byte[] bytes, ref int startIndex)
    {
        byte result = bytes[startIndex];
        startIndex++;
        return result;
    }

    // Token: 0x060001CA RID: 458 RVA: 0x00009A90 File Offset: 0x00007C90
    public static sbyte ReadSignedByte(byte[] bytes, ref int startIndex)
    {
        byte b = bytes[startIndex];
        sbyte result;
        if (b > 127)
        {
            result = (sbyte)((int)b - 256);
        }
        else
        {
            result = (sbyte)b;
        }
        startIndex++;
        return result;
    }

    // Token: 0x060001CB RID: 459 RVA: 0x00009ABC File Offset: 0x00007CBC
    public static bool ReadBoolean(byte[] bytes, ref int startIndex)
    {
        byte value = bytes[startIndex];
        startIndex++;
        return Convert.ToBoolean(value);
    }

    // Token: 0x060001CC RID: 460 RVA: 0x00009AD0 File Offset: 0x00007CD0
    public static short ReadSignedShort(byte[] bytes, ref int startIndex)
    {
        object obj = ByteUtil.s_ShortObj;
        short result;
        lock (obj)
        {
            for (int i = 0; i < 2; i++)
            {
                ByteUtil.s_ShortBytes[i] = bytes[startIndex + i];
            }
            startIndex += 2;
            result = BitConverter.ToInt16(ByteUtil.s_ShortBytes, 0);
        }
        return result;
    }

    // Token: 0x060001CD RID: 461 RVA: 0x00009B38 File Offset: 0x00007D38
    public static ushort ReadUnsignedShort(byte[] bytes, ref int startIndex)
    {
        object obj = ByteUtil.s_ShortObj;
        ushort result;
        lock (obj)
        {
            for (int i = 0; i < 2; i++)
            {
                ByteUtil.s_ShortBytes[i] = bytes[startIndex + i];
            }
            startIndex += 2;
            result = BitConverter.ToUInt16(ByteUtil.s_ShortBytes, 0);
        }
        return result;
    }

    // Token: 0x060001CE RID: 462 RVA: 0x00009BA0 File Offset: 0x00007DA0
    public static int ReadSignedInt(byte[] bytes, ref int startIndex)
    {
        object obj = ByteUtil.s_IntObj;
        int result;
        lock (obj)
        {
            for (int i = 0; i < 4; i++)
            {
                ByteUtil.s_IntBytes[i] = bytes[startIndex + i];
            }
            startIndex += 4;
            result = BitConverter.ToInt32(ByteUtil.s_IntBytes, 0);
        }
        return result;
    }

    // Token: 0x060001CF RID: 463 RVA: 0x00009C08 File Offset: 0x00007E08
    public static uint ReadUnsignedInt(byte[] bytes, ref int startIndex)
    {
        object obj = ByteUtil.s_IntObj;
        uint result;
        lock (obj)
        {
            for (int i = 0; i < 4; i++)
            {
                ByteUtil.s_IntBytes[i] = bytes[startIndex + i];
            }
            startIndex += 4;
            result = BitConverter.ToUInt32(ByteUtil.s_IntBytes, 0);
        }
        return result;
    }

    // Token: 0x060001D0 RID: 464 RVA: 0x00009C70 File Offset: 0x00007E70
    public static long ReadLong(byte[] bytes, ref int startIndex)
    {
        object obj = ByteUtil.s_LongObj;
        long result;
        lock (obj)
        {
            for (int i = 0; i < 8; i++)
            {
                ByteUtil.s_LongBytes[i] = bytes[startIndex + i];
            }
            startIndex += 8;
            result = BitConverter.ToInt64(ByteUtil.s_LongBytes, 0);
        }
        return result;
    }

    // Token: 0x060001D1 RID: 465 RVA: 0x00009CD8 File Offset: 0x00007ED8
    public static ulong ReadUlong(byte[] bytes, ref int startIndex)
    {
        object obj = ByteUtil.s_LongObj;
        ulong result;
        lock (obj)
        {
            for (int i = 0; i < 8; i++)
            {
                ByteUtil.s_LongBytes[i] = bytes[startIndex + i];
            }
            startIndex += 8;
            result = BitConverter.ToUInt64(ByteUtil.s_LongBytes, 0);
        }
        return result;
    }

    // Token: 0x060001D2 RID: 466 RVA: 0x00009D40 File Offset: 0x00007F40
    public static float ReadFloat(byte[] bytes, ref int startIndex)
    {
        object obj = ByteUtil.s_FloatObj;
        float result;
        lock (obj)
        {
            for (int i = 0; i < 4; i++)
            {
                ByteUtil.s_FloatBytes[i] = bytes[startIndex + i];
            }
            startIndex += 4;
            result = BitConverter.ToSingle(ByteUtil.s_FloatBytes, 0);
        }
        return result;
    }

    // Token: 0x060001D3 RID: 467 RVA: 0x00009DA8 File Offset: 0x00007FA8
    public static double ReadDouble(byte[] bytes, ref int startIndex)
    {
        object obj = ByteUtil.s_DoubleObj;
        double result;
        lock (obj)
        {
            for (int i = 0; i < 8; i++)
            {
                ByteUtil.s_DoubleBytes[i] = bytes[startIndex + i];
            }
            startIndex += 8;
            result = BitConverter.ToDouble(ByteUtil.s_DoubleBytes, 0);
        }
        return result;
    }

    // Token: 0x060001D4 RID: 468 RVA: 0x00009E10 File Offset: 0x00008010
    public static string ReadUTFByte(byte[] bytes, int length, ref int startIndex)
    {
        startIndex += length;
        return Encoding.UTF8.GetString(bytes, startIndex - length, length);
    }

    // Token: 0x060001D5 RID: 469 RVA: 0x00009E28 File Offset: 0x00008028
    public static object ToObject(this byte[] bs)
    {
        object result = new object();
        using (MemoryStream memoryStream = new MemoryStream(bs))
        {
            //result = new BinaryFormatter().Deserialize(memoryStream);
            result = JsonSerializer.Deserialize<object>(memoryStream);
        }
        return result;
    }

    // Token: 0x060001D6 RID: 470 RVA: 0x00009E6C File Offset: 0x0000806C
    public static byte[] GetBytesWithHashOffset(this byte[] bs, string hash)
    {
        int num = HashHelper.Hash(new object[]
        {
            hash
        }).Length;
        byte[] array = new byte[bs.Length - num];
        Array.Copy(bs, num, array, 0, array.Length);
        return array;
    }

    // Token: 0x060001D7 RID: 471 RVA: 0x00009EA4 File Offset: 0x000080A4
    public static byte[] OverWriteBytes(this byte[] bs, string hash)
    {
        byte[] array = HashHelper.Hash(new object[]
        {
            hash
        });
        byte[] array2 = new byte[array.Length + bs.Length];
        Array.Copy(array, array2, array.Length);
        Array.Copy(bs, 0, array2, array.Length, bs.Length);
        return array2;
    }

    // Token: 0x040000CA RID: 202
    public const int BYTE_LEN = 1;

    // Token: 0x040000CB RID: 203
    public const int SHORT_LEN = 2;

    // Token: 0x040000CC RID: 204
    public const int INT_LEN = 4;

    // Token: 0x040000CD RID: 205
    public const int LONG_LEN = 8;

    // Token: 0x040000CE RID: 206
    public const int FLOAT_LEN = 4;

    // Token: 0x040000CF RID: 207
    public const int DOUBLE_LEN = 8;

    // Token: 0x040000D0 RID: 208
    private static byte[] s_IntBytes = new byte[4];

    // Token: 0x040000D1 RID: 209
    private static byte[] s_ShortBytes = new byte[2];

    // Token: 0x040000D2 RID: 210
    private static byte[] s_LongBytes = new byte[8];

    // Token: 0x040000D3 RID: 211
    private static byte[] s_FloatBytes = new byte[4];

    // Token: 0x040000D4 RID: 212
    private static byte[] s_DoubleBytes = new byte[8];

    // Token: 0x040000D5 RID: 213
    private static object s_IntObj = new object();

    // Token: 0x040000D6 RID: 214
    private static object s_ShortObj = new object();

    // Token: 0x040000D7 RID: 215
    private static object s_LongObj = new object();

    // Token: 0x040000D8 RID: 216
    private static object s_FloatObj = new object();

    // Token: 0x040000D9 RID: 217
    private static object s_DoubleObj = new object();
}
