using System;

namespace core.config
{
	// Token: 0x02001E32 RID: 7730
	public class ISPTstarInfo : IConfigItem
	{
		// Token: 0x170018D7 RID: 6359
		// (get) Token: 0x0600E4EE RID: 58606 RVA: 0x003DEFEC File Offset: 0x003DD1EC
		// (set) Token: 0x0600E4EF RID: 58607 RVA: 0x003DEFF4 File Offset: 0x003DD1F4
		public int achievementid { get; set; }

		// Token: 0x170018D8 RID: 6360
		// (get) Token: 0x0600E4F0 RID: 58608 RVA: 0x003DEFFD File Offset: 0x003DD1FD
		// (set) Token: 0x0600E4F1 RID: 58609 RVA: 0x003DF005 File Offset: 0x003DD205
		public int galaxyid { get; set; }

		// Token: 0x170018D9 RID: 6361
		// (get) Token: 0x0600E4F2 RID: 58610 RVA: 0x003DF00E File Offset: 0x003DD20E
		// (set) Token: 0x0600E4F3 RID: 58611 RVA: 0x003DF016 File Offset: 0x003DD216
		public int id { get; set; }

		// Token: 0x170018DA RID: 6362
		// (get) Token: 0x0600E4F4 RID: 58612 RVA: 0x003DF01F File Offset: 0x003DD21F
		// (set) Token: 0x0600E4F5 RID: 58613 RVA: 0x003DF027 File Offset: 0x003DD227
		public int level { get; set; }

		// Token: 0x170018DB RID: 6363
		// (get) Token: 0x0600E4F6 RID: 58614 RVA: 0x003DF030 File Offset: 0x003DD230
		// (set) Token: 0x0600E4F7 RID: 58615 RVA: 0x003DF038 File Offset: 0x003DD238
		public int rewardid { get; set; }

		// Token: 0x170018DC RID: 6364
		// (get) Token: 0x0600E4F8 RID: 58616 RVA: 0x003DF041 File Offset: 0x003DD241
		// (set) Token: 0x0600E4F9 RID: 58617 RVA: 0x003DF049 File Offset: 0x003DD249
		public int starcnt { get; set; }

		// Token: 0x0600E4FA RID: 58618 RVA: 0x003DF054 File Offset: 0x003DD254
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.achievementid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.galaxyid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rewardid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.starcnt = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
