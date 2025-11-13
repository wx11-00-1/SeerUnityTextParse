using System;

namespace core.config
{
	// Token: 0x02001DB3 RID: 7603
	public class Partner : XlsConfigBase<Partner, IPartnerInfo>
	{
		// Token: 0x170016B0 RID: 5808
		// (get) Token: 0x0600DFA2 RID: 57250 RVA: 0x003D84F3 File Offset: 0x003D66F3
		public override string fileName
		{
			get
			{
				return "partner";
			}
		}

		// Token: 0x0600DFA3 RID: 57251 RVA: 0x003D84FC File Offset: 0x003D66FC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPartnerInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPartnerInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DFA4 RID: 57252 RVA: 0x003D8550 File Offset: 0x003D6750
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
