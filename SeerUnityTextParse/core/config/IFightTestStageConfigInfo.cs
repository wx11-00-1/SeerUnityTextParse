using System;

namespace core.config
{
	// Token: 0x02001D54 RID: 7508
	public class IFightTestStageConfigInfo : IConfigItem
	{
		// Token: 0x17001520 RID: 5408
		// (get) Token: 0x0600DBC4 RID: 56260 RVA: 0x003D3698 File Offset: 0x003D1898
		// (set) Token: 0x0600DBC5 RID: 56261 RVA: 0x003D36A0 File Offset: 0x003D18A0
		public string bossIntro { get; set; }

		// Token: 0x17001521 RID: 5409
		// (get) Token: 0x0600DBC6 RID: 56262 RVA: 0x003D36A9 File Offset: 0x003D18A9
		// (set) Token: 0x0600DBC7 RID: 56263 RVA: 0x003D36B1 File Offset: 0x003D18B1
		public int[] fightBossIndexes { get; set; }

		// Token: 0x17001522 RID: 5410
		// (get) Token: 0x0600DBC8 RID: 56264 RVA: 0x003D36BA File Offset: 0x003D18BA
		// (set) Token: 0x0600DBC9 RID: 56265 RVA: 0x003D36C2 File Offset: 0x003D18C2
		public int[] fightMonsterIndexs { get; set; }

		// Token: 0x17001523 RID: 5411
		// (get) Token: 0x0600DBCA RID: 56266 RVA: 0x003D36CB File Offset: 0x003D18CB
		// (set) Token: 0x0600DBCB RID: 56267 RVA: 0x003D36D3 File Offset: 0x003D18D3
		public int[] firstReward { get; set; }

		// Token: 0x17001524 RID: 5412
		// (get) Token: 0x0600DBCC RID: 56268 RVA: 0x003D36DC File Offset: 0x003D18DC
		// (set) Token: 0x0600DBCD RID: 56269 RVA: 0x003D36E4 File Offset: 0x003D18E4
		public int[] reward { get; set; }

		// Token: 0x17001525 RID: 5413
		// (get) Token: 0x0600DBCE RID: 56270 RVA: 0x003D36ED File Offset: 0x003D18ED
		// (set) Token: 0x0600DBCF RID: 56271 RVA: 0x003D36F5 File Offset: 0x003D18F5
		public int equip { get; set; }

		// Token: 0x17001526 RID: 5414
		// (get) Token: 0x0600DBD0 RID: 56272 RVA: 0x003D36FE File Offset: 0x003D18FE
		// (set) Token: 0x0600DBD1 RID: 56273 RVA: 0x003D3706 File Offset: 0x003D1906
		public int id { get; set; }

		// Token: 0x17001527 RID: 5415
		// (get) Token: 0x0600DBD2 RID: 56274 RVA: 0x003D370F File Offset: 0x003D190F
		// (set) Token: 0x0600DBD3 RID: 56275 RVA: 0x003D3717 File Offset: 0x003D1917
		public int NeedMonNum { get; set; }

		// Token: 0x17001528 RID: 5416
		// (get) Token: 0x0600DBD4 RID: 56276 RVA: 0x003D3720 File Offset: 0x003D1920
		// (set) Token: 0x0600DBD5 RID: 56277 RVA: 0x003D3728 File Offset: 0x003D1928
		public int order { get; set; }

		// Token: 0x17001529 RID: 5417
		// (get) Token: 0x0600DBD6 RID: 56278 RVA: 0x003D3731 File Offset: 0x003D1931
		// (set) Token: 0x0600DBD7 RID: 56279 RVA: 0x003D3739 File Offset: 0x003D1939
		public int StageType { get; set; }

		// Token: 0x1700152A RID: 5418
		// (get) Token: 0x0600DBD8 RID: 56280 RVA: 0x003D3742 File Offset: 0x003D1942
		// (set) Token: 0x0600DBD9 RID: 56281 RVA: 0x003D374A File Offset: 0x003D194A
		public int title { get; set; }

		// Token: 0x0600DBDA RID: 56282 RVA: 0x003D3754 File Offset: 0x003D1954
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.NeedMonNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.StageType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.bossIntro = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.equip = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.fightBossIndexes = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.fightBossIndexes[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.fightMonsterIndexs = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.fightMonsterIndexs[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.firstReward = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					this.firstReward[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.order = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.reward = new int[num4];
				for (int l = 0; l < num4; l++)
				{
					this.reward[l] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.title = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
