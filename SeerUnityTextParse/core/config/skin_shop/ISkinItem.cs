using System;

namespace core.config.skin_shop
{
	// Token: 0x02001F1E RID: 7966
	public class ISkinItem
	{
		// Token: 0x17001B63 RID: 7011
		// (get) Token: 0x0600EEA4 RID: 61092 RVA: 0x003F2A20 File Offset: 0x003F0C20
		// (set) Token: 0x0600EEA5 RID: 61093 RVA: 0x003F2A28 File Offset: 0x003F0C28
		public string Name { get; set; }

		// Token: 0x17001B64 RID: 7012
		// (get) Token: 0x0600EEA6 RID: 61094 RVA: 0x003F2A31 File Offset: 0x003F0C31
		// (set) Token: 0x0600EEA7 RID: 61095 RVA: 0x003F2A39 File Offset: 0x003F0C39
		public int[] Show { get; set; }

		// Token: 0x17001B65 RID: 7013
		// (get) Token: 0x0600EEA8 RID: 61096 RVA: 0x003F2A42 File Offset: 0x003F0C42
		// (set) Token: 0x0600EEA9 RID: 61097 RVA: 0x003F2A4A File Offset: 0x003F0C4A
		public int Batch { get; set; }

		// Token: 0x17001B66 RID: 7014
		// (get) Token: 0x0600EEAA RID: 61098 RVA: 0x003F2A53 File Offset: 0x003F0C53
		// (set) Token: 0x0600EEAB RID: 61099 RVA: 0x003F2A5B File Offset: 0x003F0C5B
		public int CardPrice { get; set; }

		// Token: 0x17001B67 RID: 7015
		// (get) Token: 0x0600EEAC RID: 61100 RVA: 0x003F2A64 File Offset: 0x003F0C64
		// (set) Token: 0x0600EEAD RID: 61101 RVA: 0x003F2A6C File Offset: 0x003F0C6C
		public int DiamondPrice { get; set; }

		// Token: 0x17001B68 RID: 7016
		// (get) Token: 0x0600EEAE RID: 61102 RVA: 0x003F2A75 File Offset: 0x003F0C75
		// (set) Token: 0x0600EEAF RID: 61103 RVA: 0x003F2A7D File Offset: 0x003F0C7D
		public int ID { get; set; }

		// Token: 0x17001B69 RID: 7017
		// (get) Token: 0x0600EEB0 RID: 61104 RVA: 0x003F2A86 File Offset: 0x003F0C86
		// (set) Token: 0x0600EEB1 RID: 61105 RVA: 0x003F2A8E File Offset: 0x003F0C8E
		public int MonID { get; set; }

		// Token: 0x17001B6A RID: 7018
		// (get) Token: 0x0600EEB2 RID: 61106 RVA: 0x003F2A97 File Offset: 0x003F0C97
		// (set) Token: 0x0600EEB3 RID: 61107 RVA: 0x003F2A9F File Offset: 0x003F0C9F
		public int OriginalPrice { get; set; }

		// Token: 0x17001B6B RID: 7019
		// (get) Token: 0x0600EEB4 RID: 61108 RVA: 0x003F2AA8 File Offset: 0x003F0CA8
		// (set) Token: 0x0600EEB5 RID: 61109 RVA: 0x003F2AB0 File Offset: 0x003F0CB0
		public int ProductId { get; set; }

		// Token: 0x17001B6C RID: 7020
		// (get) Token: 0x0600EEB6 RID: 61110 RVA: 0x003F2AB9 File Offset: 0x003F0CB9
		// (set) Token: 0x0600EEB7 RID: 61111 RVA: 0x003F2AC1 File Offset: 0x003F0CC1
		public int Rec { get; set; }

		// Token: 0x17001B6D RID: 7021
		// (get) Token: 0x0600EEB8 RID: 61112 RVA: 0x003F2ACA File Offset: 0x003F0CCA
		// (set) Token: 0x0600EEB9 RID: 61113 RVA: 0x003F2AD2 File Offset: 0x003F0CD2
		public int SkinID { get; set; }

		// Token: 0x0600EEBA RID: 61114 RVA: 0x003F2ADC File Offset: 0x003F0CDC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Batch = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.CardPrice = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.DiamondPrice = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MonID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.OriginalPrice = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ProductId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Rec = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Show = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.Show[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.SkinID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0400F0C7 RID: 61639
		public int dayLeft;

		// Token: 0x0400F0C8 RID: 61640
		public int popType;

		// Token: 0x0400F0C9 RID: 61641
		public bool hasBuy;
	}
}
