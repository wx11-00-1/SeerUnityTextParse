namespace core.config
{
	public class ISeerFactoryInfo : IConfigItem
	{
		public int[] suitPartID { get; set; }

		public int id { get; set; }

		public int suitID { get; set; }

		public int suitPrice { get; set; }

		public int vipOnly { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			suitID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				suitPartID = new int[num];
				for (int i = 0; i < num; i++)
				{
					suitPartID[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			suitPrice = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			vipOnly = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
