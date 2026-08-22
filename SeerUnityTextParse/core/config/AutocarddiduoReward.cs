namespace core.config
{
	public class AutocarddiduoReward : XlsConfigBase<AutocarddiduoReward, IAutocarddiduoRewardInfo>
	{
		public override string fileName
		{
			get
			{
				return "autocarddiduo_reward";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IAutocarddiduoRewardInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IAutocarddiduoRewardInfo();
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
