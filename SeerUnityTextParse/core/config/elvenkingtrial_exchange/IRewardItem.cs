using System;

namespace core.config.elvenkingtrial_exchange
{
	// Token: 0x0200204D RID: 8269
	public class IRewardItem : IConfigItem
	{
		// Token: 0x170020AE RID: 8366
		// (get) Token: 0x0600FC89 RID: 64649 RVA: 0x0040205E File Offset: 0x0040025E
		// (set) Token: 0x0600FC8A RID: 64650 RVA: 0x00402066 File Offset: 0x00400266
		public int id { get; set; }

		// Token: 0x170020AF RID: 8367
		// (get) Token: 0x0600FC8B RID: 64651 RVA: 0x0040206F File Offset: 0x0040026F
		// (set) Token: 0x0600FC8C RID: 64652 RVA: 0x00402077 File Offset: 0x00400277
		public int realcnt { get; set; }

		// Token: 0x170020B0 RID: 8368
		// (get) Token: 0x0600FC8D RID: 64653 RVA: 0x00402080 File Offset: 0x00400280
		// (set) Token: 0x0600FC8E RID: 64654 RVA: 0x00402088 File Offset: 0x00400288
		public int realid { get; set; }

		// Token: 0x0600FC8F RID: 64655 RVA: 0x00402091 File Offset: 0x00400291
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.realcnt = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.realid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
