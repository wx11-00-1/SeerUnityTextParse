using System;

namespace core.config
{
	// Token: 0x0200290D RID: 10509
	public class IPvpCostModeVotePriceInfo : IConfigItem
	{
		// Token: 0x1700225C RID: 8796
		// (get) Token: 0x06015245 RID: 86597 RVA: 0x005A3A6C File Offset: 0x005A1C6C
		// (set) Token: 0x06015246 RID: 86598 RVA: 0x005A3A74 File Offset: 0x005A1C74
		public int id { get; set; }

		// Token: 0x1700225D RID: 8797
		// (get) Token: 0x06015247 RID: 86599 RVA: 0x005A3A7D File Offset: 0x005A1C7D
		// (set) Token: 0x06015248 RID: 86600 RVA: 0x005A3A85 File Offset: 0x005A1C85
		public int price { get; set; }

		// Token: 0x1700225E RID: 8798
		// (get) Token: 0x06015249 RID: 86601 RVA: 0x005A3A8E File Offset: 0x005A1C8E
		// (set) Token: 0x0601524A RID: 86602 RVA: 0x005A3A96 File Offset: 0x005A1C96
		public int rank { get; set; }

		// Token: 0x0601524B RID: 86603 RVA: 0x005A3A9F File Offset: 0x005A1C9F
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rank = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
