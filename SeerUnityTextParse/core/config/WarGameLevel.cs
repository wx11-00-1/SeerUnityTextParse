namespace core.config
{
	public class WarGameLevel : XlsConfigBase<WarGameLevel, IWarGameLevelInfo>
	{
		public override string fileName
		{
			get
			{
				return "warGame_Level";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IWarGameLevelInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IWarGameLevelInfo();
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
