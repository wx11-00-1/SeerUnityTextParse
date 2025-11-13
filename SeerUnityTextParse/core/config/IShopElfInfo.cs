using System;

namespace core.config
{
	// Token: 0x02001E1A RID: 7706
	public class IShopElfInfo : IConfigItem
	{
		// Token: 0x17001864 RID: 6244
		// (get) Token: 0x0600E3D8 RID: 58328 RVA: 0x003DD9F8 File Offset: 0x003DBBF8
		// (set) Token: 0x0600E3D9 RID: 58329 RVA: 0x003DDA00 File Offset: 0x003DBC00
		public string name { get; set; }

		// Token: 0x17001865 RID: 6245
		// (get) Token: 0x0600E3DA RID: 58330 RVA: 0x003DDA09 File Offset: 0x003DBC09
		// (set) Token: 0x0600E3DB RID: 58331 RVA: 0x003DDA11 File Offset: 0x003DBC11
		public string reward { get; set; }

		// Token: 0x17001866 RID: 6246
		// (get) Token: 0x0600E3DC RID: 58332 RVA: 0x003DDA1A File Offset: 0x003DBC1A
		// (set) Token: 0x0600E3DD RID: 58333 RVA: 0x003DDA22 File Offset: 0x003DBC22
		public int[] discountprice { get; set; }

		// Token: 0x17001867 RID: 6247
		// (get) Token: 0x0600E3DE RID: 58334 RVA: 0x003DDA2B File Offset: 0x003DBC2B
		// (set) Token: 0x0600E3DF RID: 58335 RVA: 0x003DDA33 File Offset: 0x003DBC33
		public int[] gift { get; set; }

		// Token: 0x17001868 RID: 6248
		// (get) Token: 0x0600E3E0 RID: 58336 RVA: 0x003DDA3C File Offset: 0x003DBC3C
		// (set) Token: 0x0600E3E1 RID: 58337 RVA: 0x003DDA44 File Offset: 0x003DBC44
		public int[] price { get; set; }

		// Token: 0x17001869 RID: 6249
		// (get) Token: 0x0600E3E2 RID: 58338 RVA: 0x003DDA4D File Offset: 0x003DBC4D
		// (set) Token: 0x0600E3E3 RID: 58339 RVA: 0x003DDA55 File Offset: 0x003DBC55
		public int discount { get; set; }

		// Token: 0x1700186A RID: 6250
		// (get) Token: 0x0600E3E4 RID: 58340 RVA: 0x003DDA5E File Offset: 0x003DBC5E
		// (set) Token: 0x0600E3E5 RID: 58341 RVA: 0x003DDA66 File Offset: 0x003DBC66
		public int id { get; set; }

		// Token: 0x1700186B RID: 6251
		// (get) Token: 0x0600E3E6 RID: 58342 RVA: 0x003DDA6F File Offset: 0x003DBC6F
		// (set) Token: 0x0600E3E7 RID: 58343 RVA: 0x003DDA77 File Offset: 0x003DBC77
		public int miditem { get; set; }

		// Token: 0x1700186C RID: 6252
		// (get) Token: 0x0600E3E8 RID: 58344 RVA: 0x003DDA80 File Offset: 0x003DBC80
		// (set) Token: 0x0600E3E9 RID: 58345 RVA: 0x003DDA88 File Offset: 0x003DBC88
		public int prop { get; set; }

		// Token: 0x1700186D RID: 6253
		// (get) Token: 0x0600E3EA RID: 58346 RVA: 0x003DDA91 File Offset: 0x003DBC91
		// (set) Token: 0x0600E3EB RID: 58347 RVA: 0x003DDA99 File Offset: 0x003DBC99
		public int quota { get; set; }

		// Token: 0x1700186E RID: 6254
		// (get) Token: 0x0600E3EC RID: 58348 RVA: 0x003DDAA2 File Offset: 0x003DBCA2
		// (set) Token: 0x0600E3ED RID: 58349 RVA: 0x003DDAAA File Offset: 0x003DBCAA
		public int recommend { get; set; }

		// Token: 0x1700186F RID: 6255
		// (get) Token: 0x0600E3EE RID: 58350 RVA: 0x003DDAB3 File Offset: 0x003DBCB3
		// (set) Token: 0x0600E3EF RID: 58351 RVA: 0x003DDABB File Offset: 0x003DBCBB
		public int show { get; set; }

		// Token: 0x17001870 RID: 6256
		// (get) Token: 0x0600E3F0 RID: 58352 RVA: 0x003DDAC4 File Offset: 0x003DBCC4
		// (set) Token: 0x0600E3F1 RID: 58353 RVA: 0x003DDACC File Offset: 0x003DBCCC
		public int sort { get; set; }

		// Token: 0x17001871 RID: 6257
		// (get) Token: 0x0600E3F2 RID: 58354 RVA: 0x003DDAD5 File Offset: 0x003DBCD5
		// (set) Token: 0x0600E3F3 RID: 58355 RVA: 0x003DDADD File Offset: 0x003DBCDD
		public int type { get; set; }

		// Token: 0x0600E3F4 RID: 58356 RVA: 0x003DDAE8 File Offset: 0x003DBCE8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.discount = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.discountprice = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.discountprice[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.gift = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.gift[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.miditem = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.price = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					this.price[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.prop = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.quota = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.recommend = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.show = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
