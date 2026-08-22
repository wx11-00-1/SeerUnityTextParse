namespace core.config
{
	public class AutoOpenPanel : XlsConfigBase<AutoOpenPanel, IAutoOpenPanelInfo>
	{
		public override string fileName
		{
			get
			{
				return "autoOpenPanel";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IAutoOpenPanelInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IAutoOpenPanelInfo();
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
