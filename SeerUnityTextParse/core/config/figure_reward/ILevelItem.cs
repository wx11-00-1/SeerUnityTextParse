using System;

namespace core.config.figure_reward
{
	// Token: 0x02002038 RID: 8248
	public class ILevelItem
	{
		// Token: 0x1700206D RID: 8301
		// (get) Token: 0x0600FBDD RID: 64477 RVA: 0x00401364 File Offset: 0x003FF564
		// (set) Token: 0x0600FBDE RID: 64478 RVA: 0x0040136C File Offset: 0x003FF56C
		public int ExpNeed { get; set; }

		// Token: 0x1700206E RID: 8302
		// (get) Token: 0x0600FBDF RID: 64479 RVA: 0x00401375 File Offset: 0x003FF575
		// (set) Token: 0x0600FBE0 RID: 64480 RVA: 0x0040137D File Offset: 0x003FF57D
		public int ID { get; set; }

		// Token: 0x1700206F RID: 8303
		// (get) Token: 0x0600FBE1 RID: 64481 RVA: 0x00401386 File Offset: 0x003FF586
		// (set) Token: 0x0600FBE2 RID: 64482 RVA: 0x0040138E File Offset: 0x003FF58E
		public int RewardID { get; set; }

		// Token: 0x17002070 RID: 8304
		// (get) Token: 0x0600FBE3 RID: 64483 RVA: 0x00401397 File Offset: 0x003FF597
		// (set) Token: 0x0600FBE4 RID: 64484 RVA: 0x0040139F File Offset: 0x003FF59F
		public int UseBit { get; set; }

		// Token: 0x17002071 RID: 8305
		// (get) Token: 0x0600FBE5 RID: 64485 RVA: 0x004013A8 File Offset: 0x003FF5A8
		// (set) Token: 0x0600FBE6 RID: 64486 RVA: 0x004013B0 File Offset: 0x003FF5B0
		public int UseValue { get; set; }

		// Token: 0x0600FBE7 RID: 64487 RVA: 0x004013BC File Offset: 0x003FF5BC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ExpNeed = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.RewardID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.UseBit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.UseValue = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
