namespace core.config
{
	public class BagTowerEquipEffect : XlsConfigBase<BagTowerEquipEffect, IBagTowerEquipEffectInfo>
	{
		public override string fileName
		{
			get
			{
				return "bagTower_EquipEffect";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IBagTowerEquipEffectInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IBagTowerEquipEffectInfo();
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
