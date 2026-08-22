using System;
using System.Text;

namespace core.config.moves
{
	public class IMoves
	{
		public string _text { get; set; }

		public IMoveItem[] Move { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			int byteIndex2 = byteIndex;
			if (byteIndex2 >= bytes.Length)
			{
				return;
			}
			if (bytes[byteIndex2++] != 0)
			{
				if (byteIndex2 + 4 > bytes.Length)
				{
					return;
				}
				int num = BitConverter.ToInt32(bytes, byteIndex2);
				byteIndex2 += 4;
				if (num > 0)
				{
					Move = new IMoveItem[num];
					for (int i = 0; i < num; i++)
					{
						Move[i] = new IMoveItem();
						Move[i].Parse(bytes, ref byteIndex2);
					}
				}
			}
			if (byteIndex2 + 2 <= bytes.Length)
			{
				ushort num2 = BitConverter.ToUInt16(bytes, byteIndex2);
				byteIndex2 += 2;
				if (num2 > 0 && byteIndex2 + num2 <= bytes.Length)
				{
					_text = Encoding.UTF8.GetString(bytes, byteIndex2, num2);
					byteIndex2 += num2;
				}
				else
				{
					_text = string.Empty;
				}
				byteIndex = byteIndex2;
			}
		}
	}
}
