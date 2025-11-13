using System;

namespace core.config
{
	// Token: 0x02001E3F RID: 7743
	public class Startrekshopconfig : XlsConfigBase<Startrekshopconfig, IStartrekshopconfigInfo>
	{
		// Token: 0x17001914 RID: 6420
		// (get) Token: 0x0600E582 RID: 58754 RVA: 0x003DFBE8 File Offset: 0x003DDDE8
		public override string fileName
		{
			get
			{
				return "Startrekshopconfig";
			}
		}

		// Token: 0x0600E583 RID: 58755 RVA: 0x003DFBF0 File Offset: 0x003DDDF0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStartrekshopconfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStartrekshopconfigInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E584 RID: 58756 RVA: 0x003DFC44 File Offset: 0x003DDE44
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
