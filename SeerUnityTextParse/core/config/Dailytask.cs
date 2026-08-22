namespace core.config
{
	public class Dailytask : XlsConfigBase<Dailytask, IDailytaskInfo>
	{
		public override string fileName
		{
			get
			{
				return "dailytask";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IDailytaskInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IDailytaskInfo();
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
