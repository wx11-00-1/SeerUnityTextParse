namespace core.config
{
	public class Year2025QteMain : XlsConfigBase<Year2025QteMain, IYear2025QteMainInfo>
	{
		public override string fileName
		{
			get
			{
				return "year2025_qte_main";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IYear2025QteMainInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IYear2025QteMainInfo();
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
