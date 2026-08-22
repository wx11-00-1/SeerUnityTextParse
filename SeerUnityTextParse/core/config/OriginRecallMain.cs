namespace core.config
{
	public class OriginRecallMain : XlsConfigBase<OriginRecallMain, IOriginRecallMainInfo>
	{
		public override string fileName
		{
			get
			{
				return "OriginRecall_Main";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IOriginRecallMainInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IOriginRecallMainInfo();
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
