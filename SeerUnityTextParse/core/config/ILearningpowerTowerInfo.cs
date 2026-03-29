using System;

namespace core.config
{
	// Token: 0x02002287 RID: 8839
	public class ILearningpowerTowerInfo : IConfigItem
	{
		// Token: 0x17001AE6 RID: 6886
		// (get) Token: 0x06010B5A RID: 68442 RVA: 0x0048EB8C File Offset: 0x0048CD8C
		// (set) Token: 0x06010B5B RID: 68443 RVA: 0x0048EB94 File Offset: 0x0048CD94
		public string bosslist { get; set; }

		// Token: 0x17001AE7 RID: 6887
		// (get) Token: 0x06010B5C RID: 68444 RVA: 0x0048EB9D File Offset: 0x0048CD9D
		// (set) Token: 0x06010B5D RID: 68445 RVA: 0x0048EBA5 File Offset: 0x0048CDA5
		public string raidunlocktext { get; set; }

		// Token: 0x17001AE8 RID: 6888
		// (get) Token: 0x06010B5E RID: 68446 RVA: 0x0048EBAE File Offset: 0x0048CDAE
		// (set) Token: 0x06010B5F RID: 68447 RVA: 0x0048EBB6 File Offset: 0x0048CDB6
		public string rewardid { get; set; }

		// Token: 0x17001AE9 RID: 6889
		// (get) Token: 0x06010B60 RID: 68448 RVA: 0x0048EBBF File Offset: 0x0048CDBF
		// (set) Token: 0x06010B61 RID: 68449 RVA: 0x0048EBC7 File Offset: 0x0048CDC7
		public string rewardnum { get; set; }

		// Token: 0x17001AEA RID: 6890
		// (get) Token: 0x06010B62 RID: 68450 RVA: 0x0048EBD0 File Offset: 0x0048CDD0
		// (set) Token: 0x06010B63 RID: 68451 RVA: 0x0048EBD8 File Offset: 0x0048CDD8
		public string rewardtype { get; set; }

		// Token: 0x17001AEB RID: 6891
		// (get) Token: 0x06010B64 RID: 68452 RVA: 0x0048EBE1 File Offset: 0x0048CDE1
		// (set) Token: 0x06010B65 RID: 68453 RVA: 0x0048EBE9 File Offset: 0x0048CDE9
		public string sebossid { get; set; }

		// Token: 0x17001AEC RID: 6892
		// (get) Token: 0x06010B66 RID: 68454 RVA: 0x0048EBF2 File Offset: 0x0048CDF2
		// (set) Token: 0x06010B67 RID: 68455 RVA: 0x0048EBFA File Offset: 0x0048CDFA
		public int id { get; set; }

		// Token: 0x17001AED RID: 6893
		// (get) Token: 0x06010B68 RID: 68456 RVA: 0x0048EC03 File Offset: 0x0048CE03
		// (set) Token: 0x06010B69 RID: 68457 RVA: 0x0048EC0B File Offset: 0x0048CE0B
		public int raidunlockarg { get; set; }

		// Token: 0x06010B6A RID: 68458 RVA: 0x0048EC14 File Offset: 0x0048CE14
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.bosslist = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.raidunlockarg = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.raidunlocktext = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardnum = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardtype = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.sebossid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
