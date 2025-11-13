using System;

namespace core.config
{
	// Token: 0x02001D46 RID: 7494
	public class IExplorationRewardInfo : IConfigItem
	{
		// Token: 0x170014DE RID: 5342
		// (get) Token: 0x0600DB24 RID: 56100 RVA: 0x003D28C8 File Offset: 0x003D0AC8
		// (set) Token: 0x0600DB25 RID: 56101 RVA: 0x003D28D0 File Offset: 0x003D0AD0
		public int @class { get; set; }

		// Token: 0x170014DF RID: 5343
		// (get) Token: 0x0600DB26 RID: 56102 RVA: 0x003D28D9 File Offset: 0x003D0AD9
		// (set) Token: 0x0600DB27 RID: 56103 RVA: 0x003D28E1 File Offset: 0x003D0AE1
		public int currency { get; set; }

		// Token: 0x170014E0 RID: 5344
		// (get) Token: 0x0600DB28 RID: 56104 RVA: 0x003D28EA File Offset: 0x003D0AEA
		// (set) Token: 0x0600DB29 RID: 56105 RVA: 0x003D28F2 File Offset: 0x003D0AF2
		public int currencynum { get; set; }

		// Token: 0x170014E1 RID: 5345
		// (get) Token: 0x0600DB2A RID: 56106 RVA: 0x003D28FB File Offset: 0x003D0AFB
		// (set) Token: 0x0600DB2B RID: 56107 RVA: 0x003D2903 File Offset: 0x003D0B03
		public int id { get; set; }

		// Token: 0x170014E2 RID: 5346
		// (get) Token: 0x0600DB2C RID: 56108 RVA: 0x003D290C File Offset: 0x003D0B0C
		// (set) Token: 0x0600DB2D RID: 56109 RVA: 0x003D2914 File Offset: 0x003D0B14
		public int item { get; set; }

		// Token: 0x170014E3 RID: 5347
		// (get) Token: 0x0600DB2E RID: 56110 RVA: 0x003D291D File Offset: 0x003D0B1D
		// (set) Token: 0x0600DB2F RID: 56111 RVA: 0x003D2925 File Offset: 0x003D0B25
		public int limit { get; set; }

		// Token: 0x170014E4 RID: 5348
		// (get) Token: 0x0600DB30 RID: 56112 RVA: 0x003D292E File Offset: 0x003D0B2E
		// (set) Token: 0x0600DB31 RID: 56113 RVA: 0x003D2936 File Offset: 0x003D0B36
		public int number { get; set; }

		// Token: 0x170014E5 RID: 5349
		// (get) Token: 0x0600DB32 RID: 56114 RVA: 0x003D293F File Offset: 0x003D0B3F
		// (set) Token: 0x0600DB33 RID: 56115 RVA: 0x003D2947 File Offset: 0x003D0B47
		public int sort { get; set; }

		// Token: 0x170014E6 RID: 5350
		// (get) Token: 0x0600DB34 RID: 56116 RVA: 0x003D2950 File Offset: 0x003D0B50
		// (set) Token: 0x0600DB35 RID: 56117 RVA: 0x003D2958 File Offset: 0x003D0B58
		public int starting { get; set; }

		// Token: 0x170014E7 RID: 5351
		// (get) Token: 0x0600DB36 RID: 56118 RVA: 0x003D2961 File Offset: 0x003D0B61
		// (set) Token: 0x0600DB37 RID: 56119 RVA: 0x003D2969 File Offset: 0x003D0B69
		public int type { get; set; }

		// Token: 0x170014E8 RID: 5352
		// (get) Token: 0x0600DB38 RID: 56120 RVA: 0x003D2972 File Offset: 0x003D0B72
		// (set) Token: 0x0600DB39 RID: 56121 RVA: 0x003D297A File Offset: 0x003D0B7A
		public int user_info { get; set; }

		// Token: 0x0600DB3A RID: 56122 RVA: 0x003D2984 File Offset: 0x003D0B84
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.@class = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.currency = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.currencynum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.item = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.limit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.number = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.starting = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.user_info = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
