using System;

namespace core.config
{
	// Token: 0x0200258A RID: 9610
	public class AutocardSeasonEffect : XlsConfigBase<AutocardSeasonEffect, IAutocardSeasonEffectInfo>
	{
		// Token: 0x17001837 RID: 6199
		// (get) Token: 0x06012A6D RID: 76397 RVA: 0x0054777E File Offset: 0x0054597E
		public override string fileName
		{
			get
			{
				return "autocardSeasonEffect";
			}
		}

		// Token: 0x06012A6E RID: 76398 RVA: 0x00547788 File Offset: 0x00545988
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAutocardSeasonEffectInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAutocardSeasonEffectInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06012A6F RID: 76399 RVA: 0x005477DC File Offset: 0x005459DC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
