using System;

namespace core.config.new_super_design
{
	public class IReward
	{
		public int GainValue { get; set; }

		public int ItemID { get; set; }

		public int MintMarkID { get; set; }

		public int MonsterID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			int num = byteIndex;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			GainValue = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			ItemID = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 <= bytes.Length)
			{
				MintMarkID = BitConverter.ToInt32(bytes, num);
				num += 4;
				if (num + 4 <= bytes.Length)
				{
					MonsterID = BitConverter.ToInt32(bytes, num);
					num += 4;
					byteIndex = num;
				}
			}
		}
	}
}
