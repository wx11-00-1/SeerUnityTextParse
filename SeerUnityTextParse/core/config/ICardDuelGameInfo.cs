namespace core.config
{
	public class ICardDuelGameInfo : IConfigItem
	{
		public int[] attackPos { get; set; }

		public int actionType { get; set; }

		public int id { get; set; }

		public int prepareTime { get; set; }

		public int value { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			actionType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				attackPos = new int[num];
				for (int i = 0; i < num; i++)
				{
					attackPos[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			prepareTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
