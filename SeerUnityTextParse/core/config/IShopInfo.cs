using System;

namespace core.config
{
	// Token: 0x02001E14 RID: 7700
	public class IShopInfo : IConfigItem
	{
		// Token: 0x17001841 RID: 6209
		// (get) Token: 0x0600E386 RID: 58246 RVA: 0x003DD330 File Offset: 0x003DB530
		// (set) Token: 0x0600E387 RID: 58247 RVA: 0x003DD338 File Offset: 0x003DB538
		public int Discountprice { get; set; }

		// Token: 0x17001842 RID: 6210
		// (get) Token: 0x0600E388 RID: 58248 RVA: 0x003DD341 File Offset: 0x003DB541
		// (set) Token: 0x0600E389 RID: 58249 RVA: 0x003DD349 File Offset: 0x003DB549
		public int exchangeId { get; set; }

		// Token: 0x17001843 RID: 6211
		// (get) Token: 0x0600E38A RID: 58250 RVA: 0x003DD352 File Offset: 0x003DB552
		// (set) Token: 0x0600E38B RID: 58251 RVA: 0x003DD35A File Offset: 0x003DB55A
		public int id { get; set; }

		// Token: 0x17001844 RID: 6212
		// (get) Token: 0x0600E38C RID: 58252 RVA: 0x003DD363 File Offset: 0x003DB563
		// (set) Token: 0x0600E38D RID: 58253 RVA: 0x003DD36B File Offset: 0x003DB56B
		public int itemID { get; set; }

		// Token: 0x17001845 RID: 6213
		// (get) Token: 0x0600E38E RID: 58254 RVA: 0x003DD374 File Offset: 0x003DB574
		// (set) Token: 0x0600E38F RID: 58255 RVA: 0x003DD37C File Offset: 0x003DB57C
		public int limittype { get; set; }

		// Token: 0x17001846 RID: 6214
		// (get) Token: 0x0600E390 RID: 58256 RVA: 0x003DD385 File Offset: 0x003DB585
		// (set) Token: 0x0600E391 RID: 58257 RVA: 0x003DD38D File Offset: 0x003DB58D
		public int productID { get; set; }

		// Token: 0x17001847 RID: 6215
		// (get) Token: 0x0600E392 RID: 58258 RVA: 0x003DD396 File Offset: 0x003DB596
		// (set) Token: 0x0600E393 RID: 58259 RVA: 0x003DD39E File Offset: 0x003DB59E
		public int usenew { get; set; }

		// Token: 0x0600E394 RID: 58260 RVA: 0x003DD3A8 File Offset: 0x003DB5A8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Discountprice = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.exchangeId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.itemID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.limittype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.productID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.usenew = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
