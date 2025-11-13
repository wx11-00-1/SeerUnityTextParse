using System;

namespace core.config
{
	// Token: 0x02001DF3 RID: 7667
	public class Redbadge : XlsConfigBase<Redbadge, IRedbadgeInfo>
	{
		// Token: 0x170017C9 RID: 6089
		// (get) Token: 0x0600E254 RID: 57940 RVA: 0x003DB8A3 File Offset: 0x003D9AA3
		public override string fileName
		{
			get
			{
				return "redbadge";
			}
		}

		// Token: 0x0600E255 RID: 57941 RVA: 0x003DB8AC File Offset: 0x003D9AAC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IRedbadgeInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IRedbadgeInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E256 RID: 57942 RVA: 0x003DB900 File Offset: 0x003D9B00
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
