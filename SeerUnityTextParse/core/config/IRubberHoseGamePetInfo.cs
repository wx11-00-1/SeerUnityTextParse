namespace core.config
{
	public class IRubberHoseGamePetInfo : IConfigItem
	{
		public string name { get; set; }

		public string skilldes { get; set; }

		public string tag { get; set; }

		public int[] skill { get; set; }

		public int atk { get; set; }

		public int atkrange { get; set; }

		public int atktime { get; set; }

		public int atktype { get; set; }

		public int cost { get; set; }

		public int hp { get; set; }

		public int id { get; set; }

		public int movespeed { get; set; }

		public int unlock { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			atk = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			atkrange = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			atktime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			atktype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			cost = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			hp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			movespeed = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				skill = new int[num];
				for (int i = 0; i < num; i++)
				{
					skill[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			skilldes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			tag = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			unlock = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
