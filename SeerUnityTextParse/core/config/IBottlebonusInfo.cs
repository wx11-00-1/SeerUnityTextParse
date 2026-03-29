using System;

namespace core.config
{
	// Token: 0x02002185 RID: 8581
	public class IBottlebonusInfo : IConfigItem
	{
		// Token: 0x17001643 RID: 5699
		// (get) Token: 0x06010010 RID: 65552 RVA: 0x00481200 File Offset: 0x0047F400
		// (set) Token: 0x06010011 RID: 65553 RVA: 0x00481208 File Offset: 0x0047F408
		public int exchangecut { get; set; }

		// Token: 0x17001644 RID: 5700
		// (get) Token: 0x06010012 RID: 65554 RVA: 0x00481211 File Offset: 0x0047F411
		// (set) Token: 0x06010013 RID: 65555 RVA: 0x00481219 File Offset: 0x0047F419
		public int exchangenum { get; set; }

		// Token: 0x17001645 RID: 5701
		// (get) Token: 0x06010014 RID: 65556 RVA: 0x00481222 File Offset: 0x0047F422
		// (set) Token: 0x06010015 RID: 65557 RVA: 0x0048122A File Offset: 0x0047F42A
		public int id { get; set; }

		// Token: 0x17001646 RID: 5702
		// (get) Token: 0x06010016 RID: 65558 RVA: 0x00481233 File Offset: 0x0047F433
		// (set) Token: 0x06010017 RID: 65559 RVA: 0x0048123B File Offset: 0x0047F43B
		public int needcnt { get; set; }

		// Token: 0x17001647 RID: 5703
		// (get) Token: 0x06010018 RID: 65560 RVA: 0x00481244 File Offset: 0x0047F444
		// (set) Token: 0x06010019 RID: 65561 RVA: 0x0048124C File Offset: 0x0047F44C
		public int needitem { get; set; }

		// Token: 0x17001648 RID: 5704
		// (get) Token: 0x0601001A RID: 65562 RVA: 0x00481255 File Offset: 0x0047F455
		// (set) Token: 0x0601001B RID: 65563 RVA: 0x0048125D File Offset: 0x0047F45D
		public int output { get; set; }

		// Token: 0x17001649 RID: 5705
		// (get) Token: 0x0601001C RID: 65564 RVA: 0x00481266 File Offset: 0x0047F466
		// (set) Token: 0x0601001D RID: 65565 RVA: 0x0048126E File Offset: 0x0047F46E
		public int realid { get; set; }

		// Token: 0x1700164A RID: 5706
		// (get) Token: 0x0601001E RID: 65566 RVA: 0x00481277 File Offset: 0x0047F477
		// (set) Token: 0x0601001F RID: 65567 RVA: 0x0048127F File Offset: 0x0047F47F
		public int type { get; set; }

		// Token: 0x06010020 RID: 65568 RVA: 0x00481288 File Offset: 0x0047F488
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.exchangecut = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.exchangenum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.needcnt = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.needitem = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.output = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.realid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
