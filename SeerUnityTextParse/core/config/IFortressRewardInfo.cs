using System;

namespace core.config
{
	// Token: 0x02001D58 RID: 7512
	public class IFortressRewardInfo : IConfigItem
	{
		// Token: 0x17001535 RID: 5429
		// (get) Token: 0x0600DBF6 RID: 56310 RVA: 0x003D3AF4 File Offset: 0x003D1CF4
		// (set) Token: 0x0600DBF7 RID: 56311 RVA: 0x003D3AFC File Offset: 0x003D1CFC
		public int[] reward { get; set; }

		// Token: 0x17001536 RID: 5430
		// (get) Token: 0x0600DBF8 RID: 56312 RVA: 0x003D3B05 File Offset: 0x003D1D05
		// (set) Token: 0x0600DBF9 RID: 56313 RVA: 0x003D3B0D File Offset: 0x003D1D0D
		public int endRank { get; set; }

		// Token: 0x17001537 RID: 5431
		// (get) Token: 0x0600DBFA RID: 56314 RVA: 0x003D3B16 File Offset: 0x003D1D16
		// (set) Token: 0x0600DBFB RID: 56315 RVA: 0x003D3B1E File Offset: 0x003D1D1E
		public int id { get; set; }

		// Token: 0x17001538 RID: 5432
		// (get) Token: 0x0600DBFC RID: 56316 RVA: 0x003D3B27 File Offset: 0x003D1D27
		// (set) Token: 0x0600DBFD RID: 56317 RVA: 0x003D3B2F File Offset: 0x003D1D2F
		public int startRank { get; set; }

		// Token: 0x17001539 RID: 5433
		// (get) Token: 0x0600DBFE RID: 56318 RVA: 0x003D3B38 File Offset: 0x003D1D38
		// (set) Token: 0x0600DBFF RID: 56319 RVA: 0x003D3B40 File Offset: 0x003D1D40
		public int type { get; set; }

		// Token: 0x0600DC00 RID: 56320 RVA: 0x003D3B4C File Offset: 0x003D1D4C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.endRank = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.reward = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.reward[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.startRank = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
