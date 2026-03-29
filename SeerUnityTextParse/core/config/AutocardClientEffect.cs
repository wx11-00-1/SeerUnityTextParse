using System;

namespace core.config
{
	// Token: 0x0200212A RID: 8490
	public class AutocardClientEffect : XlsConfigBase<AutocardClientEffect, IAutocardClientEffectInfo>
	{
		// Token: 0x170014A3 RID: 5283
		// (get) Token: 0x0600FC1A RID: 64538 RVA: 0x0047C7AD File Offset: 0x0047A9AD
		public override string fileName
		{
			get
			{
				return "autocardClientEffect";
			}
		}

		// Token: 0x0600FC1B RID: 64539 RVA: 0x0047C7B4 File Offset: 0x0047A9B4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAutocardClientEffectInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAutocardClientEffectInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600FC1C RID: 64540 RVA: 0x0047C808 File Offset: 0x0047AA08
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
