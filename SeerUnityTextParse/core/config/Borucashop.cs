namespace core.config
{
	public class Borucashop : XlsConfigBase<Borucashop, IBorucashopInfo>
	{
		public override string fileName
		{
			get
			{
				return "borucashop";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IBorucashopInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IBorucashopInfo();
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
