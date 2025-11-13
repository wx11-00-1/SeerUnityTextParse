using System;

namespace core.config.map_config
{
	// Token: 0x02001FD1 RID: 8145
	public class IComponentItem
	{
		// Token: 0x17001E1D RID: 7709
		// (get) Token: 0x0600F583 RID: 62851 RVA: 0x003FAF92 File Offset: 0x003F9192
		// (set) Token: 0x0600F584 RID: 62852 RVA: 0x003FAF9A File Offset: 0x003F919A
		public int targetID { get; set; }

		// Token: 0x17001E1E RID: 7710
		// (get) Token: 0x0600F585 RID: 62853 RVA: 0x003FAFA3 File Offset: 0x003F91A3
		// (set) Token: 0x0600F586 RID: 62854 RVA: 0x003FAFAB File Offset: 0x003F91AB
		public float x { get; set; }

		// Token: 0x17001E1F RID: 7711
		// (get) Token: 0x0600F587 RID: 62855 RVA: 0x003FAFB4 File Offset: 0x003F91B4
		// (set) Token: 0x0600F588 RID: 62856 RVA: 0x003FAFBC File Offset: 0x003F91BC
		public float y { get; set; }

		// Token: 0x0600F589 RID: 62857 RVA: 0x003FAFC5 File Offset: 0x003F91C5
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.targetID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.x = ByteUtil.ReadFloat(bytes, ref byteIndex);
			this.y = ByteUtil.ReadFloat(bytes, ref byteIndex);
		}
	}
}
