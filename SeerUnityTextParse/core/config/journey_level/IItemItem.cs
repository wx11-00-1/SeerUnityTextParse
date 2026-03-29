using System;

namespace core.config.journey_level
{
	// Token: 0x02002582 RID: 9602
	public class IItemItem : IConfigItem
	{
		// Token: 0x1700262F RID: 9775
		// (get) Token: 0x06012ABF RID: 76479 RVA: 0x004BE104 File Offset: 0x004BC304
		// (set) Token: 0x06012AC0 RID: 76480 RVA: 0x004BE10C File Offset: 0x004BC30C
		public string rewardcnt { get; set; }

		// Token: 0x17002630 RID: 9776
		// (get) Token: 0x06012AC1 RID: 76481 RVA: 0x004BE115 File Offset: 0x004BC315
		// (set) Token: 0x06012AC2 RID: 76482 RVA: 0x004BE11D File Offset: 0x004BC31D
		public string rewardid { get; set; }

		// Token: 0x17002631 RID: 9777
		// (get) Token: 0x06012AC3 RID: 76483 RVA: 0x004BE126 File Offset: 0x004BC326
		// (set) Token: 0x06012AC4 RID: 76484 RVA: 0x004BE12E File Offset: 0x004BC32E
		public string rewardtype { get; set; }

		// Token: 0x17002632 RID: 9778
		// (get) Token: 0x06012AC5 RID: 76485 RVA: 0x004BE137 File Offset: 0x004BC337
		// (set) Token: 0x06012AC6 RID: 76486 RVA: 0x004BE13F File Offset: 0x004BC33F
		public string taskid { get; set; }

		// Token: 0x17002633 RID: 9779
		// (get) Token: 0x06012AC7 RID: 76487 RVA: 0x004BE148 File Offset: 0x004BC348
		// (set) Token: 0x06012AC8 RID: 76488 RVA: 0x004BE150 File Offset: 0x004BC350
		public int id { get; set; }

		// Token: 0x17002634 RID: 9780
		// (get) Token: 0x06012AC9 RID: 76489 RVA: 0x004BE159 File Offset: 0x004BC359
		// (set) Token: 0x06012ACA RID: 76490 RVA: 0x004BE161 File Offset: 0x004BC361
		public int level { get; set; }

		// Token: 0x06012ACB RID: 76491 RVA: 0x004BE16C File Offset: 0x004BC36C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rewardcnt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardtype = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.taskid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
