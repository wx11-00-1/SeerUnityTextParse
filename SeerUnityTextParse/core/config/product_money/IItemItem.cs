using System;

namespace core.config.product_money
{
	// Token: 0x02001F33 RID: 7987
	public class IItemItem
	{
		// Token: 0x17001BC4 RID: 7108
		// (get) Token: 0x0600EF90 RID: 61328 RVA: 0x003F3BD0 File Offset: 0x003F1DD0
		// (set) Token: 0x0600EF91 RID: 61329 RVA: 0x003F3BD8 File Offset: 0x003F1DD8
		public string name { get; set; }

		// Token: 0x17001BC5 RID: 7109
		// (get) Token: 0x0600EF92 RID: 61330 RVA: 0x003F3BE1 File Offset: 0x003F1DE1
		// (set) Token: 0x0600EF93 RID: 61331 RVA: 0x003F3BE9 File Offset: 0x003F1DE9
		public int[] itemID { get; set; }

		// Token: 0x17001BC6 RID: 7110
		// (get) Token: 0x0600EF94 RID: 61332 RVA: 0x003F3BF2 File Offset: 0x003F1DF2
		// (set) Token: 0x0600EF95 RID: 61333 RVA: 0x003F3BFA File Offset: 0x003F1DFA
		public int gold { get; set; }

		// Token: 0x17001BC7 RID: 7111
		// (get) Token: 0x0600EF96 RID: 61334 RVA: 0x003F3C03 File Offset: 0x003F1E03
		// (set) Token: 0x0600EF97 RID: 61335 RVA: 0x003F3C0B File Offset: 0x003F1E0B
		public float price { get; set; }

		// Token: 0x17001BC8 RID: 7112
		// (get) Token: 0x0600EF98 RID: 61336 RVA: 0x003F3C14 File Offset: 0x003F1E14
		// (set) Token: 0x0600EF99 RID: 61337 RVA: 0x003F3C1C File Offset: 0x003F1E1C
		public int productID { get; set; }

		// Token: 0x17001BC9 RID: 7113
		// (get) Token: 0x0600EF9A RID: 61338 RVA: 0x003F3C25 File Offset: 0x003F1E25
		// (set) Token: 0x0600EF9B RID: 61339 RVA: 0x003F3C2D File Offset: 0x003F1E2D
		public int vip { get; set; }

		// Token: 0x0600EF9C RID: 61340 RVA: 0x003F3C38 File Offset: 0x003F1E38
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.gold = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.itemID = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.itemID[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.price = ByteUtil.ReadFloat(bytes, ref byteIndex);
			this.productID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.vip = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
