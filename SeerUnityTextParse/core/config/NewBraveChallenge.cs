namespace core.config
{
	public class NewBraveChallenge : XlsConfigBase<NewBraveChallenge, INewBraveChallengeInfo>
	{
		public override string fileName
		{
			get
			{
				return "newBraveChallenge";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new INewBraveChallengeInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new INewBraveChallengeInfo();
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
