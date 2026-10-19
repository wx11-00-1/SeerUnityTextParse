namespace core.config
{
	public class IBrickBreakerGamePlayerInfo : IConfigItem
	{
		public string name { get; set; }

		public string showvalue { get; set; }

		public string skilldes { get; set; }

		public int attackrate { get; set; }

		public int bulletid { get; set; }

		public int critrate { get; set; }

		public int hp { get; set; }

		public int id { get; set; }

		public int minibullet { get; set; }

		public int movespeed { get; set; }

		public int scopedamagerate { get; set; }

		public int skill { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			attackrate = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			bulletid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			critrate = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			hp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			minibullet = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			movespeed = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			scopedamagerate = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			showvalue = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			skill = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			skilldes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
