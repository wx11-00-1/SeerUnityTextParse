using System;

namespace core.config.titanlode
{
	// Token: 0x02001F09 RID: 7945
	public class IRewardItem : IConfigItem
	{
		// Token: 0x17001B16 RID: 6934
		// (get) Token: 0x0600EDE0 RID: 60896 RVA: 0x003F1BDD File Offset: 0x003EFDDD
		// (set) Token: 0x0600EDE1 RID: 60897 RVA: 0x003F1BE5 File Offset: 0x003EFDE5
		public int id { get; set; }

		// Token: 0x17001B17 RID: 6935
		// (get) Token: 0x0600EDE2 RID: 60898 RVA: 0x003F1BEE File Offset: 0x003EFDEE
		// (set) Token: 0x0600EDE3 RID: 60899 RVA: 0x003F1BF6 File Offset: 0x003EFDF6
		public int realcnt { get; set; }

		// Token: 0x17001B18 RID: 6936
		// (get) Token: 0x0600EDE4 RID: 60900 RVA: 0x003F1BFF File Offset: 0x003EFDFF
		// (set) Token: 0x0600EDE5 RID: 60901 RVA: 0x003F1C07 File Offset: 0x003EFE07
		public int realid { get; set; }

		// Token: 0x17001B19 RID: 6937
		// (get) Token: 0x0600EDE6 RID: 60902 RVA: 0x003F1C10 File Offset: 0x003EFE10
		// (set) Token: 0x0600EDE7 RID: 60903 RVA: 0x003F1C18 File Offset: 0x003EFE18
		public int type { get; set; }

		// Token: 0x0600EDE8 RID: 60904 RVA: 0x003F1C21 File Offset: 0x003EFE21
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.realcnt = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.realid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
