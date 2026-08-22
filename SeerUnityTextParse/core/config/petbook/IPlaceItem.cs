using System;
using System.Text;

namespace core.config.petbook
{
	public class IPlaceItem
	{
		public string Desc { get; set; }

		public string Go { get; set; }

		public string Redirect { get; set; }

		public int[] Mintmark { get; set; }

		public int ID { get; set; }

		public int ImageID { get; set; }

		public int Label { get; set; }

		public int monID { get; set; }

		public int type { get; set; }

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
				Desc = Encoding.UTF8.GetString(bytes, num, num2);
				num += num2;
			}
			else
			{
				Desc = string.Empty;
			}
			if (num + 2 > bytes.Length)
			{
				return;
			}
			ushort num3 = BitConverter.ToUInt16(bytes, num);
			num += 2;
			if (num3 > 0 && num + num3 <= bytes.Length)
			{
				Go = Encoding.UTF8.GetString(bytes, num, num3);
				num += num3;
			}
			else
			{
				Go = string.Empty;
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
			ImageID = BitConverter.ToInt32(bytes, num);
			num += 4;
			if (num + 4 > bytes.Length)
			{
				return;
			}
			Label = BitConverter.ToInt32(bytes, num);
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
				int num4 = BitConverter.ToInt32(bytes, num);
				num += 4;
				if (num4 > 0 && num + num4 * 4 <= bytes.Length)
				{
					Mintmark = new int[num4];
					Buffer.BlockCopy(bytes, num, Mintmark, 0, num4 * 4);
					num += num4 * 4;
				}
			}
			if (num + 2 > bytes.Length)
			{
				return;
			}
			ushort num5 = BitConverter.ToUInt16(bytes, num);
			num += 2;
			if (num5 > 0 && num + num5 <= bytes.Length)
			{
				Redirect = Encoding.UTF8.GetString(bytes, num, num5);
				num += num5;
			}
			else
			{
				Redirect = string.Empty;
			}
			if (num + 4 <= bytes.Length)
			{
				monID = BitConverter.ToInt32(bytes, num);
				num += 4;
				if (num + 4 <= bytes.Length)
				{
					type = BitConverter.ToInt32(bytes, num);
					num += 4;
					byteIndex = num;
				}
			}
		}
	}
}
