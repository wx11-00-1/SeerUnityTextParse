namespace core.config
{
	public class ITeamTaskInfoInfo : IConfigItem
	{
		public string TeamTaskDescription { get; set; }

		public string TeamTaskName { get; set; }

		public int[] TeamTaskBaseReward { get; set; }

		public int[] TeamTaskExtraReward { get; set; }

		public int[] TeamTaskRecommendPets { get; set; }

		public int id { get; set; }

		public int TeamTaskDispatchTime { get; set; }

		public int TeamTaskNeedPetNum { get; set; }

		public int TeamTaskStar { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				TeamTaskBaseReward = new int[num];
				for (int i = 0; i < num; i++)
				{
					TeamTaskBaseReward[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			TeamTaskDescription = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			TeamTaskDispatchTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				TeamTaskExtraReward = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					TeamTaskExtraReward[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			TeamTaskName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			TeamTaskNeedPetNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				TeamTaskRecommendPets = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					TeamTaskRecommendPets[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			TeamTaskStar = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
