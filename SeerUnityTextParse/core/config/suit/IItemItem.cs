namespace core.config.suit
{
	public class IItemItem : IConfigItem
	{
		public string name { get; set; }

		public string suitdes { get; set; }

		public int[] cloths { get; set; }

		public int id { get; set; }

		public int transform { get; set; }

		public float tranSpeed { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				cloths = new int[num];
				for (int i = 0; i < num; i++)
				{
					cloths[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			suitdes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			tranSpeed = ByteUtil.ReadFloat(bytes, ref byteIndex);
			transform = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
