namespace core.config
{
	public class IRubberHoseGameLevelInfo : IConfigItem
	{
		public string des { get; set; }

		public string monster { get; set; }

		public string name { get; set; }

		public string reward { get; set; }

		public string time { get; set; }

		public int atkrate { get; set; }

		public int costup { get; set; }

		public int homehp { get; set; }

		public int hprate { get; set; }

		public int id { get; set; }

		public int maxcost { get; set; }

		public int monsterhomehp { get; set; }

		public int monstersum { get; set; }

		public int petreward { get; set; }

		public int startcost { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			atkrate = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			costup = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			homehp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			hprate = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			maxcost = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monster = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			monsterhomehp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monstersum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			petreward = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			startcost = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			time = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
