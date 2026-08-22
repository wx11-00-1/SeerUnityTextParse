namespace core.config
{
	public class IStarmapInfo : IConfigItem
	{
		public string[] fun { get; set; }

		public string intro { get; set; }

		public string name { get; set; }

		public int[] submap { get; set; }

		public int Gotomap { get; set; }

		public int id { get; set; }

		public int isopen { get; set; }

		public int shipArea { get; set; }

		public int showOut { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Gotomap = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				fun = new string[num];
				for (int i = 0; i < num; i++)
				{
					fun[i] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			intro = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			isopen = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			shipArea = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			showOut = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				submap = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					submap[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
