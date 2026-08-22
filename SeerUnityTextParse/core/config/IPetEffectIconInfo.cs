namespace core.config
{
	public class IPetEffectIconInfo : IConfigItem
	{
		public string Desc { get; set; }

		public int affectedBoss { get; set; }

		public int effecticonid { get; set; }

		public int id { get; set; }

		public int isAdv { get; set; }

		public int petid { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			affectedBoss = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			effecticonid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isAdv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			petid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
