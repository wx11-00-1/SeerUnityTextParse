namespace core.config
{
	public class IRedbadgeInfo : IConfigItem
	{
		public string channel { get; set; }

		public int[] subset { get; set; }

		public int endtime { get; set; }

		public int id { get; set; }

		public int isshow { get; set; }

		public int starttime { get; set; }

		public int subtype { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			channel = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			endtime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isshow = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			starttime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				subset = new int[num];
				for (int i = 0; i < num; i++)
				{
					subset[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			subtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
