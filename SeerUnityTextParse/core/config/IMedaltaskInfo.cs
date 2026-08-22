namespace core.config
{
	public class IMedaltaskInfo : IConfigItem
	{
		public string describe { get; set; }

		public string[] jump { get; set; }

		public string value { get; set; }

		public int[] rewardinfo { get; set; }

		public int id { get; set; }

		public int target { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				jump = new string[num];
				for (int i = 0; i < num; i++)
				{
					jump[i] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				rewardinfo = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					rewardinfo[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			target = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			value = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
