namespace core.config
{
	public class ReturnSigninNew : XlsConfigBase<ReturnSigninNew, IReturnSigninNewInfo>
	{
		public override string fileName
		{
			get
			{
				return "return_signin_new";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IReturnSigninNewInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IReturnSigninNewInfo();
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
