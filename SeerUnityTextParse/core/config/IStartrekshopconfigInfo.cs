namespace core.config
{
	public class IStartrekshopconfigInfo : IConfigItem
	{
		public string GoodsName { get; set; }

		public string PetID { get; set; }

		public string PetName { get; set; }

		public int[] rewardinfo { get; set; }

		public int[] title { get; set; }

		public int Atk { get; set; }

		public int Def { get; set; }

		public int GoodsBuffType { get; set; }

		public int GoodsID { get; set; }

		public int GoodsPrice { get; set; }

		public int GoodsType { get; set; }

		public int HP { get; set; }

		public int id { get; set; }

		public int SP_Atk { get; set; }

		public int SP_Def { get; set; }

		public int Spd { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Atk = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Def = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			GoodsBuffType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			GoodsID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			GoodsName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			GoodsPrice = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			GoodsType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			HP = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			PetID = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			PetName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			SP_Atk = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			SP_Def = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Spd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				rewardinfo = new int[num];
				for (int i = 0; i < num; i++)
				{
					rewardinfo[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				title = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					title[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
