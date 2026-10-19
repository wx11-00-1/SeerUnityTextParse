namespace core.config
{
	public class AwakenlistTemp : XlsConfigBase<AwakenlistTemp, IAwakenlistTempInfo>
	{
		public override string fileName
		{
			get
			{
				return "awakenlist_temp";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IAwakenlistTempInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IAwakenlistTempInfo();
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
