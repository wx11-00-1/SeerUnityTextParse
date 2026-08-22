namespace core.config
{
	public class Startrekshopconfig : XlsConfigBase<Startrekshopconfig, IStartrekshopconfigInfo>
	{
		public override string fileName
		{
			get
			{
				return "Startrekshopconfig";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IStartrekshopconfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IStartrekshopconfigInfo();
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
