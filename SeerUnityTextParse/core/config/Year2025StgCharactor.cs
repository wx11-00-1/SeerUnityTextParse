namespace core.config
{
	public class Year2025StgCharactor : XlsConfigBase<Year2025StgCharactor, IYear2025StgCharactorInfo>
	{
		public override string fileName
		{
			get
			{
				return "year2025_stg_charactor";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IYear2025StgCharactorInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IYear2025StgCharactorInfo();
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
