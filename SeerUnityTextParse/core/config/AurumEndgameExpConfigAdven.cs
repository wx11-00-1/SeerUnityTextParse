namespace core.config
{
	public class AurumEndgameExpConfigAdven : XlsConfigBase<AurumEndgameExpConfigAdven, IAurumEndgameExpConfigAdvenInfo>
	{
		public override string fileName
		{
			get
			{
				return "aurumEndgameExpConfig_adven";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IAurumEndgameExpConfigAdvenInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IAurumEndgameExpConfigAdvenInfo();
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
