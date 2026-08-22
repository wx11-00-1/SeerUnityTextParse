namespace core.config
{
	public class IChessGameBuffInfo : IConfigItem
	{
		public string adddesc { get; set; }

		public string buffeffect { get; set; }

		public string buffparam { get; set; }

		public string desc { get; set; }

		public string icon { get; set; }

		public string name { get; set; }

		public string reddesc { get; set; }

		public int addtype { get; set; }

		public int bufftype { get; set; }

		public int id { get; set; }

		public int isshow { get; set; }

		public int taketime { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			adddesc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			addtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			buffeffect = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			buffparam = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			bufftype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			icon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isshow = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			reddesc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			taketime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
