using System;

namespace core.config
{
	// Token: 0x02002045 RID: 8261
	public class INewSetGameInfo : IConfigItem
	{
		// Token: 0x17001913 RID: 6419
		// (get) Token: 0x0600F89C RID: 63644 RVA: 0x0043D258 File Offset: 0x0043B458
		// (set) Token: 0x0600F89D RID: 63645 RVA: 0x0043D260 File Offset: 0x0043B460
		public string conditionDesc { get; set; }

		// Token: 0x17001914 RID: 6420
		// (get) Token: 0x0600F89E RID: 63646 RVA: 0x0043D269 File Offset: 0x0043B469
		// (set) Token: 0x0600F89F RID: 63647 RVA: 0x0043D271 File Offset: 0x0043B471
		public string petName { get; set; }

		// Token: 0x17001915 RID: 6421
		// (get) Token: 0x0600F8A0 RID: 63648 RVA: 0x0043D27A File Offset: 0x0043B47A
		// (set) Token: 0x0600F8A1 RID: 63649 RVA: 0x0043D282 File Offset: 0x0043B482
		public int axis { get; set; }

		// Token: 0x17001916 RID: 6422
		// (get) Token: 0x0600F8A2 RID: 63650 RVA: 0x0043D28B File Offset: 0x0043B48B
		// (set) Token: 0x0600F8A3 RID: 63651 RVA: 0x0043D293 File Offset: 0x0043B493
		public int effectType { get; set; }

		// Token: 0x17001917 RID: 6423
		// (get) Token: 0x0600F8A4 RID: 63652 RVA: 0x0043D29C File Offset: 0x0043B49C
		// (set) Token: 0x0600F8A5 RID: 63653 RVA: 0x0043D2A4 File Offset: 0x0043B4A4
		public int extraParam { get; set; }

		// Token: 0x17001918 RID: 6424
		// (get) Token: 0x0600F8A6 RID: 63654 RVA: 0x0043D2AD File Offset: 0x0043B4AD
		// (set) Token: 0x0600F8A7 RID: 63655 RVA: 0x0043D2B5 File Offset: 0x0043B4B5
		public int id { get; set; }

		// Token: 0x17001919 RID: 6425
		// (get) Token: 0x0600F8A8 RID: 63656 RVA: 0x0043D2BE File Offset: 0x0043B4BE
		// (set) Token: 0x0600F8A9 RID: 63657 RVA: 0x0043D2C6 File Offset: 0x0043B4C6
		public int levelid { get; set; }

		// Token: 0x1700191A RID: 6426
		// (get) Token: 0x0600F8AA RID: 63658 RVA: 0x0043D2CF File Offset: 0x0043B4CF
		// (set) Token: 0x0600F8AB RID: 63659 RVA: 0x0043D2D7 File Offset: 0x0043B4D7
		public int petid { get; set; }

		// Token: 0x1700191B RID: 6427
		// (get) Token: 0x0600F8AC RID: 63660 RVA: 0x0043D2E0 File Offset: 0x0043B4E0
		// (set) Token: 0x0600F8AD RID: 63661 RVA: 0x0043D2E8 File Offset: 0x0043B4E8
		public int petType { get; set; }

		// Token: 0x1700191C RID: 6428
		// (get) Token: 0x0600F8AE RID: 63662 RVA: 0x0043D2F1 File Offset: 0x0043B4F1
		// (set) Token: 0x0600F8AF RID: 63663 RVA: 0x0043D2F9 File Offset: 0x0043B4F9
		public int value { get; set; }

		// Token: 0x0600F8B0 RID: 63664 RVA: 0x0043D304 File Offset: 0x0043B504
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.axis = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.conditionDesc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.effectType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.extraParam = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.levelid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.petName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.petType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.petid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
