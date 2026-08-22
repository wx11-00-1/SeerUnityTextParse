namespace core.config
{
	public class IndianaSpirit : XlsConfigBase<IndianaSpirit, IIndianaSpiritInfo>
	{
		public override string fileName
		{
			get
			{
				return "IndianaSpirit";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IIndianaSpiritInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IIndianaSpiritInfo();
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
