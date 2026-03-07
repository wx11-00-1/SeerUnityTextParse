using System;

namespace core.config
{
	// Token: 0x02002075 RID: 8309
	public class IPurchaseBonusShopInfo : IConfigItem
	{
		// Token: 0x17001A12 RID: 6674
		// (get) Token: 0x0600FAFA RID: 64250 RVA: 0x0043FFB8 File Offset: 0x0043E1B8
		// (set) Token: 0x0600FAFB RID: 64251 RVA: 0x0043FFC0 File Offset: 0x0043E1C0
		public int[] commodity { get; set; }

		// Token: 0x17001A13 RID: 6675
		// (get) Token: 0x0600FAFC RID: 64252 RVA: 0x0043FFC9 File Offset: 0x0043E1C9
		// (set) Token: 0x0600FAFD RID: 64253 RVA: 0x0043FFD1 File Offset: 0x0043E1D1
		public int consumeitemid { get; set; }

		// Token: 0x17001A14 RID: 6676
		// (get) Token: 0x0600FAFE RID: 64254 RVA: 0x0043FFDA File Offset: 0x0043E1DA
		// (set) Token: 0x0600FAFF RID: 64255 RVA: 0x0043FFE2 File Offset: 0x0043E1E2
		public int id { get; set; }

		// Token: 0x17001A15 RID: 6677
		// (get) Token: 0x0600FB00 RID: 64256 RVA: 0x0043FFEB File Offset: 0x0043E1EB
		// (set) Token: 0x0600FB01 RID: 64257 RVA: 0x0043FFF3 File Offset: 0x0043E1F3
		public int limit { get; set; }

		// Token: 0x17001A16 RID: 6678
		// (get) Token: 0x0600FB02 RID: 64258 RVA: 0x0043FFFC File Offset: 0x0043E1FC
		// (set) Token: 0x0600FB03 RID: 64259 RVA: 0x00440004 File Offset: 0x0043E204
		public int price { get; set; }

		// Token: 0x17001A17 RID: 6679
		// (get) Token: 0x0600FB04 RID: 64260 RVA: 0x0044000D File Offset: 0x0043E20D
		// (set) Token: 0x0600FB05 RID: 64261 RVA: 0x00440015 File Offset: 0x0043E215
		public int quantity { get; set; }

		// Token: 0x17001A18 RID: 6680
		// (get) Token: 0x0600FB06 RID: 64262 RVA: 0x0044001E File Offset: 0x0043E21E
		// (set) Token: 0x0600FB07 RID: 64263 RVA: 0x00440026 File Offset: 0x0043E226
		public int shoptype { get; set; }

		// Token: 0x17001A19 RID: 6681
		// (get) Token: 0x0600FB08 RID: 64264 RVA: 0x0044002F File Offset: 0x0043E22F
		// (set) Token: 0x0600FB09 RID: 64265 RVA: 0x00440037 File Offset: 0x0043E237
		public int stat { get; set; }

		// Token: 0x17001A1A RID: 6682
		// (get) Token: 0x0600FB0A RID: 64266 RVA: 0x00440040 File Offset: 0x0043E240
		// (set) Token: 0x0600FB0B RID: 64267 RVA: 0x00440048 File Offset: 0x0043E248
		public int userinfo { get; set; }

		// Token: 0x0600FB0C RID: 64268 RVA: 0x00440054 File Offset: 0x0043E254
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.commodity = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.commodity[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.consumeitemid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.limit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.quantity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.shoptype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.stat = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.userinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
