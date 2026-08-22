namespace core.config
{
	public class CrystalLegendUpdateTxt : XlsConfigBase<CrystalLegendUpdateTxt, ICrystalLegendUpdateTxtInfo>
	{
		public override string fileName
		{
			get
			{
				return "crystalLegendUpdateTxt";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new ICrystalLegendUpdateTxtInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new ICrystalLegendUpdateTxtInfo();
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
