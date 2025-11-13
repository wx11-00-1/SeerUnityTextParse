using System;

namespace core.config.vip_month_monster
{
	// Token: 0x02001EFA RID: 7930
	public class IItemItem
	{
		// Token: 0x17001AEC RID: 6892
		// (get) Token: 0x0600ED6E RID: 60782 RVA: 0x003F1394 File Offset: 0x003EF594
		// (set) Token: 0x0600ED6F RID: 60783 RVA: 0x003F139C File Offset: 0x003EF59C
		public int[] BonusIds { get; set; }

		// Token: 0x17001AED RID: 6893
		// (get) Token: 0x0600ED70 RID: 60784 RVA: 0x003F13A5 File Offset: 0x003EF5A5
		// (set) Token: 0x0600ED71 RID: 60785 RVA: 0x003F13AD File Offset: 0x003EF5AD
		public int[] GotFlagInfo { get; set; }

		// Token: 0x17001AEE RID: 6894
		// (get) Token: 0x0600ED72 RID: 60786 RVA: 0x003F13B6 File Offset: 0x003EF5B6
		// (set) Token: 0x0600ED73 RID: 60787 RVA: 0x003F13BE File Offset: 0x003EF5BE
		public int[] MonstersID { get; set; }

		// Token: 0x17001AEF RID: 6895
		// (get) Token: 0x0600ED74 RID: 60788 RVA: 0x003F13C7 File Offset: 0x003EF5C7
		// (set) Token: 0x0600ED75 RID: 60789 RVA: 0x003F13CF File Offset: 0x003EF5CF
		public int CurMonth { get; set; }

		// Token: 0x17001AF0 RID: 6896
		// (get) Token: 0x0600ED76 RID: 60790 RVA: 0x003F13D8 File Offset: 0x003EF5D8
		// (set) Token: 0x0600ED77 RID: 60791 RVA: 0x003F13E0 File Offset: 0x003EF5E0
		public int CurYear { get; set; }

		// Token: 0x17001AF1 RID: 6897
		// (get) Token: 0x0600ED78 RID: 60792 RVA: 0x003F13E9 File Offset: 0x003EF5E9
		// (set) Token: 0x0600ED79 RID: 60793 RVA: 0x003F13F1 File Offset: 0x003EF5F1
		public int ID { get; set; }

		// Token: 0x17001AF2 RID: 6898
		// (get) Token: 0x0600ED7A RID: 60794 RVA: 0x003F13FA File Offset: 0x003EF5FA
		// (set) Token: 0x0600ED7B RID: 60795 RVA: 0x003F1402 File Offset: 0x003EF602
		public int MonsterID { get; set; }

		// Token: 0x0600ED7C RID: 60796 RVA: 0x003F140C File Offset: 0x003EF60C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.BonusIds = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.BonusIds[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.CurMonth = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.CurYear = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.GotFlagInfo = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.GotFlagInfo[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MonsterID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.MonstersID = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					this.MonstersID[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
