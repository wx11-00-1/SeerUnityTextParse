using System;

namespace core.config
{
	// Token: 0x02001D64 RID: 7524
	public class IHandbookBanInfo : IConfigItem
	{
		// Token: 0x1700155D RID: 5469
		// (get) Token: 0x0600DC5E RID: 56414 RVA: 0x003D442C File Offset: 0x003D262C
		// (set) Token: 0x0600DC5F RID: 56415 RVA: 0x003D4434 File Offset: 0x003D2634
		public int details { get; set; }

		// Token: 0x1700155E RID: 5470
		// (get) Token: 0x0600DC60 RID: 56416 RVA: 0x003D443D File Offset: 0x003D263D
		// (set) Token: 0x0600DC61 RID: 56417 RVA: 0x003D4445 File Offset: 0x003D2645
		public int id { get; set; }

		// Token: 0x1700155F RID: 5471
		// (get) Token: 0x0600DC62 RID: 56418 RVA: 0x003D444E File Offset: 0x003D264E
		// (set) Token: 0x0600DC63 RID: 56419 RVA: 0x003D4456 File Offset: 0x003D2656
		public int type { get; set; }

		// Token: 0x0600DC64 RID: 56420 RVA: 0x003D445F File Offset: 0x003D265F
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.details = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
