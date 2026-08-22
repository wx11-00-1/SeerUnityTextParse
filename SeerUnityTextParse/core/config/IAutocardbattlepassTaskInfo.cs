namespace core.config
{
	public class IAutocardbattlepassTaskInfo : IConfigItem
	{
		public string describe { get; set; }

		public int exp { get; set; }

		public int id { get; set; }

		public int rewardbit { get; set; }

		public int rewarduserinfo { get; set; }

		public int time { get; set; }

		public int userinfo { get; set; }

		public int value { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			exp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rewardbit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rewarduserinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			time = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			userinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
