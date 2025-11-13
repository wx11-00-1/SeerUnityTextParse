using System;

namespace core.config.resistance
{
	// Token: 0x02001F30 RID: 7984
	public class IHurtItem
	{
		// Token: 0x17001BBD RID: 7101
		// (get) Token: 0x0600EF7C RID: 61308 RVA: 0x003F3A4C File Offset: 0x003F1C4C
		// (set) Token: 0x0600EF7D RID: 61309 RVA: 0x003F3A54 File Offset: 0x003F1C54
		public int level { get; set; }

		// Token: 0x17001BBE RID: 7102
		// (get) Token: 0x0600EF7E RID: 61310 RVA: 0x003F3A5D File Offset: 0x003F1C5D
		// (set) Token: 0x0600EF7F RID: 61311 RVA: 0x003F3A65 File Offset: 0x003F1C65
		public int need { get; set; }

		// Token: 0x17001BBF RID: 7103
		// (get) Token: 0x0600EF80 RID: 61312 RVA: 0x003F3A6E File Offset: 0x003F1C6E
		// (set) Token: 0x0600EF81 RID: 61313 RVA: 0x003F3A76 File Offset: 0x003F1C76
		public int present { get; set; }

		// Token: 0x0600EF82 RID: 61314 RVA: 0x003F3A7F File Offset: 0x003F1C7F
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.need = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.present = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
