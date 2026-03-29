using System;

namespace core.config.AdventureChapter
{
	// Token: 0x02002638 RID: 9784
	public class IPassStoryRewardItem
	{
		// Token: 0x170029A1 RID: 10657
		// (get) Token: 0x060133FB RID: 78843 RVA: 0x004C7AF0 File Offset: 0x004C5CF0
		// (set) Token: 0x060133FC RID: 78844 RVA: 0x004C7AF8 File Offset: 0x004C5CF8
		public int[] rewardinfo { get; set; }

		// Token: 0x170029A2 RID: 10658
		// (get) Token: 0x060133FD RID: 78845 RVA: 0x004C7B01 File Offset: 0x004C5D01
		// (set) Token: 0x060133FE RID: 78846 RVA: 0x004C7B09 File Offset: 0x004C5D09
		public int PreUnlockStoryID { get; set; }

		// Token: 0x170029A3 RID: 10659
		// (get) Token: 0x060133FF RID: 78847 RVA: 0x004C7B12 File Offset: 0x004C5D12
		// (set) Token: 0x06013400 RID: 78848 RVA: 0x004C7B1A File Offset: 0x004C5D1A
		public int statlogId { get; set; }

		// Token: 0x06013401 RID: 78849 RVA: 0x004C7B24 File Offset: 0x004C5D24
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.PreUnlockStoryID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.rewardinfo = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.rewardinfo[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.statlogId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
