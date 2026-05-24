using System;

namespace core.config
{
	// Token: 0x02002746 RID: 10054
	public class ZumaGme : XlsConfigBase<ZumaGme, IZumaGmeInfo>
	{
		// Token: 0x17002490 RID: 9360
		// (get) Token: 0x06013B04 RID: 80644 RVA: 0x0052AB6C File Offset: 0x00528D6C
		public override string fileName
		{
			get
			{
				return "zumaGme";
			}
		}

		// Token: 0x06013B05 RID: 80645 RVA: 0x0052AB74 File Offset: 0x00528D74
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IZumaGmeInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IZumaGmeInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06013B06 RID: 80646 RVA: 0x0052ABC8 File Offset: 0x00528DC8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
