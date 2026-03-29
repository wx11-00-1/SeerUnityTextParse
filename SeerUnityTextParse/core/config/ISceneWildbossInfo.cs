using System;

namespace core.config
{
	// Token: 0x0200234D RID: 9037
	public class ISceneWildbossInfo : IConfigItem
	{
		// Token: 0x17001E66 RID: 7782
		// (get) Token: 0x060113E6 RID: 70630 RVA: 0x004995E4 File Offset: 0x004977E4
		// (set) Token: 0x060113E7 RID: 70631 RVA: 0x004995EC File Offset: 0x004977EC
		public string BonusID { get; set; }

		// Token: 0x17001E67 RID: 7783
		// (get) Token: 0x060113E8 RID: 70632 RVA: 0x004995F5 File Offset: 0x004977F5
		// (set) Token: 0x060113E9 RID: 70633 RVA: 0x004995FD File Offset: 0x004977FD
		public string BonusNum { get; set; }

		// Token: 0x17001E68 RID: 7784
		// (get) Token: 0x060113EA RID: 70634 RVA: 0x00499606 File Offset: 0x00497806
		// (set) Token: 0x060113EB RID: 70635 RVA: 0x0049960E File Offset: 0x0049780E
		public string BonusProb { get; set; }

		// Token: 0x17001E69 RID: 7785
		// (get) Token: 0x060113EC RID: 70636 RVA: 0x00499617 File Offset: 0x00497817
		// (set) Token: 0x060113ED RID: 70637 RVA: 0x0049961F File Offset: 0x0049781F
		public string BonusType { get; set; }

		// Token: 0x17001E6A RID: 7786
		// (get) Token: 0x060113EE RID: 70638 RVA: 0x00499628 File Offset: 0x00497828
		// (set) Token: 0x060113EF RID: 70639 RVA: 0x00499630 File Offset: 0x00497830
		public string name { get; set; }

		// Token: 0x17001E6B RID: 7787
		// (get) Token: 0x060113F0 RID: 70640 RVA: 0x00499639 File Offset: 0x00497839
		// (set) Token: 0x060113F1 RID: 70641 RVA: 0x00499641 File Offset: 0x00497841
		public string NewSeIdxs { get; set; }

		// Token: 0x17001E6C RID: 7788
		// (get) Token: 0x060113F2 RID: 70642 RVA: 0x0049964A File Offset: 0x0049784A
		// (set) Token: 0x060113F3 RID: 70643 RVA: 0x00499652 File Offset: 0x00497852
		public string pic { get; set; }

		// Token: 0x17001E6D RID: 7789
		// (get) Token: 0x060113F4 RID: 70644 RVA: 0x0049965B File Offset: 0x0049785B
		// (set) Token: 0x060113F5 RID: 70645 RVA: 0x00499663 File Offset: 0x00497863
		public int action { get; set; }

		// Token: 0x17001E6E RID: 7790
		// (get) Token: 0x060113F6 RID: 70646 RVA: 0x0049966C File Offset: 0x0049786C
		// (set) Token: 0x060113F7 RID: 70647 RVA: 0x00499674 File Offset: 0x00497874
		public int BossID { get; set; }

		// Token: 0x17001E6F RID: 7791
		// (get) Token: 0x060113F8 RID: 70648 RVA: 0x0049967D File Offset: 0x0049787D
		// (set) Token: 0x060113F9 RID: 70649 RVA: 0x00499685 File Offset: 0x00497885
		public int Catchable { get; set; }

		// Token: 0x17001E70 RID: 7792
		// (get) Token: 0x060113FA RID: 70650 RVA: 0x0049968E File Offset: 0x0049788E
		// (set) Token: 0x060113FB RID: 70651 RVA: 0x00499696 File Offset: 0x00497896
		public int FinOnce { get; set; }

		// Token: 0x17001E71 RID: 7793
		// (get) Token: 0x060113FC RID: 70652 RVA: 0x0049969F File Offset: 0x0049789F
		// (set) Token: 0x060113FD RID: 70653 RVA: 0x004996A7 File Offset: 0x004978A7
		public int FinTaskWay { get; set; }

		// Token: 0x17001E72 RID: 7794
		// (get) Token: 0x060113FE RID: 70654 RVA: 0x004996B0 File Offset: 0x004978B0
		// (set) Token: 0x060113FF RID: 70655 RVA: 0x004996B8 File Offset: 0x004978B8
		public int HP { get; set; }

		// Token: 0x17001E73 RID: 7795
		// (get) Token: 0x06011400 RID: 70656 RVA: 0x004996C1 File Offset: 0x004978C1
		// (set) Token: 0x06011401 RID: 70657 RVA: 0x004996C9 File Offset: 0x004978C9
		public int id { get; set; }

		// Token: 0x17001E74 RID: 7796
		// (get) Token: 0x06011402 RID: 70658 RVA: 0x004996D2 File Offset: 0x004978D2
		// (set) Token: 0x06011403 RID: 70659 RVA: 0x004996DA File Offset: 0x004978DA
		public int LV { get; set; }

		// Token: 0x17001E75 RID: 7797
		// (get) Token: 0x06011404 RID: 70660 RVA: 0x004996E3 File Offset: 0x004978E3
		// (set) Token: 0x06011405 RID: 70661 RVA: 0x004996EB File Offset: 0x004978EB
		public int MaxTimes { get; set; }

		// Token: 0x17001E76 RID: 7798
		// (get) Token: 0x06011406 RID: 70662 RVA: 0x004996F4 File Offset: 0x004978F4
		// (set) Token: 0x06011407 RID: 70663 RVA: 0x004996FC File Offset: 0x004978FC
		public int PkFlag { get; set; }

		// Token: 0x17001E77 RID: 7799
		// (get) Token: 0x06011408 RID: 70664 RVA: 0x00499705 File Offset: 0x00497905
		// (set) Token: 0x06011409 RID: 70665 RVA: 0x0049970D File Offset: 0x0049790D
		public int Speed { get; set; }

		// Token: 0x17001E78 RID: 7800
		// (get) Token: 0x0601140A RID: 70666 RVA: 0x00499716 File Offset: 0x00497916
		// (set) Token: 0x0601140B RID: 70667 RVA: 0x0049971E File Offset: 0x0049791E
		public int VipMaxTimes { get; set; }

		// Token: 0x17001E79 RID: 7801
		// (get) Token: 0x0601140C RID: 70668 RVA: 0x00499727 File Offset: 0x00497927
		// (set) Token: 0x0601140D RID: 70669 RVA: 0x0049972F File Offset: 0x0049792F
		public int VipOnly { get; set; }

		// Token: 0x17001E7A RID: 7802
		// (get) Token: 0x0601140E RID: 70670 RVA: 0x00499738 File Offset: 0x00497938
		// (set) Token: 0x0601140F RID: 70671 RVA: 0x00499740 File Offset: 0x00497940
		public int Visible { get; set; }

		// Token: 0x17001E7B RID: 7803
		// (get) Token: 0x06011410 RID: 70672 RVA: 0x00499749 File Offset: 0x00497949
		// (set) Token: 0x06011411 RID: 70673 RVA: 0x00499751 File Offset: 0x00497951
		public int WorldWildEnd { get; set; }

		// Token: 0x17001E7C RID: 7804
		// (get) Token: 0x06011412 RID: 70674 RVA: 0x0049975A File Offset: 0x0049795A
		// (set) Token: 0x06011413 RID: 70675 RVA: 0x00499762 File Offset: 0x00497962
		public int WorldWildStart { get; set; }

		// Token: 0x06011414 RID: 70676 RVA: 0x0049976C File Offset: 0x0049796C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.BonusID = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.BonusNum = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.BonusProb = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.BonusType = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.BossID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Catchable = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.FinOnce = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.FinTaskWay = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.HP = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.LV = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MaxTimes = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.NewSeIdxs = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.PkFlag = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Speed = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.VipMaxTimes = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.VipOnly = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Visible = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.WorldWildEnd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.WorldWildStart = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.action = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.pic = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
