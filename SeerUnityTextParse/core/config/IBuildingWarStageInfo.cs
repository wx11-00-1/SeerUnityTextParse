namespace core.config
{
	public class IBuildingWarStageInfo : IConfigItem
	{
		public int[] changereward { get; set; }

		public int[] judgeitem { get; set; }

		public int[] reward { get; set; }

		public int[] skilllist { get; set; }

		public int id { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				changereward = new int[num];
				for (int i = 0; i < num; i++)
				{
					changereward[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				judgeitem = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					judgeitem[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				reward = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					reward[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				skilllist = new int[num4];
				for (int l = 0; l < num4; l++)
				{
					skilllist[l] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
