using System;

namespace core.config
{
	// Token: 0x02002134 RID: 8500
	public class AutocardEffectIconDes : XlsConfigBase<AutocardEffectIconDes, IAutocardEffectIconDesInfo>
	{
		// Token: 0x170014CE RID: 5326
		// (get) Token: 0x0600FC84 RID: 64644 RVA: 0x0047CF42 File Offset: 0x0047B142
		public override string fileName
		{
			get
			{
				return "autocardEffectIconDes";
			}
		}

		// Token: 0x0600FC85 RID: 64645 RVA: 0x0047CF4C File Offset: 0x0047B14C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAutocardEffectIconDesInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAutocardEffectIconDesInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600FC86 RID: 64646 RVA: 0x0047CFA0 File Offset: 0x0047B1A0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
