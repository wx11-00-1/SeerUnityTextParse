namespace core.config
{
	public class Suitsale : XlsConfigBase<Suitsale, ISuitsaleInfo>
	{
		public override string fileName
		{
			get
			{
				return "suitsale";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new ISuitsaleInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new ISuitsaleInfo();
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
