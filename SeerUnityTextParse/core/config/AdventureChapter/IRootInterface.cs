using System;

namespace core.config.AdventureChapter
{
	// Token: 0x02002639 RID: 9785
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x170029A4 RID: 10660
		// (get) Token: 0x06013403 RID: 78851 RVA: 0x004C7B8B File Offset: 0x004C5D8B
		public override string fileName
		{
			get
			{
				return "AdventureChapter";
			}
		}

		// Token: 0x170029A5 RID: 10661
		// (get) Token: 0x06013404 RID: 78852 RVA: 0x004C7B92 File Offset: 0x004C5D92
		// (set) Token: 0x06013405 RID: 78853 RVA: 0x004C7B9A File Offset: 0x004C5D9A
		public IAdventureChapter AdventureChapter { get; set; }

		// Token: 0x06013406 RID: 78854 RVA: 0x004C7BA3 File Offset: 0x004C5DA3
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.AdventureChapter = new IAdventureChapter();
				this.AdventureChapter.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x06013407 RID: 78855 RVA: 0x004C7BC8 File Offset: 0x004C5DC8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
