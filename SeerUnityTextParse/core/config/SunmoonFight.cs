namespace core.config
{
	public class SunmoonFight : XlsConfigBase<SunmoonFight, ISunmoonFightInfo>
	{
		public override string fileName
		{
			get
			{
				return "sunmoon_fight";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new ISunmoonFightInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new ISunmoonFightInfo();
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
