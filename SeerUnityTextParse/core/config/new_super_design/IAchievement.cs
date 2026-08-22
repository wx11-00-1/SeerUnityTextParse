using System;

namespace core.config.new_super_design
{
	public class IAchievement
	{
		public int BranchID { get; set; }

		public int RuleID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			int num = byteIndex;
			if (num + 4 <= bytes.Length)
			{
				BranchID = BitConverter.ToInt32(bytes, num);
				num += 4;
				if (num + 4 <= bytes.Length)
				{
					RuleID = BitConverter.ToInt32(bytes, num);
					num += 4;
					byteIndex = num;
				}
			}
		}
	}
}
