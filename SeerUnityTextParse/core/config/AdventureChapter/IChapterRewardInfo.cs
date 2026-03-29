using System;

namespace core.config.AdventureChapter
{
	// Token: 0x02002636 RID: 9782
	public class IChapterRewardInfo
	{
		// Token: 0x1700299C RID: 10652
		// (get) Token: 0x060133ED RID: 78829 RVA: 0x004C79C9 File Offset: 0x004C5BC9
		// (set) Token: 0x060133EE RID: 78830 RVA: 0x004C79D1 File Offset: 0x004C5BD1
		public IPassChapterRewardItem[] PassChapterReward { get; set; }

		// Token: 0x060133EF RID: 78831 RVA: 0x004C79DC File Offset: 0x004C5BDC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.PassChapterReward = new IPassChapterRewardItem[num];
				for (int i = 0; i < num; i++)
				{
					this.PassChapterReward[i] = new IPassChapterRewardItem();
					this.PassChapterReward[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
