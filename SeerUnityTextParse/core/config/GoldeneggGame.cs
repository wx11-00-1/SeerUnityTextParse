namespace core.config
{
	public class GoldeneggGame : XlsConfigBase<GoldeneggGame, IGoldeneggGameInfo>
	{
		public override string fileName
		{
			get
			{
				return "goldeneggGame";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IGoldeneggGameInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IGoldeneggGameInfo();
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
