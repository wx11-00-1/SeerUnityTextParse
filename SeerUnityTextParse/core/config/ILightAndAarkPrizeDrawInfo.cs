using System;

namespace core.config
{
	// Token: 0x02001D78 RID: 7544
	public class ILightAndAarkPrizeDrawInfo : IConfigItem
	{
		// Token: 0x170015A3 RID: 5539
		// (get) Token: 0x0600DD12 RID: 56594 RVA: 0x003D5198 File Offset: 0x003D3398
		// (set) Token: 0x0600DD13 RID: 56595 RVA: 0x003D51A0 File Offset: 0x003D33A0
		public int id { get; set; }

		// Token: 0x170015A4 RID: 5540
		// (get) Token: 0x0600DD14 RID: 56596 RVA: 0x003D51A9 File Offset: 0x003D33A9
		// (set) Token: 0x0600DD15 RID: 56597 RVA: 0x003D51B1 File Offset: 0x003D33B1
		public int monId { get; set; }

		// Token: 0x170015A5 RID: 5541
		// (get) Token: 0x0600DD16 RID: 56598 RVA: 0x003D51BA File Offset: 0x003D33BA
		// (set) Token: 0x0600DD17 RID: 56599 RVA: 0x003D51C2 File Offset: 0x003D33C2
		public int productID { get; set; }

		// Token: 0x170015A6 RID: 5542
		// (get) Token: 0x0600DD18 RID: 56600 RVA: 0x003D51CB File Offset: 0x003D33CB
		// (set) Token: 0x0600DD19 RID: 56601 RVA: 0x003D51D3 File Offset: 0x003D33D3
		public int type { get; set; }

		// Token: 0x0600DD1A RID: 56602 RVA: 0x003D51DC File Offset: 0x003D33DC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.productID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
