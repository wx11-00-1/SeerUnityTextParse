namespace core.config
{
	public class IDangoActionInfo : IConfigItem
	{
		public string action { get; set; }

		public string describ { get; set; }

		public string name { get; set; }

		public int[] dangoID { get; set; }

		public int actionTeam { get; set; }

		public int id { get; set; }

		public int limitDango { get; set; }

		public int limitType { get; set; }

		public int value { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			action = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			actionTeam = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				dangoID = new int[num];
				for (int i = 0; i < num; i++)
				{
					dangoID[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			describ = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			limitDango = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			limitType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
