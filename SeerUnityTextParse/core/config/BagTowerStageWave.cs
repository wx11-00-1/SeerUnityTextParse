namespace core.config
{
	public class BagTowerStageWave : XlsConfigBase<BagTowerStageWave, IBagTowerStageWaveInfo>
	{
		public override string fileName
		{
			get
			{
				return "bagTower_StageWave";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IBagTowerStageWaveInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IBagTowerStageWaveInfo();
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
