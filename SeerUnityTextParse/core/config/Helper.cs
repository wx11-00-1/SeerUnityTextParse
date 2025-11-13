using System;

namespace core.config
{
	// Token: 0x02001D65 RID: 7525
	public class Helper : XlsConfigBase<Helper, IHelperInfo>
	{
		// Token: 0x17001560 RID: 5472
		// (get) Token: 0x0600DC66 RID: 56422 RVA: 0x003D4490 File Offset: 0x003D2690
		public override string fileName
		{
			get
			{
				return "helper";
			}
		}

		// Token: 0x0600DC67 RID: 56423 RVA: 0x003D4498 File Offset: 0x003D2698
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IHelperInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IHelperInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DC68 RID: 56424 RVA: 0x003D44EC File Offset: 0x003D26EC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
