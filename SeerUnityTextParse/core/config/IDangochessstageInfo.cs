using System;

namespace core.config
{
	// Token: 0x02001F87 RID: 8071
	public class IDangochessstageInfo : IConfigItem
	{
		// Token: 0x17001606 RID: 5638
		// (get) Token: 0x0600F106 RID: 61702 RVA: 0x00433C00 File Offset: 0x00431E00
		// (set) Token: 0x0600F107 RID: 61703 RVA: 0x00433C08 File Offset: 0x00431E08
		public int chapterid { get; set; }

		// Token: 0x17001607 RID: 5639
		// (get) Token: 0x0600F108 RID: 61704 RVA: 0x00433C11 File Offset: 0x00431E11
		// (set) Token: 0x0600F109 RID: 61705 RVA: 0x00433C19 File Offset: 0x00431E19
		public int hangid { get; set; }

		// Token: 0x17001608 RID: 5640
		// (get) Token: 0x0600F10A RID: 61706 RVA: 0x00433C22 File Offset: 0x00431E22
		// (set) Token: 0x0600F10B RID: 61707 RVA: 0x00433C2A File Offset: 0x00431E2A
		public int id { get; set; }

		// Token: 0x17001609 RID: 5641
		// (get) Token: 0x0600F10C RID: 61708 RVA: 0x00433C33 File Offset: 0x00431E33
		// (set) Token: 0x0600F10D RID: 61709 RVA: 0x00433C3B File Offset: 0x00431E3B
		public int lieid1 { get; set; }

		// Token: 0x1700160A RID: 5642
		// (get) Token: 0x0600F10E RID: 61710 RVA: 0x00433C44 File Offset: 0x00431E44
		// (set) Token: 0x0600F10F RID: 61711 RVA: 0x00433C4C File Offset: 0x00431E4C
		public int lieid2 { get; set; }

		// Token: 0x1700160B RID: 5643
		// (get) Token: 0x0600F110 RID: 61712 RVA: 0x00433C55 File Offset: 0x00431E55
		// (set) Token: 0x0600F111 RID: 61713 RVA: 0x00433C5D File Offset: 0x00431E5D
		public int lieid3 { get; set; }

		// Token: 0x1700160C RID: 5644
		// (get) Token: 0x0600F112 RID: 61714 RVA: 0x00433C66 File Offset: 0x00431E66
		// (set) Token: 0x0600F113 RID: 61715 RVA: 0x00433C6E File Offset: 0x00431E6E
		public int lieid4 { get; set; }

		// Token: 0x1700160D RID: 5645
		// (get) Token: 0x0600F114 RID: 61716 RVA: 0x00433C77 File Offset: 0x00431E77
		// (set) Token: 0x0600F115 RID: 61717 RVA: 0x00433C7F File Offset: 0x00431E7F
		public int lieid5 { get; set; }

		// Token: 0x1700160E RID: 5646
		// (get) Token: 0x0600F116 RID: 61718 RVA: 0x00433C88 File Offset: 0x00431E88
		// (set) Token: 0x0600F117 RID: 61719 RVA: 0x00433C90 File Offset: 0x00431E90
		public int lieid6 { get; set; }

		// Token: 0x1700160F RID: 5647
		// (get) Token: 0x0600F118 RID: 61720 RVA: 0x00433C99 File Offset: 0x00431E99
		// (set) Token: 0x0600F119 RID: 61721 RVA: 0x00433CA1 File Offset: 0x00431EA1
		public int lieid7 { get; set; }

		// Token: 0x17001610 RID: 5648
		// (get) Token: 0x0600F11A RID: 61722 RVA: 0x00433CAA File Offset: 0x00431EAA
		// (set) Token: 0x0600F11B RID: 61723 RVA: 0x00433CB2 File Offset: 0x00431EB2
		public int lieid8 { get; set; }

		// Token: 0x17001611 RID: 5649
		// (get) Token: 0x0600F11C RID: 61724 RVA: 0x00433CBB File Offset: 0x00431EBB
		// (set) Token: 0x0600F11D RID: 61725 RVA: 0x00433CC3 File Offset: 0x00431EC3
		public int lieid9 { get; set; }

		// Token: 0x17001612 RID: 5650
		// (get) Token: 0x0600F11E RID: 61726 RVA: 0x00433CCC File Offset: 0x00431ECC
		// (set) Token: 0x0600F11F RID: 61727 RVA: 0x00433CD4 File Offset: 0x00431ED4
		public int stageid { get; set; }

		// Token: 0x0600F120 RID: 61728 RVA: 0x00433CE0 File Offset: 0x00431EE0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.chapterid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.hangid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.lieid1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.lieid2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.lieid3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.lieid4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.lieid5 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.lieid6 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.lieid7 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.lieid8 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.lieid9 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.stageid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
