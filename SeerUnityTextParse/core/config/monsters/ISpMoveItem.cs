using System;

namespace core.config.monsters
{
	public class ISpMoveItem
	{
		public int ID { get; set; }

		public int LearningLv { get; set; }

		public int Rec { get; set; }

		public int tag { get; set; }

		public int Tag { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			int num = byteIndex;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			ID = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			LearningLv = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			Rec = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 <= bytes.Length)
			{
				Tag = BitConverter.ToInt32(bytes, num);
				num += 4;
				if (num + 4 <= bytes.Length)
				{
					tag = BitConverter.ToInt32(bytes, num);
					num += 4;
					byteIndex = num;
				}
			}
		}
	}
}
