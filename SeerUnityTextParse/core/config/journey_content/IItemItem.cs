using System;

namespace core.config.journey_content
{
	// Token: 0x02002585 RID: 9605
	public class IItemItem : IConfigItem
	{
		// Token: 0x17002638 RID: 9784
		// (get) Token: 0x06012AD7 RID: 76503 RVA: 0x004BE2B4 File Offset: 0x004BC4B4
		// (set) Token: 0x06012AD8 RID: 76504 RVA: 0x004BE2BC File Offset: 0x004BC4BC
		public string content { get; set; }

		// Token: 0x17002639 RID: 9785
		// (get) Token: 0x06012AD9 RID: 76505 RVA: 0x004BE2C5 File Offset: 0x004BC4C5
		// (set) Token: 0x06012ADA RID: 76506 RVA: 0x004BE2CD File Offset: 0x004BC4CD
		public string gopanel { get; set; }

		// Token: 0x1700263A RID: 9786
		// (get) Token: 0x06012ADB RID: 76507 RVA: 0x004BE2D6 File Offset: 0x004BC4D6
		// (set) Token: 0x06012ADC RID: 76508 RVA: 0x004BE2DE File Offset: 0x004BC4DE
		public string helptips { get; set; }

		// Token: 0x1700263B RID: 9787
		// (get) Token: 0x06012ADD RID: 76509 RVA: 0x004BE2E7 File Offset: 0x004BC4E7
		// (set) Token: 0x06012ADE RID: 76510 RVA: 0x004BE2EF File Offset: 0x004BC4EF
		public string icon { get; set; }

		// Token: 0x1700263C RID: 9788
		// (get) Token: 0x06012ADF RID: 76511 RVA: 0x004BE2F8 File Offset: 0x004BC4F8
		// (set) Token: 0x06012AE0 RID: 76512 RVA: 0x004BE300 File Offset: 0x004BC500
		public string rewardcnt { get; set; }

		// Token: 0x1700263D RID: 9789
		// (get) Token: 0x06012AE1 RID: 76513 RVA: 0x004BE309 File Offset: 0x004BC509
		// (set) Token: 0x06012AE2 RID: 76514 RVA: 0x004BE311 File Offset: 0x004BC511
		public string rewardid { get; set; }

		// Token: 0x1700263E RID: 9790
		// (get) Token: 0x06012AE3 RID: 76515 RVA: 0x004BE31A File Offset: 0x004BC51A
		// (set) Token: 0x06012AE4 RID: 76516 RVA: 0x004BE322 File Offset: 0x004BC522
		public string rewardtype { get; set; }

		// Token: 0x1700263F RID: 9791
		// (get) Token: 0x06012AE5 RID: 76517 RVA: 0x004BE32B File Offset: 0x004BC52B
		// (set) Token: 0x06012AE6 RID: 76518 RVA: 0x004BE333 File Offset: 0x004BC533
		public string timelimited { get; set; }

		// Token: 0x17002640 RID: 9792
		// (get) Token: 0x06012AE7 RID: 76519 RVA: 0x004BE33C File Offset: 0x004BC53C
		// (set) Token: 0x06012AE8 RID: 76520 RVA: 0x004BE344 File Offset: 0x004BC544
		public int Dbquery { get; set; }

		// Token: 0x17002641 RID: 9793
		// (get) Token: 0x06012AE9 RID: 76521 RVA: 0x004BE34D File Offset: 0x004BC54D
		// (set) Token: 0x06012AEA RID: 76522 RVA: 0x004BE355 File Offset: 0x004BC555
		public int id { get; set; }

		// Token: 0x17002642 RID: 9794
		// (get) Token: 0x06012AEB RID: 76523 RVA: 0x004BE35E File Offset: 0x004BC55E
		// (set) Token: 0x06012AEC RID: 76524 RVA: 0x004BE366 File Offset: 0x004BC566
		public int Taskparam1 { get; set; }

		// Token: 0x17002643 RID: 9795
		// (get) Token: 0x06012AED RID: 76525 RVA: 0x004BE36F File Offset: 0x004BC56F
		// (set) Token: 0x06012AEE RID: 76526 RVA: 0x004BE377 File Offset: 0x004BC577
		public int Taskparam2 { get; set; }

		// Token: 0x17002644 RID: 9796
		// (get) Token: 0x06012AEF RID: 76527 RVA: 0x004BE380 File Offset: 0x004BC580
		// (set) Token: 0x06012AF0 RID: 76528 RVA: 0x004BE388 File Offset: 0x004BC588
		public int taskschedule { get; set; }

		// Token: 0x17002645 RID: 9797
		// (get) Token: 0x06012AF1 RID: 76529 RVA: 0x004BE391 File Offset: 0x004BC591
		// (set) Token: 0x06012AF2 RID: 76530 RVA: 0x004BE399 File Offset: 0x004BC599
		public int Tasktype { get; set; }

		// Token: 0x17002646 RID: 9798
		// (get) Token: 0x06012AF3 RID: 76531 RVA: 0x004BE3A2 File Offset: 0x004BC5A2
		// (set) Token: 0x06012AF4 RID: 76532 RVA: 0x004BE3AA File Offset: 0x004BC5AA
		public int tipstime { get; set; }

		// Token: 0x06012AF5 RID: 76533 RVA: 0x004BE3B4 File Offset: 0x004BC5B4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Dbquery = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Taskparam1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Taskparam2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Tasktype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.content = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.gopanel = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.helptips = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.icon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rewardcnt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardtype = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.taskschedule = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.timelimited = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.tipstime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
