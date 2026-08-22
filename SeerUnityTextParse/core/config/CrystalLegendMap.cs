namespace core.config
{
	public class CrystalLegendMap : XlsConfigBase<CrystalLegendMap, ICrystalLegendMapInfo>
	{
		public override string fileName
		{
			get
			{
				return "crystalLegendMap";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new ICrystalLegendMapInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new ICrystalLegendMapInfo();
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
