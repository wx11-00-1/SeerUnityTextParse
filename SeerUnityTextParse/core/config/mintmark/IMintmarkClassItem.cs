using System;
using System.Text;

namespace core.config.mintmark
{
	public class IMintmarkClassItem
	{
		public string ClassName { get; set; }

		public int ID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			int num = byteIndex;
			if (num + 2 <= bytes.Length)
			{
				ushort num2 = BitConverter.ToUInt16(bytes, num);
				num += 2;
				if (num2 > 0 && num + num2 <= bytes.Length)
				{
					ClassName = Encoding.UTF8.GetString(bytes, num, num2);
					num += num2;
				}
				else
				{
					ClassName = string.Empty;
				}
				if (num + 4 <= bytes.Length)
				{
					ID = BitConverter.ToInt32(bytes, num);
					num += 4;
					byteIndex = num;
				}
			}
		}
	}
}
