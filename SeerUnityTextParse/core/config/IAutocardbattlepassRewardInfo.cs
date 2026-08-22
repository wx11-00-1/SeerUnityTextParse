namespace core.config
{
	public class IAutocardbattlepassRewardInfo : IConfigItem
	{
		public string freereward { get; set; }

		public int exp { get; set; }

		public int id { get; set; }

		public int mainreward { get; set; }

		public int paytype { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			exp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			freereward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			mainreward = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			paytype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
