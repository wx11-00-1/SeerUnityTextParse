namespace core.config
{
	public class Petclassfix : XlsConfigBase<Petclassfix, IPetclassfixInfo>
	{
		public override string fileName
		{
			get
			{
				return "petclassfix";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IPetclassfixInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IPetclassfixInfo();
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
