using System;

namespace core.config.new_super_design
{
	public class IRules
	{
		public IRuleItem[] Rule { get; set; }

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
					Rule = new IRuleItem[num];
					for (int i = 0; i < num; i++)
					{
						Rule[i] = new IRuleItem();
						Rule[i].Parse(bytes, ref byteIndex2);
					}
				}
			}
			byteIndex = byteIndex2;
		}
	}
}
