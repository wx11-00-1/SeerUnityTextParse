using System;

namespace core.config
{
	// Token: 0x02001E22 RID: 7714
	public class ISixteenyearsactconfigInfo : IConfigItem
	{
		// Token: 0x17001896 RID: 6294
		// (get) Token: 0x0600E44C RID: 58444 RVA: 0x003DE398 File Offset: 0x003DC598
		// (set) Token: 0x0600E44D RID: 58445 RVA: 0x003DE3A0 File Offset: 0x003DC5A0
		public string activitiesshow { get; set; }

		// Token: 0x17001897 RID: 6295
		// (get) Token: 0x0600E44E RID: 58446 RVA: 0x003DE3A9 File Offset: 0x003DC5A9
		// (set) Token: 0x0600E44F RID: 58447 RVA: 0x003DE3B1 File Offset: 0x003DC5B1
		public string name { get; set; }

		// Token: 0x17001898 RID: 6296
		// (get) Token: 0x0600E450 RID: 58448 RVA: 0x003DE3BA File Offset: 0x003DC5BA
		// (set) Token: 0x0600E451 RID: 58449 RVA: 0x003DE3C2 File Offset: 0x003DC5C2
		public string showtime { get; set; }

		// Token: 0x17001899 RID: 6297
		// (get) Token: 0x0600E452 RID: 58450 RVA: 0x003DE3CB File Offset: 0x003DC5CB
		// (set) Token: 0x0600E453 RID: 58451 RVA: 0x003DE3D3 File Offset: 0x003DC5D3
		public string title { get; set; }

		// Token: 0x1700189A RID: 6298
		// (get) Token: 0x0600E454 RID: 58452 RVA: 0x003DE3DC File Offset: 0x003DC5DC
		// (set) Token: 0x0600E455 RID: 58453 RVA: 0x003DE3E4 File Offset: 0x003DC5E4
		public int begintime { get; set; }

		// Token: 0x1700189B RID: 6299
		// (get) Token: 0x0600E456 RID: 58454 RVA: 0x003DE3ED File Offset: 0x003DC5ED
		// (set) Token: 0x0600E457 RID: 58455 RVA: 0x003DE3F5 File Offset: 0x003DC5F5
		public int endtime { get; set; }

		// Token: 0x1700189C RID: 6300
		// (get) Token: 0x0600E458 RID: 58456 RVA: 0x003DE3FE File Offset: 0x003DC5FE
		// (set) Token: 0x0600E459 RID: 58457 RVA: 0x003DE406 File Offset: 0x003DC606
		public int gift { get; set; }

		// Token: 0x1700189D RID: 6301
		// (get) Token: 0x0600E45A RID: 58458 RVA: 0x003DE40F File Offset: 0x003DC60F
		// (set) Token: 0x0600E45B RID: 58459 RVA: 0x003DE417 File Offset: 0x003DC617
		public int id { get; set; }

		// Token: 0x1700189E RID: 6302
		// (get) Token: 0x0600E45C RID: 58460 RVA: 0x003DE420 File Offset: 0x003DC620
		// (set) Token: 0x0600E45D RID: 58461 RVA: 0x003DE428 File Offset: 0x003DC628
		public int target { get; set; }

		// Token: 0x1700189F RID: 6303
		// (get) Token: 0x0600E45E RID: 58462 RVA: 0x003DE431 File Offset: 0x003DC631
		// (set) Token: 0x0600E45F RID: 58463 RVA: 0x003DE439 File Offset: 0x003DC639
		public int type { get; set; }

		// Token: 0x0600E460 RID: 58464 RVA: 0x003DE444 File Offset: 0x003DC644
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.activitiesshow = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.begintime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.endtime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.gift = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.showtime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.target = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
