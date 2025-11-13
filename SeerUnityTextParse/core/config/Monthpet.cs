using System;

namespace core.config
{
	// Token: 0x02001D9B RID: 7579
	public class Monthpet : XlsConfigBase<Monthpet, IMonthpetInfo>
	{
		// Token: 0x17001631 RID: 5681
		// (get) Token: 0x0600DE74 RID: 56948 RVA: 0x003D6D71 File Offset: 0x003D4F71
		public override string fileName
		{
			get
			{
				return "monthpet";
			}
		}

		// Token: 0x0600DE75 RID: 56949 RVA: 0x003D6D78 File Offset: 0x003D4F78
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IMonthpetInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IMonthpetInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DE76 RID: 56950 RVA: 0x003D6DCC File Offset: 0x003D4FCC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
