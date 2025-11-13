using System;

namespace core.config
{
	// Token: 0x02001E24 RID: 7716
	public class ISixteenyearsactpanelInfo : IConfigItem
	{
		// Token: 0x170018A1 RID: 6305
		// (get) Token: 0x0600E466 RID: 58470 RVA: 0x003DE574 File Offset: 0x003DC774
		// (set) Token: 0x0600E467 RID: 58471 RVA: 0x003DE57C File Offset: 0x003DC77C
		public string activitiesshow { get; set; }

		// Token: 0x170018A2 RID: 6306
		// (get) Token: 0x0600E468 RID: 58472 RVA: 0x003DE585 File Offset: 0x003DC785
		// (set) Token: 0x0600E469 RID: 58473 RVA: 0x003DE58D File Offset: 0x003DC78D
		public string notes { get; set; }

		// Token: 0x170018A3 RID: 6307
		// (get) Token: 0x0600E46A RID: 58474 RVA: 0x003DE596 File Offset: 0x003DC796
		// (set) Token: 0x0600E46B RID: 58475 RVA: 0x003DE59E File Offset: 0x003DC79E
		public string showtime { get; set; }

		// Token: 0x170018A4 RID: 6308
		// (get) Token: 0x0600E46C RID: 58476 RVA: 0x003DE5A7 File Offset: 0x003DC7A7
		// (set) Token: 0x0600E46D RID: 58477 RVA: 0x003DE5AF File Offset: 0x003DC7AF
		public string title { get; set; }

		// Token: 0x170018A5 RID: 6309
		// (get) Token: 0x0600E46E RID: 58478 RVA: 0x003DE5B8 File Offset: 0x003DC7B8
		// (set) Token: 0x0600E46F RID: 58479 RVA: 0x003DE5C0 File Offset: 0x003DC7C0
		public int begintime { get; set; }

		// Token: 0x170018A6 RID: 6310
		// (get) Token: 0x0600E470 RID: 58480 RVA: 0x003DE5C9 File Offset: 0x003DC7C9
		// (set) Token: 0x0600E471 RID: 58481 RVA: 0x003DE5D1 File Offset: 0x003DC7D1
		public int endtime { get; set; }

		// Token: 0x170018A7 RID: 6311
		// (get) Token: 0x0600E472 RID: 58482 RVA: 0x003DE5DA File Offset: 0x003DC7DA
		// (set) Token: 0x0600E473 RID: 58483 RVA: 0x003DE5E2 File Offset: 0x003DC7E2
		public int id { get; set; }

		// Token: 0x170018A8 RID: 6312
		// (get) Token: 0x0600E474 RID: 58484 RVA: 0x003DE5EB File Offset: 0x003DC7EB
		// (set) Token: 0x0600E475 RID: 58485 RVA: 0x003DE5F3 File Offset: 0x003DC7F3
		public int module { get; set; }

		// Token: 0x0600E476 RID: 58486 RVA: 0x003DE5FC File Offset: 0x003DC7FC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.activitiesshow = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.begintime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.endtime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.module = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.notes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.showtime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
