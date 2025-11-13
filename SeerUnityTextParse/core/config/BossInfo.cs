using System;

namespace core.config
{
	// Token: 0x02001CCB RID: 7371
	public class BossInfo : XlsConfigBase<BossInfo, IBossInfoInfo>
	{
		// Token: 0x170012C6 RID: 4806
		// (get) Token: 0x0600D5FE RID: 54782 RVA: 0x003CC5A8 File Offset: 0x003CA7A8
		public override string fileName
		{
			get
			{
				return "bossInfo";
			}
		}

		// Token: 0x0600D5FF RID: 54783 RVA: 0x003CC5B0 File Offset: 0x003CA7B0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBossInfoInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBossInfoInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D600 RID: 54784 RVA: 0x003CC604 File Offset: 0x003CA804
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
