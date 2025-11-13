using System;

namespace core.config.pet_advance
{
	// Token: 0x02001F43 RID: 8003
	public class IBackItem
	{
		// Token: 0x17001BF4 RID: 7156
		// (get) Token: 0x0600F010 RID: 61456 RVA: 0x003F45A3 File Offset: 0x003F27A3
		// (set) Token: 0x0600F011 RID: 61457 RVA: 0x003F45AB File Offset: 0x003F27AB
		public string desc { get; set; }

		// Token: 0x17001BF5 RID: 7157
		// (get) Token: 0x0600F012 RID: 61458 RVA: 0x003F45B4 File Offset: 0x003F27B4
		// (set) Token: 0x0600F013 RID: 61459 RVA: 0x003F45BC File Offset: 0x003F27BC
		public int ID { get; set; }

		// Token: 0x17001BF6 RID: 7158
		// (get) Token: 0x0600F014 RID: 61460 RVA: 0x003F45C5 File Offset: 0x003F27C5
		// (set) Token: 0x0600F015 RID: 61461 RVA: 0x003F45CD File Offset: 0x003F27CD
		public int IsBack { get; set; }

		// Token: 0x17001BF7 RID: 7159
		// (get) Token: 0x0600F016 RID: 61462 RVA: 0x003F45D6 File Offset: 0x003F27D6
		// (set) Token: 0x0600F017 RID: 61463 RVA: 0x003F45DE File Offset: 0x003F27DE
		public int MonsterId { get; set; }

		// Token: 0x17001BF8 RID: 7160
		// (get) Token: 0x0600F018 RID: 61464 RVA: 0x003F45E7 File Offset: 0x003F27E7
		// (set) Token: 0x0600F019 RID: 61465 RVA: 0x003F45EF File Offset: 0x003F27EF
		public int PerNeedCoinB { get; set; }

		// Token: 0x17001BF9 RID: 7161
		// (get) Token: 0x0600F01A RID: 61466 RVA: 0x003F45F8 File Offset: 0x003F27F8
		// (set) Token: 0x0600F01B RID: 61467 RVA: 0x003F4600 File Offset: 0x003F2800
		public int TaskId { get; set; }

		// Token: 0x0600F01C RID: 61468 RVA: 0x003F460C File Offset: 0x003F280C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.IsBack = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MonsterId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.PerNeedCoinB = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.TaskId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
