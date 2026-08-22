using System;
using System.Text;

namespace core.config.new_super_design
{
	public class INormalBattle
	{
		public string Desc { get; set; }

		public string RuleID { get; set; }

		public ITaskItem[] Task { get; set; }

		public int BattleCnt { get; set; }

		public int Out { get; set; }

		public int TaskStyle { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			int num = byteIndex;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			BattleCnt = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 2 > bytes.Length)
			{
				return;
			}
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
			if (num + 4 > bytes.Length)
			{
				return;
			}
			Out = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 2 > bytes.Length)
			{
				return;
			}
			ushort num3 = BitConverter.ToUInt16(bytes, num);
			num += 2;
			if (num3 > 0 && num + num3 <= bytes.Length)
			{
				RuleID = Encoding.UTF8.GetString(bytes, num, num3);
				num += num3;
			}
			else
			{
				RuleID = string.Empty;
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
				int num4 = BitConverter.ToInt32(bytes, num);
				num += 4;
				if (num4 > 0)
				{
					Task = new ITaskItem[num4];
					for (int i = 0; i < num4; i++)
					{
						Task[i] = new ITaskItem();
						Task[i].Parse(bytes, ref num);
					}
				}
			}
			if (num + 4 <= bytes.Length)
			{
				TaskStyle = BitConverter.ToInt32(bytes, num);
				num += 4;
				byteIndex = num;
			}
		}
	}
}
