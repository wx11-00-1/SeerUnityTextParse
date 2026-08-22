namespace core.config
{
	public class IStartrekbuffinfoInfo : IConfigItem
	{
		public string BuffDesc { get; set; }

		public string BuffName { get; set; }

		public int[] BasicValue { get; set; }

		public int BuffId { get; set; }

		public int BuffPondID { get; set; }

		public int id { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				BasicValue = new int[num];
				for (int i = 0; i < num; i++)
				{
					BasicValue[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			BuffDesc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			BuffId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			BuffName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			BuffPondID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
