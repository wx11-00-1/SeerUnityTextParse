namespace core.config
{
	public class IChessGameCardInfo : IConfigItem
	{
		public string buff { get; set; }

		public string buynum { get; set; }

		public string cardeffect { get; set; }

		public string desc { get; set; }

		public string icon { get; set; }

		public string move { get; set; }

		public string name { get; set; }

		public string opentime { get; set; }

		public int acttype { get; set; }

		public int atk { get; set; }

		public int def { get; set; }

		public int energy { get; set; }

		public int id { get; set; }

		public int isequip { get; set; }

		public int ishand { get; set; }

		public int occupation { get; set; }

		public int quality { get; set; }

		public int takerange { get; set; }

		public int takerangetype { get; set; }

		public int type { get; set; }

		public int upgradeid { get; set; }

		public int useobject { get; set; }

		public int userangelength { get; set; }

		public int userangetype { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			acttype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			atk = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			buff = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			buynum = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			cardeffect = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			def = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			energy = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			icon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isequip = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ishand = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			move = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			occupation = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			opentime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			quality = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			takerange = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			takerangetype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			upgradeid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			useobject = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			userangelength = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			userangetype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
