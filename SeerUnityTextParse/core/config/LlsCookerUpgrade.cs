namespace core.config
{
	public class LlsCookerUpgrade : XlsConfigBase<LlsCookerUpgrade, ILlsCookerUpgradeInfo>
	{
		public override string fileName
		{
			get
			{
				return "lls_cooker_upgrade";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new ILlsCookerUpgradeInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new ILlsCookerUpgradeInfo();
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
