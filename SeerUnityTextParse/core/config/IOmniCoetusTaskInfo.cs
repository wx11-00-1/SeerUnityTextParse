namespace core.config
{
	public class IOmniCoetusTaskInfo : IConfigItem
	{
		public string describe { get; set; }

		public string rewardinfo { get; set; }

		public int exp { get; set; }

		public int go { get; set; }

		public int id { get; set; }

		public int shareExp { get; set; }

		public int sorting { get; set; }

		public int time { get; set; }

		public int userinfo { get; set; }

		public int value { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			exp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			go = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rewardinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			shareExp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			sorting = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			time = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			userinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
