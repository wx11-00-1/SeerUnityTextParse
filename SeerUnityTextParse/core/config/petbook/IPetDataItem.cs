using System;

namespace core.config.petbook
{
	public class IPetDataItem : IConfigItem
	{
		public int[] TagB { get; set; }

		public int id { get; set; }

		public int pid { get; set; }

		public int TagA { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			int num = byteIndex;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			TagA = BitConverter.ToInt32(bytes, num);
			num += 4;
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
					TagB = new int[num2];
					Buffer.BlockCopy(bytes, num, TagB, 0, num2 * 4);
					num += num2 * 4;
				}
			}
			if (num + 4 <= bytes.Length)
			{
				id = BitConverter.ToInt32(bytes, num);
				num += 4;
				if (num + 4 <= bytes.Length)
				{
					pid = BitConverter.ToInt32(bytes, num);
					num += 4;
					byteIndex = num;
				}
			}
		}
	}
}
