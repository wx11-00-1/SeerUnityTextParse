namespace core.config
{
	public class IDangoLvInfo : IConfigItem
	{
		public string describe1 { get; set; }

		public string describe2 { get; set; }

		public string describe3 { get; set; }

		public int[] dangoTask { get; set; }

		public int benefit1 { get; set; }

		public int benefit2 { get; set; }

		public int benefit3 { get; set; }

		public int id { get; set; }

		public int minorNum { get; set; }

		public int reward { get; set; }

		public int taskNum { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			benefit1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			benefit2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			benefit3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				dangoTask = new int[num];
				for (int i = 0; i < num; i++)
				{
					dangoTask[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			describe1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			describe2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			describe3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			minorNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			reward = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			taskNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
