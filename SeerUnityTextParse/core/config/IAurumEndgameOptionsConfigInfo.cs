namespace core.config
{
	public class IAurumEndgameOptionsConfigInfo : IConfigItem
	{
		public string attritube { get; set; }

		public string desc { get; set; }

		public string name { get; set; }

		public int branchid { get; set; }

		public int group { get; set; }

		public int id { get; set; }

		public int maxnum { get; set; }

		public int rarity { get; set; }

		public int related { get; set; }

		public int root { get; set; }

		public int treeid { get; set; }

		public int type { get; set; }

		public int value { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			attritube = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			branchid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			group = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			maxnum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			related = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			root = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			treeid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
