namespace core.config
{
	public class ElfGachaStore : XlsConfigBase<ElfGachaStore, IElfGachaStoreInfo>
	{
		public override string fileName
		{
			get
			{
				return "elfGachaStore";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IElfGachaStoreInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IElfGachaStoreInfo();
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
