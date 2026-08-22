namespace core.config
{
	public class PrivateTrainExtraReward : XlsConfigBase<PrivateTrainExtraReward, IPrivateTrainExtraRewardInfo>
	{
		public override string fileName
		{
			get
			{
				return "privateTrainExtraReward";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IPrivateTrainExtraRewardInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IPrivateTrainExtraRewardInfo();
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
