using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

public class ByteArray
{
    private const int BYTE_LEN = 1;

    private const int USHORT_LEN = 2;

    private const int SHORT_LEN = 2;

    private const int UINT_LEN = 4;

    private const int INT_LEN = 4;

    private const int ULONG_LEN = 8;

    private const int LONG_LEN = 8;

    private const int FLOAT_LEN = 4;

    private const int DOUBLE_LEN = 8;

    private int m_Position;

    private List<byte> m_ByteList;

    private int m_WritePosition;

    private byte[] m_UshortData = new byte[2];

    private byte[] m_ShortData = new byte[2];

    private byte[] m_UintData = new byte[4];

    private byte[] m_IntData = new byte[4];

    private byte[] m_UlongData = new byte[8];

    private byte[] m_LongData = new byte[8];

    private byte[] m_FloatData = new byte[4];

    private byte[] m_DoubleData = new byte[8];

    public bool locked;

    public bool littleEndian;

    private static Queue<ByteArray> _cache = new Queue<ByteArray>();

    public byte[] Bytes => m_ByteList.ToArray();

    public byte this[int index] => m_ByteList[index];

    public byte this[uint index] => m_ByteList[(int)index];

    public int Length
    {
        get
        {
            return m_WritePosition;
        }
        set
        {
            if (value > m_WritePosition)
            {
                for (int i = m_WritePosition; i < value; i++)
                {
                    m_ByteList.Add(0);
                }
                m_WritePosition = value;
            }
            else
            {
                m_ByteList.RemoveRange(value, m_WritePosition - value);
                m_WritePosition = value;
            }
        }
    }

    public int position
    {
        get
        {
            return m_Position;
        }
        set
        {
            m_Position = value;
            if (value > m_WritePosition)
            {
                for (int i = m_WritePosition; i < value; i++)
                {
                    m_ByteList.Add(0);
                }
                m_WritePosition = value;
            }
        }
    }

    public int bytesAvailable => m_WritePosition - position;

    public int Count => m_ByteList.Count;

    public ByteArray()
    {
        m_WritePosition = 0;
        m_Position = 0;
        m_ByteList = new List<byte>(0);
        littleEndian = BitConverter.IsLittleEndian;
    }

    public ByteArray(int capacity = 0)
    {
        m_WritePosition = 0;
        m_Position = 0;
        m_ByteList = new List<byte>(capacity);
        littleEndian = BitConverter.IsLittleEndian;
    }

    public ByteArray(bool littleEndian)
    {
        m_WritePosition = 0;
        m_Position = 0;
        m_ByteList = new List<byte>(0);
        this.littleEndian = littleEndian;
    }

    public void WriteBoolean(bool value)
    {
        m_WritePosition++;
        m_ByteList.Add(Convert.ToByte(value));
    }

    public void WriteUnsignedByte(byte value)
    {
        m_WritePosition++;
        m_ByteList.Add(Convert.ToByte(value));
    }

    public void WriteSignedByte(sbyte value)
    {
    }

    public void WriteUnsignedShort(ushort value)
    {
        m_WritePosition += 2;
        m_UshortData[1] = (byte)value;
        m_UshortData[0] = (byte)(value >> 8);
        m_ByteList.AddRange(m_UshortData);
    }

    public void WriteSignedShort(short value)
    {
        m_WritePosition += 2;
        m_ShortData[1] = (byte)value;
        m_ShortData[0] = (byte)(value >> 8);
        m_ByteList.AddRange(m_ShortData);
    }

    public void WriteUnsignedInt(uint value)
    {
        //m_WritePosition += 4;
        //ByteConverter.ToBytes(value, m_UintData, littleEndian);
        //m_ByteList.AddRange(m_UintData);
    }

    public void WriteSignedInt(int value)
    {
        //m_WritePosition += 4;
        //ByteConverter.ToBytes(value, m_IntData, littleEndian);
        //m_ByteList.AddRange(m_IntData);
    }

    public void WriteUnsignedLong(ulong value)
    {
        //m_WritePosition += 8;
        //ByteConverter.ToBytes(value, m_UlongData, littleEndian);
        //m_ByteList.AddRange(m_UlongData);
    }

    public void WriteLong(long value)
    {
        //m_WritePosition += 8;
        //ByteConverter.ToBytes(value, m_LongData, littleEndian);
        //m_ByteList.AddRange(m_LongData);
    }

    public void WriteFloat(float value)
    {
        //m_WritePosition += 4;
        //ByteConverter.ToBytes(value, m_FloatData, littleEndian);
        //m_ByteList.AddRange(m_FloatData);
    }

    public void WriteDouble(double value)
    {
        //m_WritePosition += 8;
        //ByteConverter.ToBytes(value, m_DoubleData, littleEndian);
        //m_ByteList.AddRange(m_DoubleData);
    }

    public void WriteUTFBytes(string value, int length = 0)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(value);
        WriteBytes(bytes, length);
    }

    public void WriteBytes(byte[] value, int length = 0)
    {
        if (value == null)
        {
            return;
        }
        if (length > 0)
        {
            m_WritePosition += length;
            int num = value.Length;
            if (length > num)
            {
                m_ByteList.AddRange(value);
                int i = 0;
                for (int num2 = length - num; i < num2; i++)
                {
                    m_ByteList.Add(0);
                }
            }
            else
            {
                for (int j = 0; j < length; j++)
                {
                    m_ByteList.Add(value[j]);
                }
            }
        }
        else
        {
            m_WritePosition += value.Length;
            m_ByteList.AddRange(value);
        }
    }

    public void WriteBytes(ByteArray value, int length = 0)
    {
        if (length > 0)
        {
            m_WritePosition += length;
            int writePosition = value.m_WritePosition;
            if (length > writePosition)
            {
                m_ByteList.AddRange(value.m_ByteList);
                int i = 0;
                for (int num = length - writePosition; i < num; i++)
                {
                    m_ByteList.Add(0);
                }
            }
            else
            {
                for (int j = 0; j < length; j++)
                {
                    m_ByteList.Add(value.m_ByteList[j]);
                }
                value.m_Position += length;
            }
        }
        else
        {
            m_WritePosition += value.m_WritePosition;
            m_ByteList.AddRange(value.m_ByteList);
        }
    }

    public bool ReadBoolean()
    {
        if (validate(1))
        {
            return Convert.ToBoolean(m_ByteList[position++]);
        }
        return false;
    }

    public byte ReadUnsignedByte()
    {
        if (!validate(1))
        {
            return 0;
        }
        return Convert.ToByte(m_ByteList[position++]);
    }

    public ushort ReadUnsignedShort()
    {
        //if (!validate(2))
        //{
        //    return 0;
        //}
        //for (int i = 0; i < 2; i++)
        //{
        //    m_UshortData[i] = m_ByteList[m_Position + i];
        //}
        position += 2;
        //return ByteConverter.ToUShort(m_UshortData);
        return 0;
    }

    public short ReadSignedShort()
    {
        if (!validate(2))
        {
            return 0;
        }
        for (int i = 0; i < 2; i++)
        {
            m_ShortData[i] = m_ByteList[m_Position + i];
        }
        position += 2;
        //return ByteConverter.ToShort(m_ShortData);
        return 0;
    }

    public uint ReadUnsignedInt()
    {
        if (!validate(4))
        {
            return 0u;
        }
        for (int i = 0; i < 4; i++)
        {
            m_UintData[i] = m_ByteList[m_Position + i];
        }
        position += 4;
        //return ByteConverter.ToUInt(m_UintData, littleEndian);
        return 0;
    }

    public string ReadUTFBytes(int length)
    {
        if (!validate(length))
        {
            return null;
        }
        byte[] bytes = m_ByteList.GetRange(position, length).ToArray();
        position += length;
        return Encoding.UTF8.GetString(bytes);
    }

    public int ReadSignedInt()
    {
        if (!validate(4))
        {
            return 0;
        }
        for (int i = 0; i < 4; i++)
        {
            m_IntData[i] = m_ByteList[m_Position + i];
        }
        position += 4;
        //return ByteConverter.ToInt(m_IntData, littleEndian);
        return 0;
    }

    public ulong ReadUnsignedLong()
    {
        if (!validate(8))
        {
            return 0uL;
        }
        for (int i = 0; i < 8; i++)
        {
            m_UlongData[i] = m_ByteList[m_Position + i];
        }
        position += 8;
        //return ByteConverter.ToULong(m_UlongData, littleEndian);
        return 0;
    }

    public long ReadSignedLong()
    {
        if (!validate(8))
        {
            return 0L;
        }
        for (int i = 0; i < 8; i++)
        {
            m_LongData[i] = m_ByteList[m_Position + i];
        }
        position += 8;
        //return ByteConverter.ToLong(m_LongData, littleEndian);
        return 0;
    }

    public float ReadFloat()
    {
        if (!validate(4))
        {
            return 0f;
        }
        for (int i = 0; i < 4; i++)
        {
            m_FloatData[i] = m_ByteList[m_Position + i];
        }
        position += 4;
        //return ByteConverter.ToFloat(m_FloatData, littleEndian);
        return 0;
    }

    public double ReadDouble()
    {
        if (!validate(8))
        {
            return 0.0;
        }
        for (int i = 0; i < 8; i++)
        {
            m_DoubleData[i] = m_ByteList[m_Position + i];
        }
        position += 8;
        //return ByteConverter.ToDouble(m_DoubleData, littleEndian);
        return 0;
    }

    public string ReadUTFByte(int length)
    {
        if (!validate(length))
        {
            return string.Empty;
        }
        byte[] array = new byte[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = m_ByteList[m_Position + i];
        }
        int num = Array.IndexOf(array, (byte)0, 0, length);
        int num2 = ((num >= 0) ? (length - num) : 0);
        position += length;
        return Encoding.UTF8.GetString(array, 0, length - num2);
    }

    public byte[] ReadBytes(int length = 0)
    {
        if (!validate(length))
        {
            return new byte[0];
        }
        if (length == 0)
        {
            length = m_WritePosition - m_Position;
        }
        byte[] array = new byte[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = m_ByteList[m_Position + i];
        }
        position += length;
        return array;
    }

    public void ReadBytes(ByteArray value, int length = 0)
    {
        if (value != null)
        {
            int num = m_WritePosition - m_Position;
            if (length <= num)
            {
                byte[] array = ReadBytes(length);
                value.m_ByteList.AddRange(array);
                value.m_WritePosition += array.Length;
            }
        }
    }

    protected bool validate(int len)
    {
        int count = m_ByteList.Count;
        if (count > 0 && m_Position + len <= count)
        {
            return true;
        }
        return false;
    }

    public void Clear()
    {
        m_Position = 0;
        m_WritePosition = 0;
        m_ByteList.Clear();
    }

    public static ByteArray Get(int capacity = 0)
    {
        if (_cache.Count > 0)
        {
            return _cache.Dequeue();
        }
        return new ByteArray(capacity);
    }

    public static void Cache(ByteArray byteArr)
    {
        byteArr.Clear();
        _cache.Enqueue(byteArr);
    }
}
