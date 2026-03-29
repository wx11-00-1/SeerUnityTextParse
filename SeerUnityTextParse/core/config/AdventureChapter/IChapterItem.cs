using System;

namespace core.config.AdventureChapter
{
	// Token: 0x02002635 RID: 9781
	public class IChapterItem
	{
		// Token: 0x1700298F RID: 10639
		// (get) Token: 0x060133D1 RID: 78801 RVA: 0x004C779B File Offset: 0x004C599B
		// (set) Token: 0x060133D2 RID: 78802 RVA: 0x004C77A3 File Offset: 0x004C59A3
		public IChapterRewardInfo ChapterRewardInfo { get; set; }

		// Token: 0x17002990 RID: 10640
		// (get) Token: 0x060133D3 RID: 78803 RVA: 0x004C77AC File Offset: 0x004C59AC
		// (set) Token: 0x060133D4 RID: 78804 RVA: 0x004C77B4 File Offset: 0x004C59B4
		public string Des { get; set; }

		// Token: 0x17002991 RID: 10641
		// (get) Token: 0x060133D5 RID: 78805 RVA: 0x004C77BD File Offset: 0x004C59BD
		// (set) Token: 0x060133D6 RID: 78806 RVA: 0x004C77C5 File Offset: 0x004C59C5
		public string readyOff { get; set; }

		// Token: 0x17002992 RID: 10642
		// (get) Token: 0x060133D7 RID: 78807 RVA: 0x004C77CE File Offset: 0x004C59CE
		// (set) Token: 0x060133D8 RID: 78808 RVA: 0x004C77D6 File Offset: 0x004C59D6
		public IStoryRewardInfo StoryRewardInfo { get; set; }

		// Token: 0x17002993 RID: 10643
		// (get) Token: 0x060133D9 RID: 78809 RVA: 0x004C77DF File Offset: 0x004C59DF
		// (set) Token: 0x060133DA RID: 78810 RVA: 0x004C77E7 File Offset: 0x004C59E7
		public string Title { get; set; }

		// Token: 0x17002994 RID: 10644
		// (get) Token: 0x060133DB RID: 78811 RVA: 0x004C77F0 File Offset: 0x004C59F0
		// (set) Token: 0x060133DC RID: 78812 RVA: 0x004C77F8 File Offset: 0x004C59F8
		public int[] lineInfo { get; set; }

		// Token: 0x17002995 RID: 10645
		// (get) Token: 0x060133DD RID: 78813 RVA: 0x004C7801 File Offset: 0x004C5A01
		// (set) Token: 0x060133DE RID: 78814 RVA: 0x004C7809 File Offset: 0x004C5A09
		public int[] positionInfo { get; set; }

		// Token: 0x17002996 RID: 10646
		// (get) Token: 0x060133DF RID: 78815 RVA: 0x004C7812 File Offset: 0x004C5A12
		// (set) Token: 0x060133E0 RID: 78816 RVA: 0x004C781A File Offset: 0x004C5A1A
		public int ChapterRewardFlagID { get; set; }

		// Token: 0x17002997 RID: 10647
		// (get) Token: 0x060133E1 RID: 78817 RVA: 0x004C7823 File Offset: 0x004C5A23
		// (set) Token: 0x060133E2 RID: 78818 RVA: 0x004C782B File Offset: 0x004C5A2B
		public int ID { get; set; }

		// Token: 0x17002998 RID: 10648
		// (get) Token: 0x060133E3 RID: 78819 RVA: 0x004C7834 File Offset: 0x004C5A34
		// (set) Token: 0x060133E4 RID: 78820 RVA: 0x004C783C File Offset: 0x004C5A3C
		public int redID { get; set; }

		// Token: 0x17002999 RID: 10649
		// (get) Token: 0x060133E5 RID: 78821 RVA: 0x004C7845 File Offset: 0x004C5A45
		// (set) Token: 0x060133E6 RID: 78822 RVA: 0x004C784D File Offset: 0x004C5A4D
		public int Sort { get; set; }

		// Token: 0x1700299A RID: 10650
		// (get) Token: 0x060133E7 RID: 78823 RVA: 0x004C7856 File Offset: 0x004C5A56
		// (set) Token: 0x060133E8 RID: 78824 RVA: 0x004C785E File Offset: 0x004C5A5E
		public int statlogId { get; set; }

		// Token: 0x1700299B RID: 10651
		// (get) Token: 0x060133E9 RID: 78825 RVA: 0x004C7867 File Offset: 0x004C5A67
		// (set) Token: 0x060133EA RID: 78826 RVA: 0x004C786F File Offset: 0x004C5A6F
		public int StoryRewardFlagID { get; set; }

		// Token: 0x060133EB RID: 78827 RVA: 0x004C7878 File Offset: 0x004C5A78
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ChapterRewardFlagID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.ChapterRewardInfo = new IChapterRewardInfo();
				this.ChapterRewardInfo.Parse(bytes, ref byteIndex);
			}
			this.Des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.StoryRewardFlagID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.StoryRewardInfo = new IStoryRewardInfo();
				this.StoryRewardInfo.Parse(bytes, ref byteIndex);
			}
			this.Title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.lineInfo = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.lineInfo[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.positionInfo = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.positionInfo[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.readyOff = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.redID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.statlogId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
