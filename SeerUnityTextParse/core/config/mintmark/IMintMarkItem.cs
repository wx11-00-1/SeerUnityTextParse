using System;
using System.Text;

namespace core.config.mintmark
{
	public class IMintMarkItem
	{
		public string Des { get; set; }

		public string EffectDes { get; set; }

		public int[] Arg { get; set; }

		public int[] BaseAttriValue { get; set; }

		public int[] ExtraAttriValue { get; set; }

		public int[] MaxAttriValue { get; set; }

		public int[] MonsterID { get; set; }

		public int[] MoveID { get; set; }

		public int Connect { get; set; }

		public int Grade { get; set; }

		public int Hide { get; set; }

		public int ID { get; set; }

		public int Level { get; set; }

		public int Max { get; set; }

		public int MintmarkClass { get; set; }

		public int Quality { get; set; }

		public int Rare { get; set; }

		public int Rarity { get; set; }

		public int TotalConsume { get; set; }

		public int Type { get; set; }

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
					Arg = new int[num2];
					Buffer.BlockCopy(bytes, num, Arg, 0, num2 * 4);
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
					BaseAttriValue = new int[num3];
					Buffer.BlockCopy(bytes, num, BaseAttriValue, 0, num3 * 4);
					num += num3 * 4;
				}
			}
			if (num + 4 > bytes.Length)
			{
				return;
			}
			Connect = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 2 > bytes.Length)
			{
				return;
			}
			ushort num4 = BitConverter.ToUInt16(bytes, num);
			num += 2;
			if (num4 > 0 && num + num4 <= bytes.Length)
			{
				Des = Encoding.UTF8.GetString(bytes, num, num4);
				num += num4;
			}
			else
			{
				Des = string.Empty;
			}
			if (num + 2 > bytes.Length)
			{
				return;
			}
			ushort num5 = BitConverter.ToUInt16(bytes, num);
			num += 2;
			if (num5 > 0 && num + num5 <= bytes.Length)
			{
				EffectDes = Encoding.UTF8.GetString(bytes, num, num5);
				num += num5;
			}
			else
			{
				EffectDes = string.Empty;
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
				int num6 = BitConverter.ToInt32(bytes, num);
				num += 4;
				if (num6 > 0 && num + num6 * 4 <= bytes.Length)
				{
					ExtraAttriValue = new int[num6];
					Buffer.BlockCopy(bytes, num, ExtraAttriValue, 0, num6 * 4);
					num += num6 * 4;
				}
			}
			if (num + 4 > bytes.Length)
			{
				return;
			}
			Grade = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			Hide = BitConverter.ToInt32(bytes, num);
			num += 4;
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
			Level = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			Max = BitConverter.ToInt32(bytes, num);
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
				int num7 = BitConverter.ToInt32(bytes, num);
				num += 4;
				if (num7 > 0 && num + num7 * 4 <= bytes.Length)
				{
					MaxAttriValue = new int[num7];
					Buffer.BlockCopy(bytes, num, MaxAttriValue, 0, num7 * 4);
					num += num7 * 4;
				}
			}
			if (num + 4 > bytes.Length)
			{
				return;
			}
			MintmarkClass = BitConverter.ToInt32(bytes, num);
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
				int num8 = BitConverter.ToInt32(bytes, num);
				num += 4;
				if (num8 > 0 && num + num8 * 4 <= bytes.Length)
				{
					MonsterID = new int[num8];
					Buffer.BlockCopy(bytes, num, MonsterID, 0, num8 * 4);
					num += num8 * 4;
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
				int num9 = BitConverter.ToInt32(bytes, num);
				num += 4;
				if (num9 > 0 && num + num9 * 4 <= bytes.Length)
				{
					MoveID = new int[num9];
					Buffer.BlockCopy(bytes, num, MoveID, 0, num9 * 4);
					num += num9 * 4;
				}
			}
			if (num + 4 > bytes.Length)
			{
				return;
			}
			Quality = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			Rare = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			Rarity = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 <= bytes.Length)
			{
				TotalConsume = BitConverter.ToInt32(bytes, num);
				num += 4;
				if (num + 4 <= bytes.Length)
				{
					Type = BitConverter.ToInt32(bytes, num);
					num += 4;
					byteIndex = num;
				}
			}
		}
	}
}
