using System;

namespace core.config
{
	// Token: 0x02001DBA RID: 7610
	public class IPassShopInfo : IConfigItem
	{
		// Token: 0x170016C6 RID: 5830
		// (get) Token: 0x0600DFDC RID: 57308 RVA: 0x003D89D0 File Offset: 0x003D6BD0
		// (set) Token: 0x0600DFDD RID: 57309 RVA: 0x003D89D8 File Offset: 0x003D6BD8
		public string commodity { get; set; }

		// Token: 0x170016C7 RID: 5831
		// (get) Token: 0x0600DFDE RID: 57310 RVA: 0x003D89E1 File Offset: 0x003D6BE1
		// (set) Token: 0x0600DFDF RID: 57311 RVA: 0x003D89E9 File Offset: 0x003D6BE9
		public int consumeitemid { get; set; }

		// Token: 0x170016C8 RID: 5832
		// (get) Token: 0x0600DFE0 RID: 57312 RVA: 0x003D89F2 File Offset: 0x003D6BF2
		// (set) Token: 0x0600DFE1 RID: 57313 RVA: 0x003D89FA File Offset: 0x003D6BFA
		public int discount { get; set; }

		// Token: 0x170016C9 RID: 5833
		// (get) Token: 0x0600DFE2 RID: 57314 RVA: 0x003D8A03 File Offset: 0x003D6C03
		// (set) Token: 0x0600DFE3 RID: 57315 RVA: 0x003D8A0B File Offset: 0x003D6C0B
		public int id { get; set; }

		// Token: 0x170016CA RID: 5834
		// (get) Token: 0x0600DFE4 RID: 57316 RVA: 0x003D8A14 File Offset: 0x003D6C14
		// (set) Token: 0x0600DFE5 RID: 57317 RVA: 0x003D8A1C File Offset: 0x003D6C1C
		public int limit { get; set; }

		// Token: 0x170016CB RID: 5835
		// (get) Token: 0x0600DFE6 RID: 57318 RVA: 0x003D8A25 File Offset: 0x003D6C25
		// (set) Token: 0x0600DFE7 RID: 57319 RVA: 0x003D8A2D File Offset: 0x003D6C2D
		public int price { get; set; }

		// Token: 0x170016CC RID: 5836
		// (get) Token: 0x0600DFE8 RID: 57320 RVA: 0x003D8A36 File Offset: 0x003D6C36
		// (set) Token: 0x0600DFE9 RID: 57321 RVA: 0x003D8A3E File Offset: 0x003D6C3E
		public int quantity { get; set; }

		// Token: 0x170016CD RID: 5837
		// (get) Token: 0x0600DFEA RID: 57322 RVA: 0x003D8A47 File Offset: 0x003D6C47
		// (set) Token: 0x0600DFEB RID: 57323 RVA: 0x003D8A4F File Offset: 0x003D6C4F
		public int sort { get; set; }

		// Token: 0x170016CE RID: 5838
		// (get) Token: 0x0600DFEC RID: 57324 RVA: 0x003D8A58 File Offset: 0x003D6C58
		// (set) Token: 0x0600DFED RID: 57325 RVA: 0x003D8A60 File Offset: 0x003D6C60
		public int userinfo { get; set; }

		// Token: 0x0600DFEE RID: 57326 RVA: 0x003D8A6C File Offset: 0x003D6C6C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.commodity = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.consumeitemid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.discount = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.limit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.quantity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.userinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
