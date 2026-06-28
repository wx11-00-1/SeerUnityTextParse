using System;

namespace core.config
{
	// Token: 0x020027D9 RID: 10201
	public class ISkinStoregachaInfo : IConfigItem
	{
		// Token: 0x170022FC RID: 8956
		// (get) Token: 0x06014495 RID: 83093 RVA: 0x005673A8 File Offset: 0x005655A8
		// (set) Token: 0x06014496 RID: 83094 RVA: 0x005673B0 File Offset: 0x005655B0
		public string Des { get; set; }

		// Token: 0x170022FD RID: 8957
		// (get) Token: 0x06014497 RID: 83095 RVA: 0x005673B9 File Offset: 0x005655B9
		// (set) Token: 0x06014498 RID: 83096 RVA: 0x005673C1 File Offset: 0x005655C1
		public string Name { get; set; }

		// Token: 0x170022FE RID: 8958
		// (get) Token: 0x06014499 RID: 83097 RVA: 0x005673CA File Offset: 0x005655CA
		// (set) Token: 0x0601449A RID: 83098 RVA: 0x005673D2 File Offset: 0x005655D2
		public int DiamondPrice { get; set; }

		// Token: 0x170022FF RID: 8959
		// (get) Token: 0x0601449B RID: 83099 RVA: 0x005673DB File Offset: 0x005655DB
		// (set) Token: 0x0601449C RID: 83100 RVA: 0x005673E3 File Offset: 0x005655E3
		public int id { get; set; }

		// Token: 0x17002300 RID: 8960
		// (get) Token: 0x0601449D RID: 83101 RVA: 0x005673EC File Offset: 0x005655EC
		// (set) Token: 0x0601449E RID: 83102 RVA: 0x005673F4 File Offset: 0x005655F4
		public int item_id { get; set; }

		// Token: 0x17002301 RID: 8961
		// (get) Token: 0x0601449F RID: 83103 RVA: 0x005673FD File Offset: 0x005655FD
		// (set) Token: 0x060144A0 RID: 83104 RVA: 0x00567405 File Offset: 0x00565605
		public int MonID { get; set; }

		// Token: 0x17002302 RID: 8962
		// (get) Token: 0x060144A1 RID: 83105 RVA: 0x0056740E File Offset: 0x0056560E
		// (set) Token: 0x060144A2 RID: 83106 RVA: 0x00567416 File Offset: 0x00565616
		public int ProductId { get; set; }

		// Token: 0x17002303 RID: 8963
		// (get) Token: 0x060144A3 RID: 83107 RVA: 0x0056741F File Offset: 0x0056561F
		// (set) Token: 0x060144A4 RID: 83108 RVA: 0x00567427 File Offset: 0x00565627
		public int SkinID { get; set; }

		// Token: 0x060144A5 RID: 83109 RVA: 0x00567430 File Offset: 0x00565630
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.DiamondPrice = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MonID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ProductId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.SkinID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.item_id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
