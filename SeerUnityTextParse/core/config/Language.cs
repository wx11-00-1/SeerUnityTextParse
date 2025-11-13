using System;

namespace core.config
{
	// Token: 0x02001D6F RID: 7535
	public class Language : XlsConfigBase<Language, ILanguageInfo>
	{
		// Token: 0x17001586 RID: 5510
		// (get) Token: 0x0600DCC6 RID: 56518 RVA: 0x003D4BB9 File Offset: 0x003D2DB9
		public override string fileName
		{
			get
			{
				return "language";
			}
		}

		// Token: 0x0600DCC7 RID: 56519 RVA: 0x003D4BC0 File Offset: 0x003D2DC0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ILanguageInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ILanguageInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DCC8 RID: 56520 RVA: 0x003D4C14 File Offset: 0x003D2E14
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
