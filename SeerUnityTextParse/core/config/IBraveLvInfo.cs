namespace core.config
{
	public class IBraveLvInfo : IConfigItem
	{
		public string[] upreward { get; set; }

		public int[] petid_newseid_5thmoveid { get; set; }

		public int id { get; set; }

		public int storehouse { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				petid_newseid_5thmoveid = new int[num];
				for (int i = 0; i < num; i++)
				{
					petid_newseid_5thmoveid[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			storehouse = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				upreward = new string[num2];
				for (int j = 0; j < num2; j++)
				{
					upreward[j] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
		}
	}
}
