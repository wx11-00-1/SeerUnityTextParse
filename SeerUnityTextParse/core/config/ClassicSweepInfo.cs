using System;

namespace core.config
{
	// Token: 0x02001D07 RID: 7431
	public class ClassicSweepInfo : XlsConfigBase<ClassicSweepInfo, IClassicSweepInfoInfo>
	{
		// Token: 0x170013F0 RID: 5104
		// (get) Token: 0x0600D8CA RID: 55498 RVA: 0x003CFB90 File Offset: 0x003CDD90
		public override string fileName
		{
			get
			{
				return "classicSweepInfo";
			}
		}

		// Token: 0x0600D8CB RID: 55499 RVA: 0x003CFB98 File Offset: 0x003CDD98
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IClassicSweepInfoInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IClassicSweepInfoInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D8CC RID: 55500 RVA: 0x003CFBEC File Offset: 0x003CDDEC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
