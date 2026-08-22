namespace core.config
{
	public class ISignboardInfo : IConfigItem
	{
		public string content { get; set; }

		public string voice { get; set; }

		public int[] endtime { get; set; }

		public int[] month { get; set; }

		public int[] starttime { get; set; }

		public int id { get; set; }

		public int monid { get; set; }

		public int x { get; set; }

		public int y { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			content = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				endtime = new int[num];
				for (int i = 0; i < num; i++)
				{
					endtime[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				month = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					month[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				starttime = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					starttime[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			voice = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			x = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			y = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
