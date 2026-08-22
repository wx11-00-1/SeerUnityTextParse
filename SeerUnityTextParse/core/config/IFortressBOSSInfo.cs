namespace core.config
{
	public class IFortressBOSSInfo : IConfigItem
	{
		public string bossInfo { get; set; }

		public string fortressName { get; set; }

		public int[] damageToHp { get; set; }

		public int boss { get; set; }

		public int fortressHp { get; set; }

		public int id { get; set; }

		public int layer { get; set; }

		public int petID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			boss = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			bossInfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				damageToHp = new int[num];
				for (int i = 0; i < num; i++)
				{
					damageToHp[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			fortressHp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			fortressName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			layer = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			petID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
