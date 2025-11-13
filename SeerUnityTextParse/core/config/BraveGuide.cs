using System;

namespace core.config
{
	// Token: 0x02001CD9 RID: 7385
	public class BraveGuide : XlsConfigBase<BraveGuide, IBraveGuideInfo>
	{
		// Token: 0x170012ED RID: 4845
		// (get) Token: 0x0600D668 RID: 54888 RVA: 0x003CCD76 File Offset: 0x003CAF76
		public override string fileName
		{
			get
			{
				return "brave_guide";
			}
		}

		// Token: 0x0600D669 RID: 54889 RVA: 0x003CCD80 File Offset: 0x003CAF80
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBraveGuideInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBraveGuideInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D66A RID: 54890 RVA: 0x003CCDD4 File Offset: 0x003CAFD4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
