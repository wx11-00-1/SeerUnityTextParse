using System;
using System.Text;

namespace core.config.petbook
{
	public class IMonsterItem
	{
		public string DefName { get; set; }

		public string Features { get; set; }

		public string Target { get; set; }

		public int ID { get; set; }

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
				DefName = Encoding.UTF8.GetString(bytes, num, num2);
				num += num2;
			}
			else
			{
				DefName = string.Empty;
			}
			if (num + 2 > bytes.Length)
			{
				return;
			}
			ushort num3 = BitConverter.ToUInt16(bytes, num);
			num += 2;
			if (num3 > 0 && num + num3 <= bytes.Length)
			{
				Features = Encoding.UTF8.GetString(bytes, num, num3);
				num += num3;
			}
			else
			{
				Features = string.Empty;
			}
			if (num + 4 > bytes.Length)
			{
				return;
			}
			ID = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 2 <= bytes.Length)
			{
				ushort num4 = BitConverter.ToUInt16(bytes, num);
				num += 2;
				if (num4 > 0 && num + num4 <= bytes.Length)
				{
					Target = Encoding.UTF8.GetString(bytes, num, num4);
					num += num4;
				}
				else
				{
					Target = string.Empty;
				}
				byteIndex = num;
			}
		}
	}
}
