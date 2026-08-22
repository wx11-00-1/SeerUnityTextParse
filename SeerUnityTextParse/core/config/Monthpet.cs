namespace core.config
{
	public class Monthpet : XlsConfigBase<Monthpet, IMonthpetInfo>
	{
		public override string fileName
		{
			get
			{
				return "monthpet";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IMonthpetInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IMonthpetInfo();
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
