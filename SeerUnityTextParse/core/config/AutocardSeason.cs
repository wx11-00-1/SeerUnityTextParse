using System;

namespace core.config
{
	// Token: 0x02002588 RID: 9608
	public class AutocardSeason : XlsConfigBase<AutocardSeason, IAutocardSeasonInfo>
	{
		// Token: 0x17001822 RID: 6178
		// (get) Token: 0x06012A3F RID: 76351 RVA: 0x0054740F File Offset: 0x0054560F
		public override string fileName
		{
			get
			{
				return "autocardSeason";
			}
		}

		// Token: 0x06012A40 RID: 76352 RVA: 0x00547418 File Offset: 0x00545618
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAutocardSeasonInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAutocardSeasonInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06012A41 RID: 76353 RVA: 0x0054746C File Offset: 0x0054566C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
