namespace core.config
{
	public class BagTowerPlaerExp : XlsConfigBase<BagTowerPlaerExp, IBagTowerPlaerExpInfo>
	{
		public override string fileName
		{
			get
			{
				return "bagTower_PlaerExp";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IBagTowerPlaerExpInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IBagTowerPlaerExpInfo();
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
