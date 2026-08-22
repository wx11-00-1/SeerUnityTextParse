namespace core.config
{
	public class Awakencondition : XlsConfigBase<Awakencondition, IAwakenconditionInfo>
	{
		public override string fileName
		{
			get
			{
				return "awakencondition";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IAwakenconditionInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IAwakenconditionInfo();
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
