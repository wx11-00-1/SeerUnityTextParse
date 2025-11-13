using System;

namespace core.config
{
	// Token: 0x02001D8A RID: 7562
	public class ILuckyrocketLevelInfo : IConfigItem
	{
		// Token: 0x170015ED RID: 5613
		// (get) Token: 0x0600DDCA RID: 56778 RVA: 0x003D5EC4 File Offset: 0x003D40C4
		// (set) Token: 0x0600DDCB RID: 56779 RVA: 0x003D5ECC File Offset: 0x003D40CC
		public string equip { get; set; }

		// Token: 0x170015EE RID: 5614
		// (get) Token: 0x0600DDCC RID: 56780 RVA: 0x003D5ED5 File Offset: 0x003D40D5
		// (set) Token: 0x0600DDCD RID: 56781 RVA: 0x003D5EDD File Offset: 0x003D40DD
		public int close { get; set; }

		// Token: 0x170015EF RID: 5615
		// (get) Token: 0x0600DDCE RID: 56782 RVA: 0x003D5EE6 File Offset: 0x003D40E6
		// (set) Token: 0x0600DDCF RID: 56783 RVA: 0x003D5EEE File Offset: 0x003D40EE
		public int id { get; set; }

		// Token: 0x170015F0 RID: 5616
		// (get) Token: 0x0600DDD0 RID: 56784 RVA: 0x003D5EF7 File Offset: 0x003D40F7
		// (set) Token: 0x0600DDD1 RID: 56785 RVA: 0x003D5EFF File Offset: 0x003D40FF
		public int level { get; set; }

		// Token: 0x170015F1 RID: 5617
		// (get) Token: 0x0600DDD2 RID: 56786 RVA: 0x003D5F08 File Offset: 0x003D4108
		// (set) Token: 0x0600DDD3 RID: 56787 RVA: 0x003D5F10 File Offset: 0x003D4110
		public int phase { get; set; }

		// Token: 0x170015F2 RID: 5618
		// (get) Token: 0x0600DDD4 RID: 56788 RVA: 0x003D5F19 File Offset: 0x003D4119
		// (set) Token: 0x0600DDD5 RID: 56789 RVA: 0x003D5F21 File Offset: 0x003D4121
		public float ratio { get; set; }

		// Token: 0x170015F3 RID: 5619
		// (get) Token: 0x0600DDD6 RID: 56790 RVA: 0x003D5F2A File Offset: 0x003D412A
		// (set) Token: 0x0600DDD7 RID: 56791 RVA: 0x003D5F32 File Offset: 0x003D4132
		public int requirement { get; set; }

		// Token: 0x170015F4 RID: 5620
		// (get) Token: 0x0600DDD8 RID: 56792 RVA: 0x003D5F3B File Offset: 0x003D413B
		// (set) Token: 0x0600DDD9 RID: 56793 RVA: 0x003D5F43 File Offset: 0x003D4143
		public int reward { get; set; }

		// Token: 0x170015F5 RID: 5621
		// (get) Token: 0x0600DDDA RID: 56794 RVA: 0x003D5F4C File Offset: 0x003D414C
		// (set) Token: 0x0600DDDB RID: 56795 RVA: 0x003D5F54 File Offset: 0x003D4154
		public int round { get; set; }

		// Token: 0x0600DDDC RID: 56796 RVA: 0x003D5F60 File Offset: 0x003D4160
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.close = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.equip = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.phase = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ratio = ByteUtil.ReadFloat(bytes, ref byteIndex);
			this.requirement = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.reward = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.round = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
