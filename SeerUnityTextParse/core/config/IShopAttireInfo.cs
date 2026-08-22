namespace core.config
{
	public class IShopAttireInfo : IConfigItem
	{
		public string name { get; set; }

		public int[] miditem { get; set; }

		public int[] price { get; set; }

		public int[] prop { get; set; }

		public int[] reward { get; set; }

		public int[] vipprice { get; set; }

		public int id { get; set; }

		public int label { get; set; }

		public int recommend { get; set; }

		public int show { get; set; }

		public int sort { get; set; }

		public int suit { get; set; }

		public int type { get; set; }

		public int vip { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			label = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				miditem = new int[num];
				for (int i = 0; i < num; i++)
				{
					miditem[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				price = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					price[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				prop = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					prop[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			recommend = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				reward = new int[num4];
				for (int l = 0; l < num4; l++)
				{
					reward[l] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			show = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			suit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			vip = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num5 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				vipprice = new int[num5];
				for (int m = 0; m < num5; m++)
				{
					vipprice[m] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
