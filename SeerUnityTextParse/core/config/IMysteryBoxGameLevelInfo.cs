namespace core.config
{
	public class IMysteryBoxGameLevelInfo : IConfigItem
	{
		public string des { get; set; }

		public string name { get; set; }

		public int[] rare { get; set; }

		public int Amax { get; set; }

		public int Amin { get; set; }

		public int Bmax { get; set; }

		public int Bmin { get; set; }

		public int Cmax { get; set; }

		public int Cmin { get; set; }

		public int Emax { get; set; }

		public int Emin { get; set; }

		public int id { get; set; }

		public int value { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Amax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Amin = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Bmax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Bmin = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Cmax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Cmin = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Emax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Emin = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				rare = new int[num];
				for (int i = 0; i < num; i++)
				{
					rare[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
