namespace core.config
{
	public class AurumEndgameExpConfigEndless : XlsConfigBase<AurumEndgameExpConfigEndless, IAurumEndgameExpConfigEndlessInfo>
	{
		public override string fileName
		{
			get
			{
				return "aurumEndgameExpConfig_endless";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IAurumEndgameExpConfigEndlessInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IAurumEndgameExpConfigEndlessInfo();
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
