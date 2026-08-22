using System;
using System.Text;

namespace core.config.moves
{
	public class IMoveItem
	{
		public string info { get; set; }

		public string Name { get; set; }

		public int[] FriendSideEffect { get; set; }

		public int[] FriendSideEffectArg { get; set; }

		public int[] SideEffect { get; set; }

		public int[] SideEffectArg { get; set; }

		public int Accuracy { get; set; }

		public int AtkNum { get; set; }

		public int AtkType { get; set; }

		public int Category { get; set; }

		public int CritRate { get; set; }

		public int ID { get; set; }

		public int MaxPP { get; set; }

		public int MonID { get; set; }

		public int MustHit { get; set; }

		public int ordinary { get; set; }

		public int Power { get; set; }

		public int Priority { get; set; }

		public int Type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			int num = byteIndex;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			Accuracy = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			AtkNum = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			AtkType = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			Category = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			CritRate = BitConverter.ToInt32(bytes, num);
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
					FriendSideEffect = new int[num2];
					Buffer.BlockCopy(bytes, num, FriendSideEffect, 0, num2 * 4);
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
					FriendSideEffectArg = new int[num3];
					Buffer.BlockCopy(bytes, num, FriendSideEffectArg, 0, num3 * 4);
					num += num3 * 4;
				}
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
			MaxPP = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			MonID = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			MustHit = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 2 > bytes.Length)
			{
				return;
			}
			ushort num4 = BitConverter.ToUInt16(bytes, num);
			num += 2;
			if (num4 > 0 && num + num4 <= bytes.Length)
			{
				Name = Encoding.UTF8.GetString(bytes, num, num4);
				num += num4;
			}
			else
			{
				Name = string.Empty;
			}
			if (num + 4 > bytes.Length)
			{
				return;
			}
			Power = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			Priority = BitConverter.ToInt32(bytes, num);
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
				int num5 = BitConverter.ToInt32(bytes, num);
				num += 4;
				if (num5 > 0 && num + num5 * 4 <= bytes.Length)
				{
					SideEffect = new int[num5];
					Buffer.BlockCopy(bytes, num, SideEffect, 0, num5 * 4);
					num += num5 * 4;
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
				int num6 = BitConverter.ToInt32(bytes, num);
				num += 4;
				if (num6 > 0 && num + num6 * 4 <= bytes.Length)
				{
					SideEffectArg = new int[num6];
					Buffer.BlockCopy(bytes, num, SideEffectArg, 0, num6 * 4);
					num += num6 * 4;
				}
			}
			if (num + 4 > bytes.Length)
			{
				return;
			}
			Type = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 2 <= bytes.Length)
			{
				ushort num7 = BitConverter.ToUInt16(bytes, num);
				num += 2;
				if (num7 > 0 && num + num7 <= bytes.Length)
				{
					info = Encoding.UTF8.GetString(bytes, num, num7);
					num += num7;
				}
				else
				{
					info = string.Empty;
				}
				if (num + 4 <= bytes.Length)
				{
					ordinary = BitConverter.ToInt32(bytes, num);
					num += 4;
					byteIndex = num;
				}
			}
		}
	}
}
