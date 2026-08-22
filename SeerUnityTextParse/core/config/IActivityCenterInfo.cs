namespace core.config
{
	public class IActivityCenterInfo : IConfigItem
	{
		public string args { get; set; }

		public string beginning { get; set; }

		public string ending { get; set; }

		public string labelName { get; set; }

		public string name { get; set; }

		public int channel { get; set; }

		public int Go { get; set; }

		public int helptips { get; set; }

		public int id { get; set; }

		public int iOSreviewshow { get; set; }

		public int isShow { get; set; }

		public int redbadge { get; set; }

		public int signType { get; set; }

		public int sorting { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Go = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			args = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			beginning = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			channel = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ending = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			helptips = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			iOSreviewshow = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isShow = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			labelName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			redbadge = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			signType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			sorting = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
