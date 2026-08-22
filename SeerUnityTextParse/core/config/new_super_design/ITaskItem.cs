using System;
using System.Text;

namespace core.config.new_super_design
{
	public class ITaskItem
	{
		public string Desc { get; set; }

		public int BattleBoss { get; set; }

		public int Battlelevel { get; set; }

		public int BattleType { get; set; }

		public int ID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			int num = byteIndex;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			BattleBoss = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			BattleType = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			Battlelevel = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 2 <= bytes.Length)
			{
				ushort num2 = BitConverter.ToUInt16(bytes, num);
				num += 2;
				if (num2 > 0 && num + num2 <= bytes.Length)
				{
					Desc = Encoding.UTF8.GetString(bytes, num, num2);
					num += num2;
				}
				else
				{
					Desc = string.Empty;
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
