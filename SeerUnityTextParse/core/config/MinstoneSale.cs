namespace core.config
{
	public class MinstoneSale : XlsConfigBase<MinstoneSale, IMinstoneSaleInfo>
	{
		public override string fileName
		{
			get
			{
				return "minstoneSale";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IMinstoneSaleInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IMinstoneSaleInfo();
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
