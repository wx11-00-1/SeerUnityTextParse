namespace core.config
{
	public class IPvpTaskInfo : IConfigItem
	{
		public string describe { get; set; }

		public string rewardinfo { get; set; }

		public string title { get; set; }

		public int exp { get; set; }

		public int id { get; set; }

		public int pos { get; set; }

		public int rarity { get; set; }

		public int subkey { get; set; }

		public int time { get; set; }

		public int userinfo { get; set; }

		public int value { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			exp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			pos = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rewardinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			subkey = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			time = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			userinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
