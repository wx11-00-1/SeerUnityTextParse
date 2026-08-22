namespace core.config
{
	public class ISunmoonCareerInfo : IConfigItem
	{
		public string desc { get; set; }

		public string head { get; set; }

		public string image { get; set; }

		public string name { get; set; }

		public string space { get; set; }

		public int atk { get; set; }

		public int camp { get; set; }

		public int cost { get; set; }

		public int hp { get; set; }

		public int id { get; set; }

		public int max { get; set; }

		public int move { get; set; }

		public int point { get; set; }

		public int range { get; set; }

		public int rate { get; set; }

		public int scope { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			atk = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			camp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			cost = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			head = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			hp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			image = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			move = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			point = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			range = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rate = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			scope = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			space = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
