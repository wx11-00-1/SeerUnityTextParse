namespace core.config.effectDes
{
	public class IItemItem : IConfigItem
	{
		public string desc { get; set; }

		public string kinddes { get; set; }

		public string link { get; set; }

		public string monster { get; set; }

		public int icon { get; set; }

		public int id { get; set; }

		public int kind { get; set; }

		public int tab { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			icon = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			kind = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			kinddes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			link = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			monster = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			tab = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
