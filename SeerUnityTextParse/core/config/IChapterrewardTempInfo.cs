using System;

namespace core.config
{
	// Token: 0x02001CF2 RID: 7410
	public class IChapterrewardTempInfo : IConfigItem
	{
		// Token: 0x17001366 RID: 4966
		// (get) Token: 0x0600D78C RID: 55180 RVA: 0x003CE4F0 File Offset: 0x003CC6F0
		// (set) Token: 0x0600D78D RID: 55181 RVA: 0x003CE4F8 File Offset: 0x003CC6F8
		public string item { get; set; }

		// Token: 0x17001367 RID: 4967
		// (get) Token: 0x0600D78E RID: 55182 RVA: 0x003CE501 File Offset: 0x003CC701
		// (set) Token: 0x0600D78F RID: 55183 RVA: 0x003CE509 File Offset: 0x003CC709
		public int chapterid { get; set; }

		// Token: 0x17001368 RID: 4968
		// (get) Token: 0x0600D790 RID: 55184 RVA: 0x003CE512 File Offset: 0x003CC712
		// (set) Token: 0x0600D791 RID: 55185 RVA: 0x003CE51A File Offset: 0x003CC71A
		public int id { get; set; }

		// Token: 0x17001369 RID: 4969
		// (get) Token: 0x0600D792 RID: 55186 RVA: 0x003CE523 File Offset: 0x003CC723
		// (set) Token: 0x0600D793 RID: 55187 RVA: 0x003CE52B File Offset: 0x003CC72B
		public int open { get; set; }

		// Token: 0x1700136A RID: 4970
		// (get) Token: 0x0600D794 RID: 55188 RVA: 0x003CE534 File Offset: 0x003CC734
		// (set) Token: 0x0600D795 RID: 55189 RVA: 0x003CE53C File Offset: 0x003CC73C
		public int order { get; set; }

		// Token: 0x1700136B RID: 4971
		// (get) Token: 0x0600D796 RID: 55190 RVA: 0x003CE545 File Offset: 0x003CC745
		// (set) Token: 0x0600D797 RID: 55191 RVA: 0x003CE54D File Offset: 0x003CC74D
		public int param { get; set; }

		// Token: 0x0600D798 RID: 55192 RVA: 0x003CE558 File Offset: 0x003CC758
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.chapterid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.item = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.open = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.order = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.param = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
