namespace core.config
{
	public class ILuckyrocketIEquipInfo : IConfigItem
	{
		public string describe { get; set; }

		public string name { get; set; }

		public string showdescribe { get; set; }

		public int equipicon { get; set; }

		public int id { get; set; }

		public int isopen { get; set; }

		public int namedescribe { get; set; }

		public int opentime { get; set; }

		public int priority { get; set; }

		public int rare { get; set; }

		public int unlock { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			equipicon = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isopen = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			namedescribe = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			opentime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			priority = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rare = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			showdescribe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			unlock = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
