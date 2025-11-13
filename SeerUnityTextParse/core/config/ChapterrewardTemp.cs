using System;

namespace core.config
{
	// Token: 0x02001CF1 RID: 7409
	public class ChapterrewardTemp : XlsConfigBase<ChapterrewardTemp, IChapterrewardTempInfo>
	{
		// Token: 0x17001365 RID: 4965
		// (get) Token: 0x0600D788 RID: 55176 RVA: 0x003CE472 File Offset: 0x003CC672
		public override string fileName
		{
			get
			{
				return "chapterreward_temp";
			}
		}

		// Token: 0x0600D789 RID: 55177 RVA: 0x003CE47C File Offset: 0x003CC67C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IChapterrewardTempInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IChapterrewardTempInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D78A RID: 55178 RVA: 0x003CE4D0 File Offset: 0x003CC6D0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
