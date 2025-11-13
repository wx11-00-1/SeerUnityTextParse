using System;

namespace core.config.midleExchangeItems
{
	// Token: 0x02001FC9 RID: 8137
	public class IItemsItem
	{
		// Token: 0x17001E08 RID: 7688
		// (get) Token: 0x0600F544 RID: 62788 RVA: 0x003FAAC5 File Offset: 0x003F8CC5
		// (set) Token: 0x0600F545 RID: 62789 RVA: 0x003FAACD File Offset: 0x003F8CCD
		public string ExchangeOutCnt { get; set; }

		// Token: 0x17001E09 RID: 7689
		// (get) Token: 0x0600F546 RID: 62790 RVA: 0x003FAAD6 File Offset: 0x003F8CD6
		// (set) Token: 0x0600F547 RID: 62791 RVA: 0x003FAADE File Offset: 0x003F8CDE
		public string ExchangeOutId { get; set; }

		// Token: 0x17001E0A RID: 7690
		// (get) Token: 0x0600F548 RID: 62792 RVA: 0x003FAAE7 File Offset: 0x003F8CE7
		// (set) Token: 0x0600F549 RID: 62793 RVA: 0x003FAAEF File Offset: 0x003F8CEF
		public string Name { get; set; }

		// Token: 0x17001E0B RID: 7691
		// (get) Token: 0x0600F54A RID: 62794 RVA: 0x003FAAF8 File Offset: 0x003F8CF8
		// (set) Token: 0x0600F54B RID: 62795 RVA: 0x003FAB00 File Offset: 0x003F8D00
		public int catID { get; set; }

		// Token: 0x17001E0C RID: 7692
		// (get) Token: 0x0600F54C RID: 62796 RVA: 0x003FAB09 File Offset: 0x003F8D09
		// (set) Token: 0x0600F54D RID: 62797 RVA: 0x003FAB11 File Offset: 0x003F8D11
		public int ExchangeId { get; set; }

		// Token: 0x17001E0D RID: 7693
		// (get) Token: 0x0600F54E RID: 62798 RVA: 0x003FAB1A File Offset: 0x003F8D1A
		// (set) Token: 0x0600F54F RID: 62799 RVA: 0x003FAB22 File Offset: 0x003F8D22
		public int ExchangeType { get; set; }

		// Token: 0x17001E0E RID: 7694
		// (get) Token: 0x0600F550 RID: 62800 RVA: 0x003FAB2B File Offset: 0x003F8D2B
		// (set) Token: 0x0600F551 RID: 62801 RVA: 0x003FAB33 File Offset: 0x003F8D33
		public int ID { get; set; }

		// Token: 0x17001E0F RID: 7695
		// (get) Token: 0x0600F552 RID: 62802 RVA: 0x003FAB3C File Offset: 0x003F8D3C
		// (set) Token: 0x0600F553 RID: 62803 RVA: 0x003FAB44 File Offset: 0x003F8D44
		public int Max { get; set; }

		// Token: 0x17001E10 RID: 7696
		// (get) Token: 0x0600F554 RID: 62804 RVA: 0x003FAB4D File Offset: 0x003F8D4D
		// (set) Token: 0x0600F555 RID: 62805 RVA: 0x003FAB55 File Offset: 0x003F8D55
		public int SkinId { get; set; }

		// Token: 0x17001E11 RID: 7697
		// (get) Token: 0x0600F556 RID: 62806 RVA: 0x003FAB5E File Offset: 0x003F8D5E
		// (set) Token: 0x0600F557 RID: 62807 RVA: 0x003FAB66 File Offset: 0x003F8D66
		public int TargetId { get; set; }

		// Token: 0x0600F558 RID: 62808 RVA: 0x003FAB70 File Offset: 0x003F8D70
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ExchangeId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ExchangeOutCnt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ExchangeOutId = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ExchangeType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.SkinId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.TargetId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
