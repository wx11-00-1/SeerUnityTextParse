using System;
using System.Text;

namespace core.config.product_diamond
{
	public class IItemItem
	{
        public string name { get; set; }

        public int[] itemID { get; set; }

        public int price { get; set; }

        public int productID { get; set; }

        public float vip { get; set; }

        public void Parse(byte[] bytes, ref int byteIndex)
        {
            int num = byteIndex;
            if (num >= bytes.Length)
            {
                return;
            }
            if (bytes[num++] != 0)
            {
                if (num + 4 > bytes.Length)
                {
                    return;
                }
                int num2 = BitConverter.ToInt32(bytes, num);
                num += 4;
                if (num2 > 0 && num + num2 * 4 <= bytes.Length)
                {
                    itemID = new int[num2];
                    Buffer.BlockCopy(bytes, num, itemID, 0, num2 * 4);
                    num += num2 * 4;
                }
            }
            if (num + 2 > bytes.Length)
            {
                return;
            }
            ushort num3 = BitConverter.ToUInt16(bytes, num);
            num += 2;
            if (num3 > 0 && num + num3 <= bytes.Length)
            {
                name = Encoding.UTF8.GetString(bytes, num, num3);
                num += num3;
            }
            else
            {
                name = string.Empty;
            }
            if (num + 4 > bytes.Length)
            {
                return;
            }
            price = BitConverter.ToInt32(bytes, num);
            num += 4;
            if (num + 4 <= bytes.Length)
            {
                productID = BitConverter.ToInt32(bytes, num);
                num += 4;
                if (num + 4 <= bytes.Length)
                {
                    vip = BitConverter.ToSingle(bytes, num);
                    num += 4;
                    byteIndex = num;
                }
            }
        }
    }
}
