namespace core.config
{
	public class IBrickBreakerGameMonsterInfo : IConfigItem
	{
		public string des { get; set; }

		public string name { get; set; }

		public string skillkey { get; set; }

		public int atk { get; set; }

		public int atktype { get; set; }

		public int crashatk { get; set; }

		public int exp { get; set; }

		public int height { get; set; }

		public int hp { get; set; }

		public int hpdrop { get; set; }

		public int id { get; set; }

		public int monsterid { get; set; }

		public int monstertype { get; set; }

		public int moveinterval { get; set; }

		public int skillcd { get; set; }

		public int strdrop { get; set; }

		public int width { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			atk = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			atktype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			crashatk = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			exp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			height = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			hp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			hpdrop = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monsterid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monstertype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			moveinterval = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			skillcd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			skillkey = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			strdrop = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			width = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
