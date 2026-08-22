namespace core.config
{
	public class ISPTtaskInfo : IConfigItem
	{
		public string otherreward { get; set; }

		public int[] btlconid { get; set; }

		public int[] firstreward { get; set; }

		public int[] monsterid { get; set; }

		public int[] unlockcond { get; set; }

		public int galaxyid { get; set; }

		public int id { get; set; }

		public int isend { get; set; }

		public int taskmode { get; set; }

		public int taskstep { get; set; }

		public int tasktype { get; set; }

		public int unlockmark { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				btlconid = new int[num];
				for (int i = 0; i < num; i++)
				{
					btlconid[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				firstreward = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					firstreward[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			galaxyid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isend = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				monsterid = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					monsterid[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			otherreward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			taskmode = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			taskstep = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			tasktype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				unlockcond = new int[num4];
				for (int l = 0; l < num4; l++)
				{
					unlockcond[l] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			unlockmark = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
