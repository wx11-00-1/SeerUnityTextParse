using System;

namespace core.config
{
	// Token: 0x02001E78 RID: 7800
	public class ITeamTaskInfoInfo : IConfigItem
	{
		// Token: 0x17001A22 RID: 6690
		// (get) Token: 0x0600E810 RID: 59408 RVA: 0x003E2D2C File Offset: 0x003E0F2C
		// (set) Token: 0x0600E811 RID: 59409 RVA: 0x003E2D34 File Offset: 0x003E0F34
		public string TeamTaskDescription { get; set; }

		// Token: 0x17001A23 RID: 6691
		// (get) Token: 0x0600E812 RID: 59410 RVA: 0x003E2D3D File Offset: 0x003E0F3D
		// (set) Token: 0x0600E813 RID: 59411 RVA: 0x003E2D45 File Offset: 0x003E0F45
		public string TeamTaskName { get; set; }

		// Token: 0x17001A24 RID: 6692
		// (get) Token: 0x0600E814 RID: 59412 RVA: 0x003E2D4E File Offset: 0x003E0F4E
		// (set) Token: 0x0600E815 RID: 59413 RVA: 0x003E2D56 File Offset: 0x003E0F56
		public int[] TeamTaskBaseReward { get; set; }

		// Token: 0x17001A25 RID: 6693
		// (get) Token: 0x0600E816 RID: 59414 RVA: 0x003E2D5F File Offset: 0x003E0F5F
		// (set) Token: 0x0600E817 RID: 59415 RVA: 0x003E2D67 File Offset: 0x003E0F67
		public int[] TeamTaskExtraReward { get; set; }

		// Token: 0x17001A26 RID: 6694
		// (get) Token: 0x0600E818 RID: 59416 RVA: 0x003E2D70 File Offset: 0x003E0F70
		// (set) Token: 0x0600E819 RID: 59417 RVA: 0x003E2D78 File Offset: 0x003E0F78
		public int[] TeamTaskRecommendPets { get; set; }

		// Token: 0x17001A27 RID: 6695
		// (get) Token: 0x0600E81A RID: 59418 RVA: 0x003E2D81 File Offset: 0x003E0F81
		// (set) Token: 0x0600E81B RID: 59419 RVA: 0x003E2D89 File Offset: 0x003E0F89
		public int id { get; set; }

		// Token: 0x17001A28 RID: 6696
		// (get) Token: 0x0600E81C RID: 59420 RVA: 0x003E2D92 File Offset: 0x003E0F92
		// (set) Token: 0x0600E81D RID: 59421 RVA: 0x003E2D9A File Offset: 0x003E0F9A
		public int TeamTaskDispatchTime { get; set; }

		// Token: 0x17001A29 RID: 6697
		// (get) Token: 0x0600E81E RID: 59422 RVA: 0x003E2DA3 File Offset: 0x003E0FA3
		// (set) Token: 0x0600E81F RID: 59423 RVA: 0x003E2DAB File Offset: 0x003E0FAB
		public int TeamTaskNeedPetNum { get; set; }

		// Token: 0x17001A2A RID: 6698
		// (get) Token: 0x0600E820 RID: 59424 RVA: 0x003E2DB4 File Offset: 0x003E0FB4
		// (set) Token: 0x0600E821 RID: 59425 RVA: 0x003E2DBC File Offset: 0x003E0FBC
		public int TeamTaskStar { get; set; }

		// Token: 0x0600E822 RID: 59426 RVA: 0x003E2DC8 File Offset: 0x003E0FC8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.TeamTaskBaseReward = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.TeamTaskBaseReward[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.TeamTaskDescription = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.TeamTaskDispatchTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.TeamTaskExtraReward = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.TeamTaskExtraReward[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.TeamTaskName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.TeamTaskNeedPetNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.TeamTaskRecommendPets = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					this.TeamTaskRecommendPets[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.TeamTaskStar = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
