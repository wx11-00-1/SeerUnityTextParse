using System;

namespace core.config.aimat
{
	// Token: 0x02002075 RID: 8309
	public class IItemItem : IConfigItem
	{
		// Token: 0x1700211E RID: 8478
		// (get) Token: 0x0600FDB9 RID: 64953 RVA: 0x004036F4 File Offset: 0x004018F4
		// (set) Token: 0x0600FDBA RID: 64954 RVA: 0x004036FC File Offset: 0x004018FC
		public int cloths { get; set; }

		// Token: 0x1700211F RID: 8479
		// (get) Token: 0x0600FDBB RID: 64955 RVA: 0x00403705 File Offset: 0x00401905
		// (set) Token: 0x0600FDBC RID: 64956 RVA: 0x0040370D File Offset: 0x0040190D
		public int id { get; set; }

		// Token: 0x17002120 RID: 8480
		// (get) Token: 0x0600FDBD RID: 64957 RVA: 0x00403716 File Offset: 0x00401916
		// (set) Token: 0x0600FDBE RID: 64958 RVA: 0x0040371E File Offset: 0x0040191E
		public int state { get; set; }

		// Token: 0x17002121 RID: 8481
		// (get) Token: 0x0600FDBF RID: 64959 RVA: 0x00403727 File Offset: 0x00401927
		// (set) Token: 0x0600FDC0 RID: 64960 RVA: 0x0040372F File Offset: 0x0040192F
		public int type { get; set; }

		// Token: 0x0600FDC1 RID: 64961 RVA: 0x00403738 File Offset: 0x00401938
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.cloths = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.state = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
