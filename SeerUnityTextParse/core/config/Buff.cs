namespace core.config
{
	public class Buff : XlsConfigBase<Buff, IBuffInfo>
	{
		public override string fileName
		{
			get
			{
				return "buff";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IBuffInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IBuffInfo();
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
