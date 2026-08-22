namespace core.config
{
	public class ITempleHeroesMainInfo : IConfigItem
	{
		public string endTime { get; set; }

		public string price { get; set; }

		public string startTime { get; set; }

		public int[] monAppend { get; set; }

		public int id { get; set; }

		public int isOn { get; set; }

		public int monsterId { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			endTime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isOn = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				monAppend = new int[num];
				for (int i = 0; i < num; i++)
				{
					monAppend[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			monsterId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			price = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			startTime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
