namespace core.config
{
	public class HelpTips : XlsConfigBase<HelpTips, IHelpTipsInfo>
	{
		public override string fileName
		{
			get
			{
				return "help_tips";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IHelpTipsInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IHelpTipsInfo();
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
