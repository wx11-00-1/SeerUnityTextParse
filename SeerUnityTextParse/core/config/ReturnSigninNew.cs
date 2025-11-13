using System;

namespace core.config
{
	// Token: 0x02001DFD RID: 7677
	public class ReturnSigninNew : XlsConfigBase<ReturnSigninNew, IReturnSigninNewInfo>
	{
		// Token: 0x170017ED RID: 6125
		// (get) Token: 0x0600E2B0 RID: 58032 RVA: 0x003DC117 File Offset: 0x003DA317
		public override string fileName
		{
			get
			{
				return "return_signin_new";
			}
		}

		// Token: 0x0600E2B1 RID: 58033 RVA: 0x003DC120 File Offset: 0x003DA320
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IReturnSigninNewInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IReturnSigninNewInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E2B2 RID: 58034 RVA: 0x003DC174 File Offset: 0x003DA374
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
