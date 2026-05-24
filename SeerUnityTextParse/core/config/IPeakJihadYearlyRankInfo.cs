using System;

namespace core.config
{
	// Token: 0x02002601 RID: 9729
	public class IPeakJihadYearlyRankInfo : IConfigItem
	{
		// Token: 0x17001EA7 RID: 7847
		// (get) Token: 0x06012CA8 RID: 76968 RVA: 0x00519220 File Offset: 0x00517420
		// (set) Token: 0x06012CA9 RID: 76969 RVA: 0x00519228 File Offset: 0x00517428
		public int id { get; set; }

		// Token: 0x17001EA8 RID: 7848
		// (get) Token: 0x06012CAA RID: 76970 RVA: 0x00519231 File Offset: 0x00517431
		// (set) Token: 0x06012CAB RID: 76971 RVA: 0x00519239 File Offset: 0x00517439
		public int playerID { get; set; }

		// Token: 0x17001EA9 RID: 7849
		// (get) Token: 0x06012CAC RID: 76972 RVA: 0x00519242 File Offset: 0x00517442
		// (set) Token: 0x06012CAD RID: 76973 RVA: 0x0051924A File Offset: 0x0051744A
		public int rank { get; set; }

		// Token: 0x17001EAA RID: 7850
		// (get) Token: 0x06012CAE RID: 76974 RVA: 0x00519253 File Offset: 0x00517453
		// (set) Token: 0x06012CAF RID: 76975 RVA: 0x0051925B File Offset: 0x0051745B
		public int score { get; set; }

		// Token: 0x06012CB0 RID: 76976 RVA: 0x00519264 File Offset: 0x00517464
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.playerID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rank = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.score = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
