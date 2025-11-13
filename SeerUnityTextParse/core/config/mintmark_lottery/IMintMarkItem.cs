using System;

namespace core.config.mintmark_lottery
{
	// Token: 0x02001FBE RID: 8126
	public class IMintMarkItem
	{
		// Token: 0x17001DDC RID: 7644
		// (get) Token: 0x0600F4D6 RID: 62678 RVA: 0x003FA1FB File Offset: 0x003F83FB
		// (set) Token: 0x0600F4D7 RID: 62679 RVA: 0x003FA203 File Offset: 0x003F8403
		public string Des { get; set; }

		// Token: 0x17001DDD RID: 7645
		// (get) Token: 0x0600F4D8 RID: 62680 RVA: 0x003FA20C File Offset: 0x003F840C
		// (set) Token: 0x0600F4D9 RID: 62681 RVA: 0x003FA214 File Offset: 0x003F8414
		public int exchangeId { get; set; }

		// Token: 0x17001DDE RID: 7646
		// (get) Token: 0x0600F4DA RID: 62682 RVA: 0x003FA21D File Offset: 0x003F841D
		// (set) Token: 0x0600F4DB RID: 62683 RVA: 0x003FA225 File Offset: 0x003F8425
		public int ID { get; set; }

		// Token: 0x17001DDF RID: 7647
		// (get) Token: 0x0600F4DC RID: 62684 RVA: 0x003FA22E File Offset: 0x003F842E
		// (set) Token: 0x0600F4DD RID: 62685 RVA: 0x003FA236 File Offset: 0x003F8436
		public int Level { get; set; }

		// Token: 0x17001DE0 RID: 7648
		// (get) Token: 0x0600F4DE RID: 62686 RVA: 0x003FA23F File Offset: 0x003F843F
		// (set) Token: 0x0600F4DF RID: 62687 RVA: 0x003FA247 File Offset: 0x003F8447
		public int maxNum { get; set; }

		// Token: 0x17001DE1 RID: 7649
		// (get) Token: 0x0600F4E0 RID: 62688 RVA: 0x003FA250 File Offset: 0x003F8450
		// (set) Token: 0x0600F4E1 RID: 62689 RVA: 0x003FA258 File Offset: 0x003F8458
		public int price { get; set; }

		// Token: 0x17001DE2 RID: 7650
		// (get) Token: 0x0600F4E2 RID: 62690 RVA: 0x003FA261 File Offset: 0x003F8461
		// (set) Token: 0x0600F4E3 RID: 62691 RVA: 0x003FA269 File Offset: 0x003F8469
		public int puton { get; set; }

		// Token: 0x0600F4E4 RID: 62692 RVA: 0x003FA274 File Offset: 0x003F8474
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.exchangeId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.maxNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.puton = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
