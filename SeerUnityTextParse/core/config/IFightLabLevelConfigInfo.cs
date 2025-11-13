using System;

namespace core.config
{
	// Token: 0x02001D4C RID: 7500
	public class IFightLabLevelConfigInfo : IConfigItem
	{
		// Token: 0x170014F9 RID: 5369
		// (get) Token: 0x0600DB66 RID: 56166 RVA: 0x003D2D84 File Offset: 0x003D0F84
		// (set) Token: 0x0600DB67 RID: 56167 RVA: 0x003D2D8C File Offset: 0x003D0F8C
		public string bossIntro { get; set; }

		// Token: 0x170014FA RID: 5370
		// (get) Token: 0x0600DB68 RID: 56168 RVA: 0x003D2D95 File Offset: 0x003D0F95
		// (set) Token: 0x0600DB69 RID: 56169 RVA: 0x003D2D9D File Offset: 0x003D0F9D
		public string firstRewardTxt { get; set; }

		// Token: 0x170014FB RID: 5371
		// (get) Token: 0x0600DB6A RID: 56170 RVA: 0x003D2DA6 File Offset: 0x003D0FA6
		// (set) Token: 0x0600DB6B RID: 56171 RVA: 0x003D2DAE File Offset: 0x003D0FAE
		public string monsterName { get; set; }

		// Token: 0x170014FC RID: 5372
		// (get) Token: 0x0600DB6C RID: 56172 RVA: 0x003D2DB7 File Offset: 0x003D0FB7
		// (set) Token: 0x0600DB6D RID: 56173 RVA: 0x003D2DBF File Offset: 0x003D0FBF
		public string rewardTxt { get; set; }

		// Token: 0x170014FD RID: 5373
		// (get) Token: 0x0600DB6E RID: 56174 RVA: 0x003D2DC8 File Offset: 0x003D0FC8
		// (set) Token: 0x0600DB6F RID: 56175 RVA: 0x003D2DD0 File Offset: 0x003D0FD0
		public int[] firstReward { get; set; }

		// Token: 0x170014FE RID: 5374
		// (get) Token: 0x0600DB70 RID: 56176 RVA: 0x003D2DD9 File Offset: 0x003D0FD9
		// (set) Token: 0x0600DB71 RID: 56177 RVA: 0x003D2DE1 File Offset: 0x003D0FE1
		public int[] reward { get; set; }

		// Token: 0x170014FF RID: 5375
		// (get) Token: 0x0600DB72 RID: 56178 RVA: 0x003D2DEA File Offset: 0x003D0FEA
		// (set) Token: 0x0600DB73 RID: 56179 RVA: 0x003D2DF2 File Offset: 0x003D0FF2
		public int id { get; set; }

		// Token: 0x17001500 RID: 5376
		// (get) Token: 0x0600DB74 RID: 56180 RVA: 0x003D2DFB File Offset: 0x003D0FFB
		// (set) Token: 0x0600DB75 RID: 56181 RVA: 0x003D2E03 File Offset: 0x003D1003
		public int monsterId { get; set; }

		// Token: 0x17001501 RID: 5377
		// (get) Token: 0x0600DB76 RID: 56182 RVA: 0x003D2E0C File Offset: 0x003D100C
		// (set) Token: 0x0600DB77 RID: 56183 RVA: 0x003D2E14 File Offset: 0x003D1014
		public int order { get; set; }

		// Token: 0x0600DB78 RID: 56184 RVA: 0x003D2E20 File Offset: 0x003D1020
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.bossIntro = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.firstReward = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.firstReward[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.firstRewardTxt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monsterId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monsterName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.order = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.reward = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.reward[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.rewardTxt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
