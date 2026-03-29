using System;

namespace core.config.AdventureChapter
{
	// Token: 0x02002634 RID: 9780
	public class IAdventureChapter
	{
		// Token: 0x1700298D RID: 10637
		// (get) Token: 0x060133CB RID: 78795 RVA: 0x004C7711 File Offset: 0x004C5911
		// (set) Token: 0x060133CC RID: 78796 RVA: 0x004C7719 File Offset: 0x004C5919
		public IChapterItem[] Chapter { get; set; }

		// Token: 0x1700298E RID: 10638
		// (get) Token: 0x060133CD RID: 78797 RVA: 0x004C7722 File Offset: 0x004C5922
		// (set) Token: 0x060133CE RID: 78798 RVA: 0x004C772A File Offset: 0x004C592A
		public int @new { get; set; }

		// Token: 0x060133CF RID: 78799 RVA: 0x004C7734 File Offset: 0x004C5934
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Chapter = new IChapterItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Chapter[i] = new IChapterItem();
					this.Chapter[i].Parse(bytes, ref byteIndex);
				}
			}
			this.@new = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
