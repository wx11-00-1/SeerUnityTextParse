namespace core.config
{
	public class IColourmatchGameInfo : IConfigItem
	{
		public string endtips { get; set; }

		public string reward { get; set; }

		public string strattips { get; set; }

		public int[] endstatus { get; set; }

		public int[] stratstatus { get; set; }

		public int id { get; set; }

		public int opentime { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				endstatus = new int[num];
				for (int i = 0; i < num; i++)
				{
					endstatus[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			endtips = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			opentime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				stratstatus = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					stratstatus[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			strattips = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
