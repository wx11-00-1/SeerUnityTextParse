using System;

namespace core.config
{
	// Token: 0x02002136 RID: 8502
	public class AutocardNature : XlsConfigBase<AutocardNature, IAutocardNatureInfo>
	{
		// Token: 0x170014D3 RID: 5331
		// (get) Token: 0x0600FC92 RID: 64658 RVA: 0x0047D062 File Offset: 0x0047B262
		public override string fileName
		{
			get
			{
				return "autocardNature";
			}
		}

		// Token: 0x0600FC93 RID: 64659 RVA: 0x0047D06C File Offset: 0x0047B26C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAutocardNatureInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAutocardNatureInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600FC94 RID: 64660 RVA: 0x0047D0C0 File Offset: 0x0047B2C0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
