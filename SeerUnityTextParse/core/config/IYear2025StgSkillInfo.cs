using System;

namespace core.config
{
	// Token: 0x02001E96 RID: 7830
	public class IYear2025StgSkillInfo : IConfigItem
	{
		// Token: 0x17001A97 RID: 6807
		// (get) Token: 0x0600E936 RID: 59702 RVA: 0x003E456C File Offset: 0x003E276C
		// (set) Token: 0x0600E937 RID: 59703 RVA: 0x003E4574 File Offset: 0x003E2774
		public int[] args { get; set; }

		// Token: 0x17001A98 RID: 6808
		// (get) Token: 0x0600E938 RID: 59704 RVA: 0x003E457D File Offset: 0x003E277D
		// (set) Token: 0x0600E939 RID: 59705 RVA: 0x003E4585 File Offset: 0x003E2785
		public int accumulate { get; set; }

		// Token: 0x17001A99 RID: 6809
		// (get) Token: 0x0600E93A RID: 59706 RVA: 0x003E458E File Offset: 0x003E278E
		// (set) Token: 0x0600E93B RID: 59707 RVA: 0x003E4596 File Offset: 0x003E2796
		public int cd { get; set; }

		// Token: 0x17001A9A RID: 6810
		// (get) Token: 0x0600E93C RID: 59708 RVA: 0x003E459F File Offset: 0x003E279F
		// (set) Token: 0x0600E93D RID: 59709 RVA: 0x003E45A7 File Offset: 0x003E27A7
		public int id { get; set; }

		// Token: 0x17001A9B RID: 6811
		// (get) Token: 0x0600E93E RID: 59710 RVA: 0x003E45B0 File Offset: 0x003E27B0
		// (set) Token: 0x0600E93F RID: 59711 RVA: 0x003E45B8 File Offset: 0x003E27B8
		public int type { get; set; }

		// Token: 0x0600E940 RID: 59712 RVA: 0x003E45C4 File Offset: 0x003E27C4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.accumulate = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.args = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.args[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.cd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
