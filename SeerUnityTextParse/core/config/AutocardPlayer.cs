using System;

namespace core.config
{
	// Token: 0x02002138 RID: 8504
	public class AutocardPlayer : XlsConfigBase<AutocardPlayer, IAutocardPlayerInfo>
	{
		// Token: 0x170014D7 RID: 5335
		// (get) Token: 0x0600FC9E RID: 64670 RVA: 0x0047D152 File Offset: 0x0047B352
		public override string fileName
		{
			get
			{
				return "autocardPlayer";
			}
		}

		// Token: 0x0600FC9F RID: 64671 RVA: 0x0047D15C File Offset: 0x0047B35C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAutocardPlayerInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAutocardPlayerInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600FCA0 RID: 64672 RVA: 0x0047D1B0 File Offset: 0x0047B3B0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
