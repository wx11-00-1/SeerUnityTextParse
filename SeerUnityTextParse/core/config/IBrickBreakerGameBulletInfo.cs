namespace core.config
{
	public class IBrickBreakerGameBulletInfo : IConfigItem
	{
		public string bookdes { get; set; }

		public string des { get; set; }

		public string mix { get; set; }

		public string name { get; set; }

		public string pic { get; set; }

		public string skill { get; set; }

		public string tag1 { get; set; }

		public string tag2 { get; set; }

		public int attack { get; set; }

		public int bulletid { get; set; }

		public float critDamage { get; set; }

		public float critRare { get; set; }

		public int id { get; set; }

		public int level { get; set; }

		public int speed { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			attack = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			bookdes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			bulletid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			critDamage = ByteUtil.ReadFloat(bytes, ref byteIndex);
			critRare = ByteUtil.ReadFloat(bytes, ref byteIndex);
			des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			mix = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			pic = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			skill = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			speed = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			tag1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			tag2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
