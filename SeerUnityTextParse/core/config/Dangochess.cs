namespace core.config
{
	public class Dangochess : XlsConfigBase<Dangochess, IDangochessInfo>
	{
		public override string fileName
		{
			get
			{
				return "dangochess";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IDangochessInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IDangochessInfo();
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
