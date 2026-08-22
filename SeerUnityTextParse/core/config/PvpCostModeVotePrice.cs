namespace core.config
{
	public class PvpCostModeVotePrice : XlsConfigBase<PvpCostModeVotePrice, IPvpCostModeVotePriceInfo>
	{
		public override string fileName
		{
			get
			{
				return "pvpCostMode_votePrice";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IPvpCostModeVotePriceInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IPvpCostModeVotePriceInfo();
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
