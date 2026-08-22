namespace core.config
{
	public class TeamTaskInfo : XlsConfigBase<TeamTaskInfo, ITeamTaskInfoInfo>
	{
		public override string fileName
		{
			get
			{
				return "TeamTaskInfo";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new ITeamTaskInfoInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new ITeamTaskInfoInfo();
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
