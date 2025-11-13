using System;

namespace core.config
{
	// Token: 0x02001D63 RID: 7523
	public class HandbookBan : XlsConfigBase<HandbookBan, IHandbookBanInfo>
	{
		// Token: 0x1700155C RID: 5468
		// (get) Token: 0x0600DC5A RID: 56410 RVA: 0x003D43AF File Offset: 0x003D25AF
		public override string fileName
		{
			get
			{
				return "handbook_ban";
			}
		}

		// Token: 0x0600DC5B RID: 56411 RVA: 0x003D43B8 File Offset: 0x003D25B8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IHandbookBanInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IHandbookBanInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DC5C RID: 56412 RVA: 0x003D440C File Offset: 0x003D260C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
