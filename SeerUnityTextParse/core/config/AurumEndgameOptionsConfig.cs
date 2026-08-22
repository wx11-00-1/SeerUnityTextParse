namespace core.config
{
	public class AurumEndgameOptionsConfig : XlsConfigBase<AurumEndgameOptionsConfig, IAurumEndgameOptionsConfigInfo>
	{
		public override string fileName
		{
			get
			{
				return "aurumEndgameOptionsConfig";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IAurumEndgameOptionsConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IAurumEndgameOptionsConfigInfo();
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
