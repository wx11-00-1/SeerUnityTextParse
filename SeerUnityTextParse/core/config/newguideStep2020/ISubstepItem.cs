using System;

namespace core.config.newguideStep2020
{
	// Token: 0x0200252F RID: 9519
	public class ISubstepItem
	{
		// Token: 0x170024B9 RID: 9401
		// (get) Token: 0x06012728 RID: 75560 RVA: 0x004B9538 File Offset: 0x004B7738
		// (set) Token: 0x06012729 RID: 75561 RVA: 0x004B9540 File Offset: 0x004B7740
		public string cltMonitoringDatac { get; set; }

		// Token: 0x170024BA RID: 9402
		// (get) Token: 0x0601272A RID: 75562 RVA: 0x004B9549 File Offset: 0x004B7749
		// (set) Token: 0x0601272B RID: 75563 RVA: 0x004B9551 File Offset: 0x004B7751
		public string parm { get; set; }

		// Token: 0x170024BB RID: 9403
		// (get) Token: 0x0601272C RID: 75564 RVA: 0x004B955A File Offset: 0x004B775A
		// (set) Token: 0x0601272D RID: 75565 RVA: 0x004B9562 File Offset: 0x004B7762
		public string pid { get; set; }

		// Token: 0x170024BC RID: 9404
		// (get) Token: 0x0601272E RID: 75566 RVA: 0x004B956B File Offset: 0x004B776B
		// (set) Token: 0x0601272F RID: 75567 RVA: 0x004B9573 File Offset: 0x004B7773
		public string playEff { get; set; }

		// Token: 0x170024BD RID: 9405
		// (get) Token: 0x06012730 RID: 75568 RVA: 0x004B957C File Offset: 0x004B777C
		// (set) Token: 0x06012731 RID: 75569 RVA: 0x004B9584 File Offset: 0x004B7784
		public string waitPanel { get; set; }

		// Token: 0x170024BE RID: 9406
		// (get) Token: 0x06012732 RID: 75570 RVA: 0x004B958D File Offset: 0x004B778D
		// (set) Token: 0x06012733 RID: 75571 RVA: 0x004B9595 File Offset: 0x004B7795
		public int auto { get; set; }

		// Token: 0x170024BF RID: 9407
		// (get) Token: 0x06012734 RID: 75572 RVA: 0x004B959E File Offset: 0x004B779E
		// (set) Token: 0x06012735 RID: 75573 RVA: 0x004B95A6 File Offset: 0x004B77A6
		public int side { get; set; }

		// Token: 0x170024C0 RID: 9408
		// (get) Token: 0x06012736 RID: 75574 RVA: 0x004B95AF File Offset: 0x004B77AF
		// (set) Token: 0x06012737 RID: 75575 RVA: 0x004B95B7 File Offset: 0x004B77B7
		public int skillId { get; set; }

		// Token: 0x170024C1 RID: 9409
		// (get) Token: 0x06012738 RID: 75576 RVA: 0x004B95C0 File Offset: 0x004B77C0
		// (set) Token: 0x06012739 RID: 75577 RVA: 0x004B95C8 File Offset: 0x004B77C8
		public int skip { get; set; }

		// Token: 0x170024C2 RID: 9410
		// (get) Token: 0x0601273A RID: 75578 RVA: 0x004B95D1 File Offset: 0x004B77D1
		// (set) Token: 0x0601273B RID: 75579 RVA: 0x004B95D9 File Offset: 0x004B77D9
		public int teach { get; set; }

		// Token: 0x170024C3 RID: 9411
		// (get) Token: 0x0601273C RID: 75580 RVA: 0x004B95E2 File Offset: 0x004B77E2
		// (set) Token: 0x0601273D RID: 75581 RVA: 0x004B95EA File Offset: 0x004B77EA
		public int type { get; set; }

		// Token: 0x0601273E RID: 75582 RVA: 0x004B95F4 File Offset: 0x004B77F4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.auto = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.cltMonitoringDatac = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.parm = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.pid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.playEff = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.side = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.skillId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.skip = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.teach = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.waitPanel = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
