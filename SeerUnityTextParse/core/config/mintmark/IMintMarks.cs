using System;

namespace core.config.mintmark
{
	public class IMintMarks
	{
		public IMintMarkItem[] MintMark { get; set; }

		public IMintmarkClassItem[] MintmarkClass { get; set; }

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
					MintMark = new IMintMarkItem[num];
					for (int i = 0; i < num; i++)
					{
						MintMark[i] = new IMintMarkItem();
						MintMark[i].Parse(bytes, ref byteIndex2);
					}
				}
			}
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
				int num2 = BitConverter.ToInt32(bytes, byteIndex2);
				byteIndex2 += 4;
				if (num2 > 0)
				{
					MintmarkClass = new IMintmarkClassItem[num2];
					for (int j = 0; j < num2; j++)
					{
						MintmarkClass[j] = new IMintmarkClassItem();
						MintmarkClass[j].Parse(bytes, ref byteIndex2);
					}
				}
			}
			byteIndex = byteIndex2;
		}
	}
}
