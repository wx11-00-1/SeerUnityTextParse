namespace core.config
{
	public class NewBraveLv : XlsConfigBase<NewBraveLv, INewBraveLvInfo>
	{
		public override string fileName
		{
			get
			{
				return "newBraveLv";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new INewBraveLvInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new INewBraveLvInfo();
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
