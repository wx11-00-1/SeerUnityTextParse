using System;

namespace core.config
{
	// Token: 0x02001CE4 RID: 7396
	public class IBuildingWarBuildingInfo : IConfigItem
	{
		// Token: 0x1700130B RID: 4875
		// (get) Token: 0x0600D6BA RID: 54970 RVA: 0x003CD4FC File Offset: 0x003CB6FC
		// (set) Token: 0x0600D6BB RID: 54971 RVA: 0x003CD504 File Offset: 0x003CB704
		public int[] bornpoint { get; set; }

		// Token: 0x1700130C RID: 4876
		// (get) Token: 0x0600D6BC RID: 54972 RVA: 0x003CD50D File Offset: 0x003CB70D
		// (set) Token: 0x0600D6BD RID: 54973 RVA: 0x003CD515 File Offset: 0x003CB715
		public int[] linkbuilding { get; set; }

		// Token: 0x1700130D RID: 4877
		// (get) Token: 0x0600D6BE RID: 54974 RVA: 0x003CD51E File Offset: 0x003CB71E
		// (set) Token: 0x0600D6BF RID: 54975 RVA: 0x003CD526 File Offset: 0x003CB726
		public int[] startaction { get; set; }

		// Token: 0x1700130E RID: 4878
		// (get) Token: 0x0600D6C0 RID: 54976 RVA: 0x003CD52F File Offset: 0x003CB72F
		// (set) Token: 0x0600D6C1 RID: 54977 RVA: 0x003CD537 File Offset: 0x003CB737
		public int buildingid { get; set; }

		// Token: 0x1700130F RID: 4879
		// (get) Token: 0x0600D6C2 RID: 54978 RVA: 0x003CD540 File Offset: 0x003CB740
		// (set) Token: 0x0600D6C3 RID: 54979 RVA: 0x003CD548 File Offset: 0x003CB748
		public int camp { get; set; }

		// Token: 0x17001310 RID: 4880
		// (get) Token: 0x0600D6C4 RID: 54980 RVA: 0x003CD551 File Offset: 0x003CB751
		// (set) Token: 0x0600D6C5 RID: 54981 RVA: 0x003CD559 File Offset: 0x003CB759
		public int id { get; set; }

		// Token: 0x17001311 RID: 4881
		// (get) Token: 0x0600D6C6 RID: 54982 RVA: 0x003CD562 File Offset: 0x003CB762
		// (set) Token: 0x0600D6C7 RID: 54983 RVA: 0x003CD56A File Offset: 0x003CB76A
		public int initialhp { get; set; }

		// Token: 0x17001312 RID: 4882
		// (get) Token: 0x0600D6C8 RID: 54984 RVA: 0x003CD573 File Offset: 0x003CB773
		// (set) Token: 0x0600D6C9 RID: 54985 RVA: 0x003CD57B File Offset: 0x003CB77B
		public int stageid { get; set; }

		// Token: 0x17001313 RID: 4883
		// (get) Token: 0x0600D6CA RID: 54986 RVA: 0x003CD584 File Offset: 0x003CB784
		// (set) Token: 0x0600D6CB RID: 54987 RVA: 0x003CD58C File Offset: 0x003CB78C
		public int type { get; set; }

		// Token: 0x0600D6CC RID: 54988 RVA: 0x003CD598 File Offset: 0x003CB798
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.bornpoint = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.bornpoint[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.buildingid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.camp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.initialhp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.linkbuilding = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.linkbuilding[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.stageid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.startaction = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					this.startaction[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
