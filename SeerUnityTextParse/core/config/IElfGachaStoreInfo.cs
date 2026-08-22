namespace core.config
{
	public class IElfGachaStoreInfo : IConfigItem
	{
		public string endtime { get; set; }

		public string reward { get; set; }

		public string starttime { get; set; }

		public int consumeid { get; set; }

		public int consumnum { get; set; }

		public int id { get; set; }

		public int NewMsglogId { get; set; }

		public int poolid { get; set; }

		public int storeid { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			NewMsglogId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			consumeid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			consumnum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			endtime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			poolid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			starttime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			storeid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
