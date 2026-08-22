namespace core.config
{
	public class AurumEndgameEnemyConfig : XlsConfigBase<AurumEndgameEnemyConfig, IAurumEndgameEnemyConfigInfo>
	{
		public override string fileName
		{
			get
			{
				return "aurumEndgameEnemyConfig";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IAurumEndgameEnemyConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IAurumEndgameEnemyConfigInfo();
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
