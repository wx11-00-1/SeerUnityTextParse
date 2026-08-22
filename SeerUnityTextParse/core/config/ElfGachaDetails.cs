namespace core.config
{
	public class ElfGachaDetails : XlsConfigBase<ElfGachaDetails, IElfGachaDetailsInfo>
	{
		public override string fileName
		{
			get
			{
				return "elfGachaDetails";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IElfGachaDetailsInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IElfGachaDetailsInfo();
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
