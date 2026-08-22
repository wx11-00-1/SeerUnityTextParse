namespace core.config
{
	public class Rebate : XlsConfigBase<Rebate, IRebateInfo>
	{
		public override string fileName
		{
			get
			{
				return "rebate";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IRebateInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IRebateInfo();
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
