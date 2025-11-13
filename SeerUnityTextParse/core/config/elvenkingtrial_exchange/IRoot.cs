using System;

namespace core.config.elvenkingtrial_exchange
{
	// Token: 0x0200204F RID: 8271
	public class IRoot
	{
		// Token: 0x170020B2 RID: 8370
		// (get) Token: 0x0600FC95 RID: 64661 RVA: 0x0040213A File Offset: 0x0040033A
		// (set) Token: 0x0600FC96 RID: 64662 RVA: 0x00402142 File Offset: 0x00400342
		public IItems items { get; set; }

		// Token: 0x170020B3 RID: 8371
		// (get) Token: 0x0600FC97 RID: 64663 RVA: 0x0040214B File Offset: 0x0040034B
		// (set) Token: 0x0600FC98 RID: 64664 RVA: 0x00402153 File Offset: 0x00400353
		public IRewards rewards { get; set; }

		// Token: 0x170020B4 RID: 8372
		// (get) Token: 0x0600FC99 RID: 64665 RVA: 0x0040215C File Offset: 0x0040035C
		// (set) Token: 0x0600FC9A RID: 64666 RVA: 0x00402164 File Offset: 0x00400364
		public ISwaps swaps { get; set; }

		// Token: 0x0600FC9B RID: 64667 RVA: 0x00402170 File Offset: 0x00400370
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (this.b)
			{
				this.items = new IItems();
				this.items.Parse(bytes, ref byteIndex);
			}
			this.b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (this.b)
			{
				this.rewards = new IRewards();
				this.rewards.Parse(bytes, ref byteIndex);
			}
			this.b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (this.b)
			{
				this.swaps = new ISwaps();
				this.swaps.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0400F5FB RID: 62971
		private bool b;
	}
}
