namespace core.config
{
	public class NewSeer7Sign : XlsConfigBase<NewSeer7Sign, INewSeer7SignInfo>
	{
		public override string fileName
		{
			get
			{
				return "newSeer7Sign";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new INewSeer7SignInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new INewSeer7SignInfo();
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
