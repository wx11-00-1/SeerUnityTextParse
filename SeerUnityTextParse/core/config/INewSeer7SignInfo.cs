using System;

namespace core.config
{
	// Token: 0x02001DA6 RID: 7590
	public class INewSeer7SignInfo : IConfigItem
	{
		// Token: 0x17001651 RID: 5713
		// (get) Token: 0x0600DECA RID: 57034 RVA: 0x003D74F8 File Offset: 0x003D56F8
		// (set) Token: 0x0600DECB RID: 57035 RVA: 0x003D7500 File Offset: 0x003D5700
		public string Daycount { get; set; }

		// Token: 0x17001652 RID: 5714
		// (get) Token: 0x0600DECC RID: 57036 RVA: 0x003D7509 File Offset: 0x003D5709
		// (set) Token: 0x0600DECD RID: 57037 RVA: 0x003D7511 File Offset: 0x003D5711
		public string GiftID { get; set; }

		// Token: 0x17001653 RID: 5715
		// (get) Token: 0x0600DECE RID: 57038 RVA: 0x003D751A File Offset: 0x003D571A
		// (set) Token: 0x0600DECF RID: 57039 RVA: 0x003D7522 File Offset: 0x003D5722
		public string GiftName { get; set; }

		// Token: 0x17001654 RID: 5716
		// (get) Token: 0x0600DED0 RID: 57040 RVA: 0x003D752B File Offset: 0x003D572B
		// (set) Token: 0x0600DED1 RID: 57041 RVA: 0x003D7533 File Offset: 0x003D5733
		public string GiftType { get; set; }

		// Token: 0x17001655 RID: 5717
		// (get) Token: 0x0600DED2 RID: 57042 RVA: 0x003D753C File Offset: 0x003D573C
		// (set) Token: 0x0600DED3 RID: 57043 RVA: 0x003D7544 File Offset: 0x003D5744
		public int Amount { get; set; }

		// Token: 0x17001656 RID: 5718
		// (get) Token: 0x0600DED4 RID: 57044 RVA: 0x003D754D File Offset: 0x003D574D
		// (set) Token: 0x0600DED5 RID: 57045 RVA: 0x003D7555 File Offset: 0x003D5755
		public int id { get; set; }

		// Token: 0x17001657 RID: 5719
		// (get) Token: 0x0600DED6 RID: 57046 RVA: 0x003D755E File Offset: 0x003D575E
		// (set) Token: 0x0600DED7 RID: 57047 RVA: 0x003D7566 File Offset: 0x003D5766
		public int Rare { get; set; }

		// Token: 0x0600DED8 RID: 57048 RVA: 0x003D7570 File Offset: 0x003D5770
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Amount = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Daycount = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.GiftID = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.GiftName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.GiftType = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Rare = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
