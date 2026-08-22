namespace core.config
{
	public class DangoAction : XlsConfigBase<DangoAction, IDangoActionInfo>
	{
		public override string fileName
		{
			get
			{
				return "dangoAction";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IDangoActionInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IDangoActionInfo();
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
