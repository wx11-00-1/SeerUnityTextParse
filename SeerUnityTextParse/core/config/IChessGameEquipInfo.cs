namespace core.config
{
	public class IChessGameEquipInfo : IConfigItem
	{
		public string buff { get; set; }

		public string buynum { get; set; }

		public string equipdesc { get; set; }

		public string icon { get; set; }

		public string name { get; set; }

		public string opentime { get; set; }

		public string skilldesc { get; set; }

		public string skilleffect { get; set; }

		public int atk { get; set; }

		public int def { get; set; }

		public int id { get; set; }

		public int occupation { get; set; }

		public int quality { get; set; }

		public int salenum { get; set; }

		public int skilltimes { get; set; }

		public int takerange { get; set; }

		public int takerangetype { get; set; }

		public int type { get; set; }

		public int userangelength { get; set; }

		public int userangetype { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			atk = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			buff = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			buynum = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			def = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			equipdesc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			icon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			occupation = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			opentime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			quality = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			salenum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			skilldesc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			skilleffect = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			skilltimes = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			takerange = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			takerangetype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			userangelength = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			userangetype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
