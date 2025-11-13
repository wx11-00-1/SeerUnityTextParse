using System;

namespace core.config.medals
{
	// Token: 0x02001FCF RID: 8143
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001E1A RID: 7706
		// (get) Token: 0x0600F579 RID: 62841 RVA: 0x003FAEC6 File Offset: 0x003F90C6
		public override string fileName
		{
			get
			{
				return "medals";
			}
		}

		// Token: 0x17001E1B RID: 7707
		// (get) Token: 0x0600F57A RID: 62842 RVA: 0x003FAECD File Offset: 0x003F90CD
		// (set) Token: 0x0600F57B RID: 62843 RVA: 0x003FAED5 File Offset: 0x003F90D5
		public IMedals medals { get; set; }

		// Token: 0x0600F57C RID: 62844 RVA: 0x003FAEDE File Offset: 0x003F90DE
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.medals = new IMedals();
				this.medals.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600F57D RID: 62845 RVA: 0x003FAF04 File Offset: 0x003F9104
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
