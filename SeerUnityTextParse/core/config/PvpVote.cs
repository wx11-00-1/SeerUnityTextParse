namespace core.config
{
	public class PvpVote : XlsConfigBase<PvpVote, IPvpVoteInfo>
	{
		public override string fileName
		{
			get
			{
				return "pvp_vote";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IPvpVoteInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IPvpVoteInfo();
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
