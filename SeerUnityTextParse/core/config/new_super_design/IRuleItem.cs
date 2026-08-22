using System;
using System.Text;

namespace core.config.new_super_design
{
	public class IRuleItem
	{
		public string Args { get; set; }

		public string CheckTips { get; set; }

		public string FailTips { get; set; }

		public string RepeatTips { get; set; }

		public string UserInfo { get; set; }

		public int ID { get; set; }

		public int MouldID { get; set; }

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
				Args = Encoding.UTF8.GetString(bytes, num, num2);
				num += num2;
			}
			else
			{
				Args = string.Empty;
			}
			if (num + 2 > bytes.Length)
			{
				return;
			}
			ushort num3 = BitConverter.ToUInt16(bytes, num);
			num += 2;
			if (num3 > 0 && num + num3 <= bytes.Length)
			{
				CheckTips = Encoding.UTF8.GetString(bytes, num, num3);
				num += num3;
			}
			else
			{
				CheckTips = string.Empty;
			}
			if (num + 2 > bytes.Length)
			{
				return;
			}
			ushort num4 = BitConverter.ToUInt16(bytes, num);
			num += 2;
			if (num4 > 0 && num + num4 <= bytes.Length)
			{
				FailTips = Encoding.UTF8.GetString(bytes, num, num4);
				num += num4;
			}
			else
			{
				FailTips = string.Empty;
			}
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
			MouldID = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 2 > bytes.Length)
			{
				return;
			}
			ushort num5 = BitConverter.ToUInt16(bytes, num);
			num += 2;
			if (num5 > 0 && num + num5 <= bytes.Length)
			{
				RepeatTips = Encoding.UTF8.GetString(bytes, num, num5);
				num += num5;
			}
			else
			{
				RepeatTips = string.Empty;
			}
			if (num + 2 <= bytes.Length)
			{
				ushort num6 = BitConverter.ToUInt16(bytes, num);
				num += 2;
				if (num6 > 0 && num + num6 <= bytes.Length)
				{
					UserInfo = Encoding.UTF8.GetString(bytes, num, num6);
					num += num6;
				}
				else
				{
					UserInfo = string.Empty;
				}
				byteIndex = num;
			}
		}
	}
}
