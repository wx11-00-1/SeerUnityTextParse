using System;

namespace core.config.AdventureStory
{
	// Token: 0x02002633 RID: 9779
	public class IStoryItem
	{
		// Token: 0x17002986 RID: 10630
		// (get) Token: 0x060133BB RID: 78779 RVA: 0x004C75DC File Offset: 0x004C57DC
		// (set) Token: 0x060133BC RID: 78780 RVA: 0x004C75E4 File Offset: 0x004C57E4
		public string BGM { get; set; }

		// Token: 0x17002987 RID: 10631
		// (get) Token: 0x060133BD RID: 78781 RVA: 0x004C75ED File Offset: 0x004C57ED
		// (set) Token: 0x060133BE RID: 78782 RVA: 0x004C75F5 File Offset: 0x004C57F5
		public string Des { get; set; }

		// Token: 0x17002988 RID: 10632
		// (get) Token: 0x060133BF RID: 78783 RVA: 0x004C75FE File Offset: 0x004C57FE
		// (set) Token: 0x060133C0 RID: 78784 RVA: 0x004C7606 File Offset: 0x004C5806
		public IDialogItem[] dialog { get; set; }

		// Token: 0x17002989 RID: 10633
		// (get) Token: 0x060133C1 RID: 78785 RVA: 0x004C760F File Offset: 0x004C580F
		// (set) Token: 0x060133C2 RID: 78786 RVA: 0x004C7617 File Offset: 0x004C5817
		public string Title { get; set; }

		// Token: 0x1700298A RID: 10634
		// (get) Token: 0x060133C3 RID: 78787 RVA: 0x004C7620 File Offset: 0x004C5820
		// (set) Token: 0x060133C4 RID: 78788 RVA: 0x004C7628 File Offset: 0x004C5828
		public int chapterID { get; set; }

		// Token: 0x1700298B RID: 10635
		// (get) Token: 0x060133C5 RID: 78789 RVA: 0x004C7631 File Offset: 0x004C5831
		// (set) Token: 0x060133C6 RID: 78790 RVA: 0x004C7639 File Offset: 0x004C5839
		public int ID { get; set; }

		// Token: 0x1700298C RID: 10636
		// (get) Token: 0x060133C7 RID: 78791 RVA: 0x004C7642 File Offset: 0x004C5842
		// (set) Token: 0x060133C8 RID: 78792 RVA: 0x004C764A File Offset: 0x004C584A
		public int isFuture { get; set; }

		// Token: 0x060133C9 RID: 78793 RVA: 0x004C7654 File Offset: 0x004C5854
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.BGM = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.chapterID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.dialog = new IDialogItem[num];
				for (int i = 0; i < num; i++)
				{
					this.dialog[i] = new IDialogItem();
					this.dialog[i].Parse(bytes, ref byteIndex);
				}
			}
			this.isFuture = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
