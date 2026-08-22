namespace core.config
{
	public class IProfilephotoInfo : IConfigItem
	{
		public string desc { get; set; }

		public string @goto { get; set; }

		public string name { get; set; }

		public string spine { get; set; }

		public string text { get; set; }

		public int checkown { get; set; }

		public int finishTime { get; set; }

		public int hide { get; set; }

		public int icon { get; set; }

		public int id { get; set; }

		public int rarity { get; set; }

		public int tab { get; set; }

		public int type { get; set; }

		public int unavailable { get; set; }

		public int unlocktype { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			checkown = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			finishTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			@goto = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			icon = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			spine = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			tab = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			text = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			unavailable = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			unlocktype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
