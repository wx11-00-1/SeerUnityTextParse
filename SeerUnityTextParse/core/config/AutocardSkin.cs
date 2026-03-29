using System;

namespace core.config
{
	// Token: 0x02002142 RID: 8514
	public class AutocardSkin : XlsConfigBase<AutocardSkin, IAutocardSkinInfo>
	{
		// Token: 0x17001510 RID: 5392
		// (get) Token: 0x0600FD24 RID: 64804 RVA: 0x0047DAC8 File Offset: 0x0047BCC8
		public override string fileName
		{
			get
			{
				return "autocardSkin";
			}
		}

		// Token: 0x0600FD25 RID: 64805 RVA: 0x0047DAD0 File Offset: 0x0047BCD0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAutocardSkinInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAutocardSkinInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600FD26 RID: 64806 RVA: 0x0047DB24 File Offset: 0x0047BD24
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
