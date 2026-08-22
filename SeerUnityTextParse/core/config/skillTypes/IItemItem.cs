namespace core.config.skillTypes
{
	public class IItemItem : IConfigItem
	{
		public string att { get; set; }

		public string cn { get; set; }

		public string[] en { get; set; }

		public int id { get; set; }

		public int is_dou { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			att = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			cn = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				en = new string[num];
				for (int i = 0; i < num; i++)
				{
					en[i] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			is_dou = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
