using System;

namespace core.config.AdventureChapter
{
	// Token: 0x02002637 RID: 9783
	public class IPassChapterRewardItem
	{
		// Token: 0x1700299D RID: 10653
		// (get) Token: 0x060133F1 RID: 78833 RVA: 0x004C7A36 File Offset: 0x004C5C36
		// (set) Token: 0x060133F2 RID: 78834 RVA: 0x004C7A3E File Offset: 0x004C5C3E
		public int[] rewardinfo { get; set; }

		// Token: 0x1700299E RID: 10654
		// (get) Token: 0x060133F3 RID: 78835 RVA: 0x004C7A47 File Offset: 0x004C5C47
		// (set) Token: 0x060133F4 RID: 78836 RVA: 0x004C7A4F File Offset: 0x004C5C4F
		public int ID { get; set; }

		// Token: 0x1700299F RID: 10655
		// (get) Token: 0x060133F5 RID: 78837 RVA: 0x004C7A58 File Offset: 0x004C5C58
		// (set) Token: 0x060133F6 RID: 78838 RVA: 0x004C7A60 File Offset: 0x004C5C60
		public int isMore { get; set; }

		// Token: 0x170029A0 RID: 10656
		// (get) Token: 0x060133F7 RID: 78839 RVA: 0x004C7A69 File Offset: 0x004C5C69
		// (set) Token: 0x060133F8 RID: 78840 RVA: 0x004C7A71 File Offset: 0x004C5C71
		public int NeedPassStoryNum { get; set; }

		// Token: 0x060133F9 RID: 78841 RVA: 0x004C7A7C File Offset: 0x004C5C7C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.NeedPassStoryNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isMore = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.rewardinfo = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.rewardinfo[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
