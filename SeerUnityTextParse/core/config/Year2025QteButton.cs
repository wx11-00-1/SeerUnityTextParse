namespace core.config
{
	public class Year2025QteButton : XlsConfigBase<Year2025QteButton, IYear2025QteButtonInfo>
	{
		public override string fileName
		{
			get
			{
				return "year2025_qte_button";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IYear2025QteButtonInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IYear2025QteButtonInfo();
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
