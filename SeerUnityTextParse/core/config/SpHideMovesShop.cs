using System;

namespace core.config
{
	// Token: 0x02001E35 RID: 7733
	public class SpHideMovesShop : XlsConfigBase<SpHideMovesShop, ISpHideMovesShopInfo>
	{
		// Token: 0x170018EA RID: 6378
		// (get) Token: 0x0600E51A RID: 58650 RVA: 0x003DF374 File Offset: 0x003DD574
		public override string fileName
		{
			get
			{
				return "sp_hide_moves_shop";
			}
		}

		// Token: 0x0600E51B RID: 58651 RVA: 0x003DF37C File Offset: 0x003DD57C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ISpHideMovesShopInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ISpHideMovesShopInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E51C RID: 58652 RVA: 0x003DF3D0 File Offset: 0x003DD5D0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
