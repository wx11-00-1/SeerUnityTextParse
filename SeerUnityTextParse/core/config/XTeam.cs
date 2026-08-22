namespace core.config
{
	public class XTeam : XlsConfigBase<XTeam, IXTeamInfo>
	{
		public override string fileName
		{
			get
			{
				return "X_Team";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IXTeamInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IXTeamInfo();
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
