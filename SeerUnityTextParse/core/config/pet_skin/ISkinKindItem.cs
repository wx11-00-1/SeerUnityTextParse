using System;

namespace core.config.pet_skin
{
	// Token: 0x02001F3D RID: 7997
	public class ISkinKindItem
	{
		// Token: 0x17001BE0 RID: 7136
		// (get) Token: 0x0600EFDC RID: 61404 RVA: 0x003F41E1 File Offset: 0x003F23E1
		// (set) Token: 0x0600EFDD RID: 61405 RVA: 0x003F41E9 File Offset: 0x003F23E9
		public int ID { get; set; }

		// Token: 0x17001BE1 RID: 7137
		// (get) Token: 0x0600EFDE RID: 61406 RVA: 0x003F41F2 File Offset: 0x003F23F2
		// (set) Token: 0x0600EFDF RID: 61407 RVA: 0x003F41FA File Offset: 0x003F23FA
		public int LifeTime { get; set; }

		// Token: 0x17001BE2 RID: 7138
		// (get) Token: 0x0600EFE0 RID: 61408 RVA: 0x003F4203 File Offset: 0x003F2403
		// (set) Token: 0x0600EFE1 RID: 61409 RVA: 0x003F420B File Offset: 0x003F240B
		public int SkinType { get; set; }

		// Token: 0x17001BE3 RID: 7139
		// (get) Token: 0x0600EFE2 RID: 61410 RVA: 0x003F4214 File Offset: 0x003F2414
		// (set) Token: 0x0600EFE3 RID: 61411 RVA: 0x003F421C File Offset: 0x003F241C
		public int Type { get; set; }

		// Token: 0x17001BE4 RID: 7140
		// (get) Token: 0x0600EFE4 RID: 61412 RVA: 0x003F4225 File Offset: 0x003F2425
		// (set) Token: 0x0600EFE5 RID: 61413 RVA: 0x003F422D File Offset: 0x003F242D
		public int Year { get; set; }

		// Token: 0x0600EFE6 RID: 61414 RVA: 0x003F4238 File Offset: 0x003F2438
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.LifeTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.SkinType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Year = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
