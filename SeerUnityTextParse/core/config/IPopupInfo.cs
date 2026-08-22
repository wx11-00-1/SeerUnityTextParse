namespace core.config
{
	public class IPopupInfo : IConfigItem
	{
		public string @goto { get; set; }

		public string showEnd { get; set; }

		public string showStart { get; set; }

		public int daily { get; set; }

		public int id { get; set; }

		public int num { get; set; }

		public int pic { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			daily = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			@goto = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			pic = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			showEnd = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			showStart = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
