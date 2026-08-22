namespace core.config
{
	public class BagTowerEquipUpgrade : XlsConfigBase<BagTowerEquipUpgrade, IBagTowerEquipUpgradeInfo>
	{
		public override string fileName
		{
			get
			{
				return "bagTower_EquipUpgrade";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IBagTowerEquipUpgradeInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IBagTowerEquipUpgradeInfo();
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
