namespace core.config.elvenkingtrial_exchange
{
	public class IItemItem : IConfigItem
	{
		public string bosstitle { get; set; }

		public int[] exreward { get; set; }

		public int bosslist { get; set; }

		public int bsreward { get; set; }

		public int difficulty { get; set; }

		public int id { get; set; }

		public int mon { get; set; }

		public int unlimite { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			bosslist = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			bosstitle = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			bsreward = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			difficulty = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				exreward = new int[num];
				for (int i = 0; i < num; i++)
				{
					exreward[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			mon = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			unlimite = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
