using System;

namespace core.config
{
	// Token: 0x02001E3B RID: 7739
	public class Startrekbossfight : XlsConfigBase<Startrekbossfight, IStartrekbossfightInfo>
	{
		// Token: 0x17001906 RID: 6406
		// (get) Token: 0x0600E55E RID: 58718 RVA: 0x003DF8CB File Offset: 0x003DDACB
		public override string fileName
		{
			get
			{
				return "Startrekbossfight";
			}
		}

		// Token: 0x0600E55F RID: 58719 RVA: 0x003DF8D4 File Offset: 0x003DDAD4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStartrekbossfightInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStartrekbossfightInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E560 RID: 58720 RVA: 0x003DF928 File Offset: 0x003DDB28
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
