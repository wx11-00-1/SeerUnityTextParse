namespace core.config
{
	public class IRetrieveInfo : IConfigItem
	{
		public string money { get; set; }

		public int[] num { get; set; }

		public int id { get; set; }

		public int ratio { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			money = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.num = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.num[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			ratio = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
