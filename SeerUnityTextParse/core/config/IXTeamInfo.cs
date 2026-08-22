namespace core.config
{
	public class IXTeamInfo : IConfigItem
	{
		public string conditionText { get; set; }

		public string wintext { get; set; }

		public int[] rewardcnt { get; set; }

		public int[] rewardid { get; set; }

		public int boss { get; set; }

		public int id { get; set; }

		public int indexType { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			boss = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			conditionText = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			indexType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				rewardcnt = new int[num];
				for (int i = 0; i < num; i++)
				{
					rewardcnt[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				rewardid = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					rewardid[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			wintext = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
