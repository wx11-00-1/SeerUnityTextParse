using System;

namespace core.config
{
	// Token: 0x02001DB5 RID: 7605
	public class PartnerEffectUpgrade : XlsConfigBase<PartnerEffectUpgrade, IPartnerEffectUpgradeInfo>
	{
		// Token: 0x170016B9 RID: 5817
		// (get) Token: 0x0600DFB8 RID: 57272 RVA: 0x003D86AE File Offset: 0x003D68AE
		public override string fileName
		{
			get
			{
				return "partnerEffectUpgrade";
			}
		}

		// Token: 0x0600DFB9 RID: 57273 RVA: 0x003D86B8 File Offset: 0x003D68B8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPartnerEffectUpgradeInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPartnerEffectUpgradeInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DFBA RID: 57274 RVA: 0x003D870C File Offset: 0x003D690C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
