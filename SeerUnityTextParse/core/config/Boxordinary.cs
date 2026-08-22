namespace core.config
{
	public class Boxordinary : XlsConfigBase<Boxordinary, IBoxordinaryInfo>
	{
		public override string fileName
		{
			get
			{
				return "boxordinary";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IBoxordinaryInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IBoxordinaryInfo();
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
