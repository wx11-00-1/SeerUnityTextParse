using System;

namespace core.config
{
	// Token: 0x02001DF5 RID: 7669
	public class RedbadgeBisaifu : XlsConfigBase<RedbadgeBisaifu, IRedbadgeBisaifuInfo>
	{
		// Token: 0x170017D2 RID: 6098
		// (get) Token: 0x0600E26A RID: 57962 RVA: 0x003DBA33 File Offset: 0x003D9C33
		public override string fileName
		{
			get
			{
				return "redbadge_bisaifu";
			}
		}

		// Token: 0x0600E26B RID: 57963 RVA: 0x003DBA3C File Offset: 0x003D9C3C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IRedbadgeBisaifuInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IRedbadgeBisaifuInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E26C RID: 57964 RVA: 0x003DBA90 File Offset: 0x003D9C90
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
