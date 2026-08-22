namespace core.config
{
	public class ExpressJump : XlsConfigBase<ExpressJump, IExpressJumpInfo>
	{
		public override string fileName
		{
			get
			{
				return "express_jump";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IExpressJumpInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IExpressJumpInfo();
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
