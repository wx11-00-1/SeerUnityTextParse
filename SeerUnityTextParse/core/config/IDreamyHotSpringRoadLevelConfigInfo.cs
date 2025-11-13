using System;

namespace core.config
{
	// Token: 0x02001D34 RID: 7476
	public class IDreamyHotSpringRoadLevelConfigInfo : IConfigItem
	{
		// Token: 0x17001492 RID: 5266
		// (get) Token: 0x0600DA68 RID: 55912 RVA: 0x003D1B2C File Offset: 0x003CFD2C
		// (set) Token: 0x0600DA69 RID: 55913 RVA: 0x003D1B34 File Offset: 0x003CFD34
		public int id { get; set; }

		// Token: 0x17001493 RID: 5267
		// (get) Token: 0x0600DA6A RID: 55914 RVA: 0x003D1B3D File Offset: 0x003CFD3D
		// (set) Token: 0x0600DA6B RID: 55915 RVA: 0x003D1B45 File Offset: 0x003CFD45
		public int rewardNum { get; set; }

		// Token: 0x17001494 RID: 5268
		// (get) Token: 0x0600DA6C RID: 55916 RVA: 0x003D1B4E File Offset: 0x003CFD4E
		// (set) Token: 0x0600DA6D RID: 55917 RVA: 0x003D1B56 File Offset: 0x003CFD56
		public int type { get; set; }

		// Token: 0x0600DA6E RID: 55918 RVA: 0x003D1B5F File Offset: 0x003CFD5F
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rewardNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
