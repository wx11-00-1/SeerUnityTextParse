using System;

namespace core.config
{
	// Token: 0x020026B3 RID: 9907
	public class IAbyssFisheryLevelInfo : IConfigItem
	{
		// Token: 0x1700175C RID: 5980
		// (get) Token: 0x06013791 RID: 79761 RVA: 0x005839C8 File Offset: 0x00581BC8
		// (set) Token: 0x06013792 RID: 79762 RVA: 0x005839D0 File Offset: 0x00581BD0
		public int exp { get; set; }

		// Token: 0x1700175D RID: 5981
		// (get) Token: 0x06013793 RID: 79763 RVA: 0x005839D9 File Offset: 0x00581BD9
		// (set) Token: 0x06013794 RID: 79764 RVA: 0x005839E1 File Offset: 0x00581BE1
		public int id { get; set; }

		// Token: 0x1700175E RID: 5982
		// (get) Token: 0x06013795 RID: 79765 RVA: 0x005839EA File Offset: 0x00581BEA
		// (set) Token: 0x06013796 RID: 79766 RVA: 0x005839F2 File Offset: 0x00581BF2
		public int rank { get; set; }

		// Token: 0x1700175F RID: 5983
		// (get) Token: 0x06013797 RID: 79767 RVA: 0x005839FB File Offset: 0x00581BFB
		// (set) Token: 0x06013798 RID: 79768 RVA: 0x00583A03 File Offset: 0x00581C03
		public int rare { get; set; }

		// Token: 0x17001760 RID: 5984
		// (get) Token: 0x06013799 RID: 79769 RVA: 0x00583A0C File Offset: 0x00581C0C
		// (set) Token: 0x0601379A RID: 79770 RVA: 0x00583A14 File Offset: 0x00581C14
		public int star { get; set; }

		// Token: 0x17001761 RID: 5985
		// (get) Token: 0x0601379B RID: 79771 RVA: 0x00583A1D File Offset: 0x00581C1D
		// (set) Token: 0x0601379C RID: 79772 RVA: 0x00583A25 File Offset: 0x00581C25
		public int value { get; set; }

		// Token: 0x0601379D RID: 79773 RVA: 0x00583A30 File Offset: 0x00581C30
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.exp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rank = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rare = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.star = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
