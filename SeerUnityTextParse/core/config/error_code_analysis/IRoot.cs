using System;

namespace core.config.error_code_analysis
{
	// Token: 0x0200203E RID: 8254
	public class IRoot
	{
		// Token: 0x17002084 RID: 8324
		// (get) Token: 0x0600FC17 RID: 64535 RVA: 0x00401809 File Offset: 0x003FFA09
		// (set) Token: 0x0600FC18 RID: 64536 RVA: 0x00401811 File Offset: 0x003FFA11
		public IErrorpostItem[] errorpost { get; set; }

		// Token: 0x0600FC19 RID: 64537 RVA: 0x0040181C File Offset: 0x003FFA1C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (this.b)
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.errorpost = new IErrorpostItem[num];
				for (int i = 0; i < num; i++)
				{
					this.errorpost[i] = new IErrorpostItem();
					this.errorpost[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0400F5CA RID: 62922
		private bool b;
	}
}
