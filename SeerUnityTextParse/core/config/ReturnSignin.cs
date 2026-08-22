namespace core.config
{
	public class ReturnSignin : XlsConfigBase<ReturnSignin, IReturnSigninInfo>
	{
		public override string fileName
		{
			get
			{
				return "return_signin";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IReturnSigninInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IReturnSigninInfo();
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
