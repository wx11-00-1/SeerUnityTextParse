namespace core.config
{
	public class Startrekbossfight : XlsConfigBase<Startrekbossfight, IStartrekbossfightInfo>
	{
		public override string fileName
		{
			get
			{
				return "Startrekbossfight";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IStartrekbossfightInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IStartrekbossfightInfo();
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
