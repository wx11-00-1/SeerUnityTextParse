using System;
using System.Text;

namespace core.config.petbook
{
	public class IItem
	{
		public string intro { get; set; }

		public IPlaceItem[] place { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			int num = byteIndex;
			if (num + 2 > bytes.Length)
			{
				return;
			}
			ushort num2 = BitConverter.ToUInt16(bytes, num);
			num += 2;
			if (num2 > 0 && num + num2 <= bytes.Length)
			{
				intro = Encoding.UTF8.GetString(bytes, num, num2);
				num += num2;
			}
			else
			{
				intro = string.Empty;
			}
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
				int num3 = BitConverter.ToInt32(bytes, num);
				num += 4;
				if (num3 > 0)
				{
					place = new IPlaceItem[num3];
					for (int i = 0; i < num3; i++)
					{
						place[i] = new IPlaceItem();
						place[i].Parse(bytes, ref num);
					}
				}
			}
			byteIndex = num;
		}
	}
}
