using System;

namespace core.config
{
	// Token: 0x02002130 RID: 8496
	public class AutocardCV : XlsConfigBase<AutocardCV, IAutocardCVInfo>
	{
		// Token: 0x170014C2 RID: 5314
		// (get) Token: 0x0600FC64 RID: 64612 RVA: 0x0047CCDD File Offset: 0x0047AEDD
		public override string fileName
		{
			get
			{
				return "autocardCV";
			}
		}

		// Token: 0x0600FC65 RID: 64613 RVA: 0x0047CCE4 File Offset: 0x0047AEE4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAutocardCVInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAutocardCVInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600FC66 RID: 64614 RVA: 0x0047CD38 File Offset: 0x0047AF38
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
