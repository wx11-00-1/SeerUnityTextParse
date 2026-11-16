namespace core.config
{
	public class ISomuaModelConfigInfo : IConfigItem
	{
		public string addonPool { get; set; }

		public string addonPoolSP { get; set; }

		public string describe { get; set; }

		public string name { get; set; }

		public string naturePool { get; set; }

		public string season { get; set; }

		public int attackMode { get; set; }

		public int attackModeSP { get; set; }

		public int id { get; set; }

		public int isBack { get; set; }

		public int isBody { get; set; }

		public int isEar { get; set; }

		public int isExpression { get; set; }

		public int isHand { get; set; }

		public int isHead { get; set; }

		public int isSurrounding { get; set; }

		public int isTail { get; set; }

		public int isTopwear { get; set; }

		public int petID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			addonPool = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			addonPoolSP = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			attackMode = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			attackModeSP = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isBack = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isBody = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isEar = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isExpression = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isHand = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isHead = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isSurrounding = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isTail = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isTopwear = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			naturePool = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			petID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			season = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
