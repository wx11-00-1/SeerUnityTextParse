namespace core.config
{
	public class IBraveTowerReverseDefenseStrengthenInfo : IConfigItem
	{
		public string name { get; set; }

		public int cost { get; set; }

		public int des { get; set; }

		public int id { get; set; }

		public int level { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			cost = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			des = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
