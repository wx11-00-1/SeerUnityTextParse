namespace core.config
{
	public class IAurumEndgameEnemyConfigInfo : IConfigItem
	{
		public string desc { get; set; }

		public string name { get; set; }

		public int atkBc { get; set; }

		public int atkRate { get; set; }

		public int hpBc { get; set; }

		public int id { get; set; }

		public int model { get; set; }

		public int scale { get; set; }

		public int speed { get; set; }

		public int speedVar { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			atkBc = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			atkRate = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			hpBc = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			model = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			scale = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			speed = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			speedVar = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
