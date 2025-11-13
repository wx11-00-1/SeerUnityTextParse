using System;

namespace core.config
{
	// Token: 0x02001D52 RID: 7506
	public class IFightTestMonsterConfigInfo : IConfigItem
	{
		// Token: 0x17001511 RID: 5393
		// (get) Token: 0x0600DBA2 RID: 56226 RVA: 0x003D3340 File Offset: 0x003D1540
		// (set) Token: 0x0600DBA3 RID: 56227 RVA: 0x003D3348 File Offset: 0x003D1548
		public int[] baseData { get; set; }

		// Token: 0x17001512 RID: 5394
		// (get) Token: 0x0600DBA4 RID: 56228 RVA: 0x003D3351 File Offset: 0x003D1551
		// (set) Token: 0x0600DBA5 RID: 56229 RVA: 0x003D3359 File Offset: 0x003D1559
		public int[] extraData { get; set; }

		// Token: 0x17001513 RID: 5395
		// (get) Token: 0x0600DBA6 RID: 56230 RVA: 0x003D3362 File Offset: 0x003D1562
		// (set) Token: 0x0600DBA7 RID: 56231 RVA: 0x003D336A File Offset: 0x003D156A
		public int[] mintmark { get; set; }

		// Token: 0x17001514 RID: 5396
		// (get) Token: 0x0600DBA8 RID: 56232 RVA: 0x003D3373 File Offset: 0x003D1573
		// (set) Token: 0x0600DBA9 RID: 56233 RVA: 0x003D337B File Offset: 0x003D157B
		public int[] mintmarkData { get; set; }

		// Token: 0x17001515 RID: 5397
		// (get) Token: 0x0600DBAA RID: 56234 RVA: 0x003D3384 File Offset: 0x003D1584
		// (set) Token: 0x0600DBAB RID: 56235 RVA: 0x003D338C File Offset: 0x003D158C
		public int[] monsterLearning { get; set; }

		// Token: 0x17001516 RID: 5398
		// (get) Token: 0x0600DBAC RID: 56236 RVA: 0x003D3395 File Offset: 0x003D1595
		// (set) Token: 0x0600DBAD RID: 56237 RVA: 0x003D339D File Offset: 0x003D159D
		public int[] monsterMove { get; set; }

		// Token: 0x17001517 RID: 5399
		// (get) Token: 0x0600DBAE RID: 56238 RVA: 0x003D33A6 File Offset: 0x003D15A6
		// (set) Token: 0x0600DBAF RID: 56239 RVA: 0x003D33AE File Offset: 0x003D15AE
		public int id { get; set; }

		// Token: 0x17001518 RID: 5400
		// (get) Token: 0x0600DBB0 RID: 56240 RVA: 0x003D33B7 File Offset: 0x003D15B7
		// (set) Token: 0x0600DBB1 RID: 56241 RVA: 0x003D33BF File Offset: 0x003D15BF
		public int monsterCharacter { get; set; }

		// Token: 0x17001519 RID: 5401
		// (get) Token: 0x0600DBB2 RID: 56242 RVA: 0x003D33C8 File Offset: 0x003D15C8
		// (set) Token: 0x0600DBB3 RID: 56243 RVA: 0x003D33D0 File Offset: 0x003D15D0
		public int monsterEffect_id { get; set; }

		// Token: 0x1700151A RID: 5402
		// (get) Token: 0x0600DBB4 RID: 56244 RVA: 0x003D33D9 File Offset: 0x003D15D9
		// (set) Token: 0x0600DBB5 RID: 56245 RVA: 0x003D33E1 File Offset: 0x003D15E1
		public int monsterId { get; set; }

		// Token: 0x1700151B RID: 5403
		// (get) Token: 0x0600DBB6 RID: 56246 RVA: 0x003D33EA File Offset: 0x003D15EA
		// (set) Token: 0x0600DBB7 RID: 56247 RVA: 0x003D33F2 File Offset: 0x003D15F2
		public int monsterLv { get; set; }

		// Token: 0x1700151C RID: 5404
		// (get) Token: 0x0600DBB8 RID: 56248 RVA: 0x003D33FB File Offset: 0x003D15FB
		// (set) Token: 0x0600DBB9 RID: 56249 RVA: 0x003D3403 File Offset: 0x003D1603
		public int monsterNature { get; set; }

		// Token: 0x1700151D RID: 5405
		// (get) Token: 0x0600DBBA RID: 56250 RVA: 0x003D340C File Offset: 0x003D160C
		// (set) Token: 0x0600DBBB RID: 56251 RVA: 0x003D3414 File Offset: 0x003D1614
		public int monsterStrength { get; set; }

		// Token: 0x1700151E RID: 5406
		// (get) Token: 0x0600DBBC RID: 56252 RVA: 0x003D341D File Offset: 0x003D161D
		// (set) Token: 0x0600DBBD RID: 56253 RVA: 0x003D3425 File Offset: 0x003D1625
		public int monsterTalent { get; set; }

		// Token: 0x0600DBBE RID: 56254 RVA: 0x003D3430 File Offset: 0x003D1630
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
				this.mintmark = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					this.mintmark[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.mintmarkData = new int[num4];
				for (int l = 0; l < num4; l++)
				{
					this.mintmarkData[l] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.monsterCharacter = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monsterEffect_id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monsterId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num5 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.monsterLearning = new int[num5];
				for (int m = 0; m < num5; m++)
				{
					this.monsterLearning[m] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.monsterLv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num6 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.monsterMove = new int[num6];
				for (int n = 0; n < num6; n++)
				{
					this.monsterMove[n] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.monsterNature = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monsterStrength = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monsterTalent = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
