using System;

namespace core.config
{
	// Token: 0x02001E36 RID: 7734
	public class ISpHideMovesShopInfo : IConfigItem
	{
		// Token: 0x170018EB RID: 6379
		// (get) Token: 0x0600E51E RID: 58654 RVA: 0x003DF3F0 File Offset: 0x003DD5F0
		// (set) Token: 0x0600E51F RID: 58655 RVA: 0x003DF3F8 File Offset: 0x003DD5F8
		public string ItemName { get; set; }

		// Token: 0x170018EC RID: 6380
		// (get) Token: 0x0600E520 RID: 58656 RVA: 0x003DF401 File Offset: 0x003DD601
		// (set) Token: 0x0600E521 RID: 58657 RVA: 0x003DF409 File Offset: 0x003DD609
		public int CoinId { get; set; }

		// Token: 0x170018ED RID: 6381
		// (get) Token: 0x0600E522 RID: 58658 RVA: 0x003DF412 File Offset: 0x003DD612
		// (set) Token: 0x0600E523 RID: 58659 RVA: 0x003DF41A File Offset: 0x003DD61A
		public int id { get; set; }

		// Token: 0x170018EE RID: 6382
		// (get) Token: 0x0600E524 RID: 58660 RVA: 0x003DF423 File Offset: 0x003DD623
		// (set) Token: 0x0600E525 RID: 58661 RVA: 0x003DF42B File Offset: 0x003DD62B
		public int ItemId { get; set; }

		// Token: 0x170018EF RID: 6383
		// (get) Token: 0x0600E526 RID: 58662 RVA: 0x003DF434 File Offset: 0x003DD634
		// (set) Token: 0x0600E527 RID: 58663 RVA: 0x003DF43C File Offset: 0x003DD63C
		public int Limit { get; set; }

		// Token: 0x170018F0 RID: 6384
		// (get) Token: 0x0600E528 RID: 58664 RVA: 0x003DF445 File Offset: 0x003DD645
		// (set) Token: 0x0600E529 RID: 58665 RVA: 0x003DF44D File Offset: 0x003DD64D
		public int MonsterId { get; set; }

		// Token: 0x170018F1 RID: 6385
		// (get) Token: 0x0600E52A RID: 58666 RVA: 0x003DF456 File Offset: 0x003DD656
		// (set) Token: 0x0600E52B RID: 58667 RVA: 0x003DF45E File Offset: 0x003DD65E
		public int MoveId { get; set; }

		// Token: 0x170018F2 RID: 6386
		// (get) Token: 0x0600E52C RID: 58668 RVA: 0x003DF467 File Offset: 0x003DD667
		// (set) Token: 0x0600E52D RID: 58669 RVA: 0x003DF46F File Offset: 0x003DD66F
		public int Price { get; set; }

		// Token: 0x170018F3 RID: 6387
		// (get) Token: 0x0600E52E RID: 58670 RVA: 0x003DF478 File Offset: 0x003DD678
		// (set) Token: 0x0600E52F RID: 58671 RVA: 0x003DF480 File Offset: 0x003DD680
		public int UserInfoId { get; set; }

		// Token: 0x170018F4 RID: 6388
		// (get) Token: 0x0600E530 RID: 58672 RVA: 0x003DF489 File Offset: 0x003DD689
		// (set) Token: 0x0600E531 RID: 58673 RVA: 0x003DF491 File Offset: 0x003DD691
		public int UserInfoPos { get; set; }

		// Token: 0x0600E532 RID: 58674 RVA: 0x003DF49C File Offset: 0x003DD69C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.CoinId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ItemId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ItemName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Limit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MonsterId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MoveId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.UserInfoId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.UserInfoPos = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
