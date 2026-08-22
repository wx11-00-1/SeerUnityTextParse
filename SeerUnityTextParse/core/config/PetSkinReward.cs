namespace core.config
{
	public class PetSkinReward : XlsConfigBase<PetSkinReward, IPetSkinRewardInfo>
	{
		public override string fileName
		{
			get
			{
				return "pet_skin_reward";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IPetSkinRewardInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IPetSkinRewardInfo();
					data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		public override void Parse(byte[] bytes)
		{
			int byteIndex = 0;
			Parse(bytes, ref byteIndex);
		}
	}
}
