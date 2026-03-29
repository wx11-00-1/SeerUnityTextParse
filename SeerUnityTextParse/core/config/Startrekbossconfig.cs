using System;

namespace core.config
{
	// Token: 0x02002388 RID: 9096
	public class Startrekbossconfig : XlsConfigBase<Startrekbossconfig, IStartrekbossconfigInfo>
	{
		// Token: 0x17001F89 RID: 8073
		// (get) Token: 0x060116A2 RID: 71330 RVA: 0x0049CC04 File Offset: 0x0049AE04
		public override string fileName
		{
			get
			{
				return "Startrekbossconfig";
			}
		}

		// Token: 0x060116A3 RID: 71331 RVA: 0x0049CC0C File Offset: 0x0049AE0C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStartrekbossconfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStartrekbossconfigInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x060116A4 RID: 71332 RVA: 0x0049CC60 File Offset: 0x0049AE60
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
