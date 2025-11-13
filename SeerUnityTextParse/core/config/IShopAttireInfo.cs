using System;

namespace core.config
{
	// Token: 0x02001E16 RID: 7702
	public class IShopAttireInfo : IConfigItem
	{
		// Token: 0x17001849 RID: 6217
		// (get) Token: 0x0600E39A RID: 58266 RVA: 0x003DD494 File Offset: 0x003DB694
		// (set) Token: 0x0600E39B RID: 58267 RVA: 0x003DD49C File Offset: 0x003DB69C
		public string name { get; set; }

		// Token: 0x1700184A RID: 6218
		// (get) Token: 0x0600E39C RID: 58268 RVA: 0x003DD4A5 File Offset: 0x003DB6A5
		// (set) Token: 0x0600E39D RID: 58269 RVA: 0x003DD4AD File Offset: 0x003DB6AD
		public int[] miditem { get; set; }

		// Token: 0x1700184B RID: 6219
		// (get) Token: 0x0600E39E RID: 58270 RVA: 0x003DD4B6 File Offset: 0x003DB6B6
		// (set) Token: 0x0600E39F RID: 58271 RVA: 0x003DD4BE File Offset: 0x003DB6BE
		public int[] price { get; set; }

		// Token: 0x1700184C RID: 6220
		// (get) Token: 0x0600E3A0 RID: 58272 RVA: 0x003DD4C7 File Offset: 0x003DB6C7
		// (set) Token: 0x0600E3A1 RID: 58273 RVA: 0x003DD4CF File Offset: 0x003DB6CF
		public int[] prop { get; set; }

		// Token: 0x1700184D RID: 6221
		// (get) Token: 0x0600E3A2 RID: 58274 RVA: 0x003DD4D8 File Offset: 0x003DB6D8
		// (set) Token: 0x0600E3A3 RID: 58275 RVA: 0x003DD4E0 File Offset: 0x003DB6E0
		public int[] reward { get; set; }

		// Token: 0x1700184E RID: 6222
		// (get) Token: 0x0600E3A4 RID: 58276 RVA: 0x003DD4E9 File Offset: 0x003DB6E9
		// (set) Token: 0x0600E3A5 RID: 58277 RVA: 0x003DD4F1 File Offset: 0x003DB6F1
		public int[] vipprice { get; set; }

		// Token: 0x1700184F RID: 6223
		// (get) Token: 0x0600E3A6 RID: 58278 RVA: 0x003DD4FA File Offset: 0x003DB6FA
		// (set) Token: 0x0600E3A7 RID: 58279 RVA: 0x003DD502 File Offset: 0x003DB702
		public int id { get; set; }

		// Token: 0x17001850 RID: 6224
		// (get) Token: 0x0600E3A8 RID: 58280 RVA: 0x003DD50B File Offset: 0x003DB70B
		// (set) Token: 0x0600E3A9 RID: 58281 RVA: 0x003DD513 File Offset: 0x003DB713
		public int label { get; set; }

		// Token: 0x17001851 RID: 6225
		// (get) Token: 0x0600E3AA RID: 58282 RVA: 0x003DD51C File Offset: 0x003DB71C
		// (set) Token: 0x0600E3AB RID: 58283 RVA: 0x003DD524 File Offset: 0x003DB724
		public int recommend { get; set; }

		// Token: 0x17001852 RID: 6226
		// (get) Token: 0x0600E3AC RID: 58284 RVA: 0x003DD52D File Offset: 0x003DB72D
		// (set) Token: 0x0600E3AD RID: 58285 RVA: 0x003DD535 File Offset: 0x003DB735
		public int show { get; set; }

		// Token: 0x17001853 RID: 6227
		// (get) Token: 0x0600E3AE RID: 58286 RVA: 0x003DD53E File Offset: 0x003DB73E
		// (set) Token: 0x0600E3AF RID: 58287 RVA: 0x003DD546 File Offset: 0x003DB746
		public int sort { get; set; }

		// Token: 0x17001854 RID: 6228
		// (get) Token: 0x0600E3B0 RID: 58288 RVA: 0x003DD54F File Offset: 0x003DB74F
		// (set) Token: 0x0600E3B1 RID: 58289 RVA: 0x003DD557 File Offset: 0x003DB757
		public int suit { get; set; }

		// Token: 0x17001855 RID: 6229
		// (get) Token: 0x0600E3B2 RID: 58290 RVA: 0x003DD560 File Offset: 0x003DB760
		// (set) Token: 0x0600E3B3 RID: 58291 RVA: 0x003DD568 File Offset: 0x003DB768
		public int type { get; set; }

		// Token: 0x17001856 RID: 6230
		// (get) Token: 0x0600E3B4 RID: 58292 RVA: 0x003DD571 File Offset: 0x003DB771
		// (set) Token: 0x0600E3B5 RID: 58293 RVA: 0x003DD579 File Offset: 0x003DB779
		public int vip { get; set; }

		// Token: 0x0600E3B6 RID: 58294 RVA: 0x003DD584 File Offset: 0x003DB784
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.label = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.miditem = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.miditem[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.price = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.price[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.prop = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					this.prop[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.recommend = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.reward = new int[num4];
				for (int l = 0; l < num4; l++)
				{
					this.reward[l] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.show = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.suit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.vip = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num5 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.vipprice = new int[num5];
				for (int m = 0; m < num5; m++)
				{
					this.vipprice[m] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
