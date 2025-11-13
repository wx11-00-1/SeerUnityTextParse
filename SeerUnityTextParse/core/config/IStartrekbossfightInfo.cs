using System;

namespace core.config
{
	// Token: 0x02001E3C RID: 7740
	public class IStartrekbossfightInfo : IConfigItem
	{
		// Token: 0x17001907 RID: 6407
		// (get) Token: 0x0600E562 RID: 58722 RVA: 0x003DF948 File Offset: 0x003DDB48
		// (set) Token: 0x0600E563 RID: 58723 RVA: 0x003DF950 File Offset: 0x003DDB50
		public int[] MonsterIds { get; set; }

		// Token: 0x17001908 RID: 6408
		// (get) Token: 0x0600E564 RID: 58724 RVA: 0x003DF959 File Offset: 0x003DDB59
		// (set) Token: 0x0600E565 RID: 58725 RVA: 0x003DF961 File Offset: 0x003DDB61
		public int[] rewardinfo { get; set; }

		// Token: 0x17001909 RID: 6409
		// (get) Token: 0x0600E566 RID: 58726 RVA: 0x003DF96A File Offset: 0x003DDB6A
		// (set) Token: 0x0600E567 RID: 58727 RVA: 0x003DF972 File Offset: 0x003DDB72
		public int BossfightId { get; set; }

		// Token: 0x1700190A RID: 6410
		// (get) Token: 0x0600E568 RID: 58728 RVA: 0x003DF97B File Offset: 0x003DDB7B
		// (set) Token: 0x0600E569 RID: 58729 RVA: 0x003DF983 File Offset: 0x003DDB83
		public int BossType { get; set; }

		// Token: 0x1700190B RID: 6411
		// (get) Token: 0x0600E56A RID: 58730 RVA: 0x003DF98C File Offset: 0x003DDB8C
		// (set) Token: 0x0600E56B RID: 58731 RVA: 0x003DF994 File Offset: 0x003DDB94
		public int id { get; set; }

		// Token: 0x1700190C RID: 6412
		// (get) Token: 0x0600E56C RID: 58732 RVA: 0x003DF99D File Offset: 0x003DDB9D
		// (set) Token: 0x0600E56D RID: 58733 RVA: 0x003DF9A5 File Offset: 0x003DDBA5
		public int WinRewardNum { get; set; }

		// Token: 0x0600E56E RID: 58734 RVA: 0x003DF9B0 File Offset: 0x003DDBB0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.BossType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.BossfightId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.MonsterIds = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.MonsterIds[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.WinRewardNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.rewardinfo = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.rewardinfo[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
