using System;

namespace core.config
{
	// Token: 0x02001D66 RID: 7526
	public class IHelperInfo : IConfigItem
	{
		// Token: 0x17001561 RID: 5473
		// (get) Token: 0x0600DC6A RID: 56426 RVA: 0x003D450C File Offset: 0x003D270C
		// (set) Token: 0x0600DC6B RID: 56427 RVA: 0x003D4514 File Offset: 0x003D2714
		public string jump { get; set; }

		// Token: 0x17001562 RID: 5474
		// (get) Token: 0x0600DC6C RID: 56428 RVA: 0x003D451D File Offset: 0x003D271D
		// (set) Token: 0x0600DC6D RID: 56429 RVA: 0x003D4525 File Offset: 0x003D2725
		public string node { get; set; }

		// Token: 0x17001563 RID: 5475
		// (get) Token: 0x0600DC6E RID: 56430 RVA: 0x003D452E File Offset: 0x003D272E
		// (set) Token: 0x0600DC6F RID: 56431 RVA: 0x003D4536 File Offset: 0x003D2736
		public string picture { get; set; }

		// Token: 0x17001564 RID: 5476
		// (get) Token: 0x0600DC70 RID: 56432 RVA: 0x003D453F File Offset: 0x003D273F
		// (set) Token: 0x0600DC71 RID: 56433 RVA: 0x003D4547 File Offset: 0x003D2747
		public string searchword { get; set; }

		// Token: 0x17001565 RID: 5477
		// (get) Token: 0x0600DC72 RID: 56434 RVA: 0x003D4550 File Offset: 0x003D2750
		// (set) Token: 0x0600DC73 RID: 56435 RVA: 0x003D4558 File Offset: 0x003D2758
		public string text { get; set; }

		// Token: 0x17001566 RID: 5478
		// (get) Token: 0x0600DC74 RID: 56436 RVA: 0x003D4561 File Offset: 0x003D2761
		// (set) Token: 0x0600DC75 RID: 56437 RVA: 0x003D4569 File Offset: 0x003D2769
		public string title { get; set; }

		// Token: 0x17001567 RID: 5479
		// (get) Token: 0x0600DC76 RID: 56438 RVA: 0x003D4572 File Offset: 0x003D2772
		// (set) Token: 0x0600DC77 RID: 56439 RVA: 0x003D457A File Offset: 0x003D277A
		public int group { get; set; }

		// Token: 0x17001568 RID: 5480
		// (get) Token: 0x0600DC78 RID: 56440 RVA: 0x003D4583 File Offset: 0x003D2783
		// (set) Token: 0x0600DC79 RID: 56441 RVA: 0x003D458B File Offset: 0x003D278B
		public int id { get; set; }

		// Token: 0x17001569 RID: 5481
		// (get) Token: 0x0600DC7A RID: 56442 RVA: 0x003D4594 File Offset: 0x003D2794
		// (set) Token: 0x0600DC7B RID: 56443 RVA: 0x003D459C File Offset: 0x003D279C
		public int type { get; set; }

		// Token: 0x0600DC7C RID: 56444 RVA: 0x003D45A8 File Offset: 0x003D27A8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.group = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.jump = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.node = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.picture = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.searchword = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.text = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
