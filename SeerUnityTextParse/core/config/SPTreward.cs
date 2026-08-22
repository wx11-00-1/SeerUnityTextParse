namespace core.config
{
	public class SPTreward : XlsConfigBase<SPTreward, ISPTrewardInfo>
	{
		public override string fileName
		{
			get
			{
				return "SPTreward";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new ISPTrewardInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new ISPTrewardInfo();
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
