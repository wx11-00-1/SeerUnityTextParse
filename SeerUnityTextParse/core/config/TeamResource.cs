namespace core.config
{
	public class TeamResource : XlsConfigBase<TeamResource, ITeamResourceInfo>
	{
		public override string fileName
		{
			get
			{
				return "TeamResource";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new ITeamResourceInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new ITeamResourceInfo();
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
