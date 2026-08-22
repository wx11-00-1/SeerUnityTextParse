namespace core.config
{
	public class Retrieve : XlsConfigBase<Retrieve, IRetrieveInfo>
	{
		public override string fileName
		{
			get
			{
				return "retrieve";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IRetrieveInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IRetrieveInfo();
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
