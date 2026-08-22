namespace core.config
{
	public class BraveTowerReverseDefenseChallenger : XlsConfigBase<BraveTowerReverseDefenseChallenger, IBraveTowerReverseDefenseChallengerInfo>
	{
		public override string fileName
		{
			get
			{
				return "BraveTowerReverseDefense_challenger";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IBraveTowerReverseDefenseChallengerInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IBraveTowerReverseDefenseChallengerInfo();
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
