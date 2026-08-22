namespace core.config
{
	public class ClickfpsGame : XlsConfigBase<ClickfpsGame, IClickfpsGameInfo>
	{
		public override string fileName
		{
			get
			{
				return "clickfps_game";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IClickfpsGameInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IClickfpsGameInfo();
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
