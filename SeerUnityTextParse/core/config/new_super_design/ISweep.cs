using System;

namespace core.config.new_super_design
{
	public class ISweep
	{
		public int[] ProductID { get; set; }

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
					ProductID = new int[num2];
					Buffer.BlockCopy(bytes, num, ProductID, 0, num2 * 4);
					num += num2 * 4;
				}
			}
			byteIndex = num;
		}
	}
}
