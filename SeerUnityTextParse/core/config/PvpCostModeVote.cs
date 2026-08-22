namespace core.config
{
	public class PvpCostModeVote : XlsConfigBase<PvpCostModeVote, IPvpCostModeVoteInfo>
	{
		public override string fileName
		{
			get
			{
				return "pvpCostMode_vote";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IPvpCostModeVoteInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IPvpCostModeVoteInfo();
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
