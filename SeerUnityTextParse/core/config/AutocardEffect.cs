using System;

namespace core.config
{
	// Token: 0x02002132 RID: 8498
	public class AutocardEffect : XlsConfigBase<AutocardEffect, IAutocardEffectInfo>
	{
		// Token: 0x170014CA RID: 5322
		// (get) Token: 0x0600FC78 RID: 64632 RVA: 0x0047CE55 File Offset: 0x0047B055
		public override string fileName
		{
			get
			{
				return "autocardEffect";
			}
		}

		// Token: 0x0600FC79 RID: 64633 RVA: 0x0047CE5C File Offset: 0x0047B05C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAutocardEffectInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAutocardEffectInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600FC7A RID: 64634 RVA: 0x0047CEB0 File Offset: 0x0047B0B0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
