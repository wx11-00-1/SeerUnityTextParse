using System;

namespace core.config
{
	// Token: 0x02001D50 RID: 7504
	public class IFightTestBossConfigInfo : IConfigItem
	{
		// Token: 0x17001509 RID: 5385
		// (get) Token: 0x0600DB8E RID: 56206 RVA: 0x003D3120 File Offset: 0x003D1320
		// (set) Token: 0x0600DB8F RID: 56207 RVA: 0x003D3128 File Offset: 0x003D1328
		public int[] baseData { get; set; }

		// Token: 0x1700150A RID: 5386
		// (get) Token: 0x0600DB90 RID: 56208 RVA: 0x003D3131 File Offset: 0x003D1331
		// (set) Token: 0x0600DB91 RID: 56209 RVA: 0x003D3139 File Offset: 0x003D1339
		public int[] extraData { get; set; }

		// Token: 0x1700150B RID: 5387
		// (get) Token: 0x0600DB92 RID: 56210 RVA: 0x003D3142 File Offset: 0x003D1342
		// (set) Token: 0x0600DB93 RID: 56211 RVA: 0x003D314A File Offset: 0x003D134A
		public int[] mintmarkData { get; set; }

		// Token: 0x1700150C RID: 5388
		// (get) Token: 0x0600DB94 RID: 56212 RVA: 0x003D3153 File Offset: 0x003D1353
		// (set) Token: 0x0600DB95 RID: 56213 RVA: 0x003D315B File Offset: 0x003D135B
		public int[] monsterMove { get; set; }

		// Token: 0x1700150D RID: 5389
		// (get) Token: 0x0600DB96 RID: 56214 RVA: 0x003D3164 File Offset: 0x003D1364
		// (set) Token: 0x0600DB97 RID: 56215 RVA: 0x003D316C File Offset: 0x003D136C
		public int id { get; set; }

		// Token: 0x1700150E RID: 5390
		// (get) Token: 0x0600DB98 RID: 56216 RVA: 0x003D3175 File Offset: 0x003D1375
		// (set) Token: 0x0600DB99 RID: 56217 RVA: 0x003D317D File Offset: 0x003D137D
		public int monsterEffect_id { get; set; }

		// Token: 0x1700150F RID: 5391
		// (get) Token: 0x0600DB9A RID: 56218 RVA: 0x003D3186 File Offset: 0x003D1386
		// (set) Token: 0x0600DB9B RID: 56219 RVA: 0x003D318E File Offset: 0x003D138E
		public int monsterId { get; set; }

		// Token: 0x0600DB9C RID: 56220 RVA: 0x003D3198 File Offset: 0x003D1398
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.baseData = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.baseData[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.extraData = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.extraData[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.mintmarkData = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					this.mintmarkData[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.monsterEffect_id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monsterId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.monsterMove = new int[num4];
				for (int l = 0; l < num4; l++)
				{
					this.monsterMove[l] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
