using System;

namespace core.config.bossEffectIcon
{
	// Token: 0x02002060 RID: 8288
	public class IBossEffectItem
	{
		// Token: 0x170020E9 RID: 8425
		// (get) Token: 0x0600FD25 RID: 64805 RVA: 0x00402C80 File Offset: 0x00400E80
		// (set) Token: 0x0600FD26 RID: 64806 RVA: 0x00402C88 File Offset: 0x00400E88
		public string Args { get; set; }

		// Token: 0x170020EA RID: 8426
		// (get) Token: 0x0600FD27 RID: 64807 RVA: 0x00402C91 File Offset: 0x00400E91
		// (set) Token: 0x0600FD28 RID: 64808 RVA: 0x00402C99 File Offset: 0x00400E99
		public string tips { get; set; }

		// Token: 0x170020EB RID: 8427
		// (get) Token: 0x0600FD29 RID: 64809 RVA: 0x00402CA2 File Offset: 0x00400EA2
		// (set) Token: 0x0600FD2A RID: 64810 RVA: 0x00402CAA File Offset: 0x00400EAA
		public int Eid { get; set; }

		// Token: 0x170020EC RID: 8428
		// (get) Token: 0x0600FD2B RID: 64811 RVA: 0x00402CB3 File Offset: 0x00400EB3
		// (set) Token: 0x0600FD2C RID: 64812 RVA: 0x00402CBB File Offset: 0x00400EBB
		public int iconId { get; set; }

		// Token: 0x170020ED RID: 8429
		// (get) Token: 0x0600FD2D RID: 64813 RVA: 0x00402CC4 File Offset: 0x00400EC4
		// (set) Token: 0x0600FD2E RID: 64814 RVA: 0x00402CCC File Offset: 0x00400ECC
		public int rows { get; set; }

		// Token: 0x170020EE RID: 8430
		// (get) Token: 0x0600FD2F RID: 64815 RVA: 0x00402CD5 File Offset: 0x00400ED5
		// (set) Token: 0x0600FD30 RID: 64816 RVA: 0x00402CDD File Offset: 0x00400EDD
		public int sort { get; set; }

		// Token: 0x0600FD31 RID: 64817 RVA: 0x00402CE8 File Offset: 0x00400EE8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Args = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Eid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.iconId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rows = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.tips = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
