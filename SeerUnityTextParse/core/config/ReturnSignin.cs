using System;

namespace core.config
{
	// Token: 0x02001DFB RID: 7675
	public class ReturnSignin : XlsConfigBase<ReturnSignin, IReturnSigninInfo>
	{
		// Token: 0x170017E5 RID: 6117
		// (get) Token: 0x0600E29C RID: 58012 RVA: 0x003DBEC3 File Offset: 0x003DA0C3
		public override string fileName
		{
			get
			{
				return "return_signin";
			}
		}

		// Token: 0x0600E29D RID: 58013 RVA: 0x003DBECC File Offset: 0x003DA0CC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IReturnSigninInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IReturnSigninInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E29E RID: 58014 RVA: 0x003DBF20 File Offset: 0x003DA120
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
