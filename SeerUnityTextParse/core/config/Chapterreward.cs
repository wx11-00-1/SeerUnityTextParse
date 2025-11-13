using System;

namespace core.config
{
	// Token: 0x02001CEF RID: 7407
	public class Chapterreward : XlsConfigBase<Chapterreward, IChapterrewardInfo>
	{
		// Token: 0x1700135E RID: 4958
		// (get) Token: 0x0600D776 RID: 55158 RVA: 0x003CE322 File Offset: 0x003CC522
		public override string fileName
		{
			get
			{
				return "chapterreward";
			}
		}

		// Token: 0x0600D777 RID: 55159 RVA: 0x003CE32C File Offset: 0x003CC52C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IChapterrewardInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IChapterrewardInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D778 RID: 55160 RVA: 0x003CE380 File Offset: 0x003CC580
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
