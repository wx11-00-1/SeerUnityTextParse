namespace core.config
{
	public class IBraveTaskInfo : IConfigItem
	{
		public string title { get; set; }

		public int[] jump { get; set; }

		public int[] rewardinfo { get; set; }

		public int[] taskparam { get; set; }

		public int group { get; set; }

		public int id { get; set; }

		public int tasktype { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			group = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				jump = new int[num];
				for (int i = 0; i < num; i++)
				{
					jump[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				rewardinfo = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					rewardinfo[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				taskparam = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					taskparam[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			tasktype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
