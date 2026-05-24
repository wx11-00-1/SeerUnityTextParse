using System;

namespace core.config
{
	// Token: 0x02002427 RID: 9255
	public class IAurumEndgameEnemyConfigInfo : IConfigItem
	{
		// Token: 0x1700162D RID: 5677
		// (get) Token: 0x06011800 RID: 71680 RVA: 0x00500310 File Offset: 0x004FE510
		// (set) Token: 0x06011801 RID: 71681 RVA: 0x00500318 File Offset: 0x004FE518
		public string desc { get; set; }

		// Token: 0x1700162E RID: 5678
		// (get) Token: 0x06011802 RID: 71682 RVA: 0x00500321 File Offset: 0x004FE521
		// (set) Token: 0x06011803 RID: 71683 RVA: 0x00500329 File Offset: 0x004FE529
		public string name { get; set; }

		// Token: 0x1700162F RID: 5679
		// (get) Token: 0x06011804 RID: 71684 RVA: 0x00500332 File Offset: 0x004FE532
		// (set) Token: 0x06011805 RID: 71685 RVA: 0x0050033A File Offset: 0x004FE53A
		public int atkBc { get; set; }

		// Token: 0x17001630 RID: 5680
		// (get) Token: 0x06011806 RID: 71686 RVA: 0x00500343 File Offset: 0x004FE543
		// (set) Token: 0x06011807 RID: 71687 RVA: 0x0050034B File Offset: 0x004FE54B
		public int atkRate { get; set; }

		// Token: 0x17001631 RID: 5681
		// (get) Token: 0x06011808 RID: 71688 RVA: 0x00500354 File Offset: 0x004FE554
		// (set) Token: 0x06011809 RID: 71689 RVA: 0x0050035C File Offset: 0x004FE55C
		public int hpBc { get; set; }

		// Token: 0x17001632 RID: 5682
		// (get) Token: 0x0601180A RID: 71690 RVA: 0x00500365 File Offset: 0x004FE565
		// (set) Token: 0x0601180B RID: 71691 RVA: 0x0050036D File Offset: 0x004FE56D
		public int id { get; set; }

		// Token: 0x17001633 RID: 5683
		// (get) Token: 0x0601180C RID: 71692 RVA: 0x00500376 File Offset: 0x004FE576
		// (set) Token: 0x0601180D RID: 71693 RVA: 0x0050037E File Offset: 0x004FE57E
		public int model { get; set; }

		// Token: 0x17001634 RID: 5684
		// (get) Token: 0x0601180E RID: 71694 RVA: 0x00500387 File Offset: 0x004FE587
		// (set) Token: 0x0601180F RID: 71695 RVA: 0x0050038F File Offset: 0x004FE58F
		public int scale { get; set; }

		// Token: 0x17001635 RID: 5685
		// (get) Token: 0x06011810 RID: 71696 RVA: 0x00500398 File Offset: 0x004FE598
		// (set) Token: 0x06011811 RID: 71697 RVA: 0x005003A0 File Offset: 0x004FE5A0
		public int speed { get; set; }

		// Token: 0x17001636 RID: 5686
		// (get) Token: 0x06011812 RID: 71698 RVA: 0x005003A9 File Offset: 0x004FE5A9
		// (set) Token: 0x06011813 RID: 71699 RVA: 0x005003B1 File Offset: 0x004FE5B1
		public int speedVar { get; set; }

		// Token: 0x17001637 RID: 5687
		// (get) Token: 0x06011814 RID: 71700 RVA: 0x005003BA File Offset: 0x004FE5BA
		// (set) Token: 0x06011815 RID: 71701 RVA: 0x005003C2 File Offset: 0x004FE5C2
		public int type { get; set; }

		// Token: 0x06011816 RID: 71702 RVA: 0x005003CC File Offset: 0x004FE5CC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.atkBc = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.atkRate = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.hpBc = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.model = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.scale = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.speed = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.speedVar = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
