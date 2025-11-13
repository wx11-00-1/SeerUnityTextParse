using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

// Token: 0x02000031 RID: 49
public class HashHelper
{
    // Token: 0x060001EF RID: 495 RVA: 0x0000A274 File Offset: 0x00008474
    public static byte[] Byte(object value)
    {
        byte[] result;
        using (MemoryStream memoryStream = new MemoryStream())
        {
            //new BinaryFormatter().Serialize(memoryStream, (value == null) ? "null" : value);
            JsonSerializer.Serialize(memoryStream, (value == null) ? "null" : value);
            result = memoryStream.ToArray();
        }
        return result;
    }

    // Token: 0x060001F0 RID: 496 RVA: 0x0000A2C4 File Offset: 0x000084C4
    public static byte[] Hash(byte[] value)
    {
        return MD5.Create().ComputeHash(value);
    }

    // Token: 0x060001F1 RID: 497 RVA: 0x0000A2D4 File Offset: 0x000084D4
    public static byte[] Combine(params byte[][] values)
    {
        byte[] array = new byte[values.Sum((byte[] a) => a.Length)];
        int num = 0;
        foreach (byte[] array2 in values)
        {
            Buffer.BlockCopy(array2, 0, array, num, array2.Length);
            num += array2.Length;
        }
        return array;
    }

    // Token: 0x060001F2 RID: 498 RVA: 0x0000A33C File Offset: 0x0000853C
    public static string String(byte[] hash)
    {
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < hash.Length; i++)
        {
            stringBuilder.Append(hash[i].ToString("x2"));
        }
        return stringBuilder.ToString();
    }

    // Token: 0x060001F3 RID: 499 RVA: 0x0000A37C File Offset: 0x0000857C
    public static byte[] Hash(params object[] values)
    {
        byte[][] array = new byte[values.Length][];
        for (int i = 0; i < values.Length; i++)
        {
            array[i] = HashHelper.Byte(values[i]);
        }
        return HashHelper.Hash(HashHelper.Combine(array));
    }

    // Token: 0x060001F4 RID: 500 RVA: 0x0000A3B6 File Offset: 0x000085B6
    public static string HashString(string value, Encoding encoding = null)
    {
        if (encoding == null)
        {
            encoding = Encoding.ASCII;
        }
        return HashHelper.String(HashHelper.Hash(encoding.GetBytes(value)));
    }

    // Token: 0x060001F5 RID: 501 RVA: 0x0000A3D3 File Offset: 0x000085D3
    public static string HashString(params object[] values)
    {
        return HashHelper.String(HashHelper.Hash(values));
    }
}
