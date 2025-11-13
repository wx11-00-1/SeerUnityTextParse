using System;

namespace core.config
{
	// Token: 0x02001CBD RID: 7357
	public class BattlepassShop : XlsConfigBase<BattlepassShop, IBattlepassShopInfo>
	{
		// Token: 0x17001288 RID: 4744
		// (get) Token: 0x0600D566 RID: 54630 RVA: 0x003CBAA0 File Offset: 0x003C9CA0
		public override string fileName
		{
			get
			{
				return "battlepass_shop";
			}
		}

		// Token: 0x0600D567 RID: 54631 RVA: 0x003CBAA8 File Offset: 0x003C9CA8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBattlepassShopInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBattlepassShopInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D568 RID: 54632 RVA: 0x003CBAFC File Offset: 0x003C9CFC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
