namespace core.config
{
	public class ISomuaStatusEffectConfigInfo : IConfigItem
	{
		public string fxOnGet { get; set; }

		public string fxOnTrig { get; set; }

		public string stackRule { get; set; }

		public string statusDesc { get; set; }

		public string statusName { get; set; }

		public string valueRule { get; set; }

		public int icon { get; set; }

		public int id { get; set; }

		public int maxStack { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			fxOnGet = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			fxOnTrig = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			icon = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			maxStack = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			stackRule = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			statusDesc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			statusName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			valueRule = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
