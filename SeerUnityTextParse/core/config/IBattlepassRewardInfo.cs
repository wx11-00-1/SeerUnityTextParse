namespace core.config
{
	public class IBattlepassRewardInfo : IConfigItem
	{
		public string freereward { get; set; }

		public string paidreward { get; set; }

		public int diamondnum { get; set; }

		public int exp { get; set; }

		public int id { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			diamondnum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			exp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			freereward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			paidreward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
