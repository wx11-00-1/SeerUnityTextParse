using System;

namespace core.config
{
	// Token: 0x02001D6D RID: 7533
	public class LanglangshanArtCourseConfig : XlsConfigBase<LanglangshanArtCourseConfig, ILanglangshanArtCourseConfigInfo>
	{
		// Token: 0x1700157C RID: 5500
		// (get) Token: 0x0600DCAE RID: 56494 RVA: 0x003D4A10 File Offset: 0x003D2C10
		public override string fileName
		{
			get
			{
				return "langlangshanArtCourseConfig";
			}
		}

		// Token: 0x0600DCAF RID: 56495 RVA: 0x003D4A18 File Offset: 0x003D2C18
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ILanglangshanArtCourseConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ILanglangshanArtCourseConfigInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DCB0 RID: 56496 RVA: 0x003D4A6C File Offset: 0x003D2C6C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
