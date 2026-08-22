namespace core.config
{
	public class IDayDreamGiftConfigInfo : IConfigItem
	{
		public string icon { get; set; }

		public string name { get; set; }

		public int id { get; set; }

		public int notA { get; set; }

		public int notB { get; set; }

		public int notC { get; set; }

		public int toA { get; set; }

		public int toB { get; set; }

		public int toC { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			icon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			notA = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			notB = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			notC = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			toA = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			toB = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			toC = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
