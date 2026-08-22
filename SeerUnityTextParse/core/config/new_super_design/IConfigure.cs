using System;

namespace core.config.new_super_design
{
	public class IConfigure
	{
		public int[] ExchangeID { get; set; }

		public int[] ExchangeProductID { get; set; }

		public int Exchange_mintmark { get; set; }

		public int FailTimes { get; set; }

		public int needmon { get; set; }

		public int ProgressValue { get; set; }

		public int Times { get; set; }

		public int TimeValue { get; set; }

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
					ExchangeID = new int[num2];
					Buffer.BlockCopy(bytes, num, ExchangeID, 0, num2 * 4);
					num += num2 * 4;
				}
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
				if (num3 > 0 && num + num3 * 4 <= bytes.Length)
				{
					ExchangeProductID = new int[num3];
					Buffer.BlockCopy(bytes, num, ExchangeProductID, 0, num3 * 4);
					num += num3 * 4;
				}
			}
			if (num + 4 > bytes.Length)
			{
				return;
			}
			Exchange_mintmark = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			FailTimes = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			ProgressValue = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			TimeValue = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 <= bytes.Length)
			{
				Times = BitConverter.ToInt32(bytes, num);
				num += 4;
				if (num + 4 <= bytes.Length)
				{
					needmon = BitConverter.ToInt32(bytes, num);
					num += 4;
					byteIndex = num;
				}
			}
		}
	}
}
