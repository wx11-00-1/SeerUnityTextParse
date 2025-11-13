using System;

namespace core.config
{
	// Token: 0x02001DCA RID: 7626
	public class IPrivateSignInfo : IConfigItem
	{
		// Token: 0x1700170B RID: 5899
		// (get) Token: 0x0600E086 RID: 57478 RVA: 0x003D95B8 File Offset: 0x003D77B8
		// (set) Token: 0x0600E087 RID: 57479 RVA: 0x003D95C0 File Offset: 0x003D77C0
		public string intro { get; set; }

		// Token: 0x1700170C RID: 5900
		// (get) Token: 0x0600E088 RID: 57480 RVA: 0x003D95C9 File Offset: 0x003D77C9
		// (set) Token: 0x0600E089 RID: 57481 RVA: 0x003D95D1 File Offset: 0x003D77D1
		public string name { get; set; }

		// Token: 0x1700170D RID: 5901
		// (get) Token: 0x0600E08A RID: 57482 RVA: 0x003D95DA File Offset: 0x003D77DA
		// (set) Token: 0x0600E08B RID: 57483 RVA: 0x003D95E2 File Offset: 0x003D77E2
		public int[] reward { get; set; }

		// Token: 0x1700170E RID: 5902
		// (get) Token: 0x0600E08C RID: 57484 RVA: 0x003D95EB File Offset: 0x003D77EB
		// (set) Token: 0x0600E08D RID: 57485 RVA: 0x003D95F3 File Offset: 0x003D77F3
		public int[] rewardPet { get; set; }

		// Token: 0x1700170F RID: 5903
		// (get) Token: 0x0600E08E RID: 57486 RVA: 0x003D95FC File Offset: 0x003D77FC
		// (set) Token: 0x0600E08F RID: 57487 RVA: 0x003D9604 File Offset: 0x003D7804
		public int day { get; set; }

		// Token: 0x17001710 RID: 5904
		// (get) Token: 0x0600E090 RID: 57488 RVA: 0x003D960D File Offset: 0x003D780D
		// (set) Token: 0x0600E091 RID: 57489 RVA: 0x003D9615 File Offset: 0x003D7815
		public int id { get; set; }

		// Token: 0x17001711 RID: 5905
		// (get) Token: 0x0600E092 RID: 57490 RVA: 0x003D961E File Offset: 0x003D781E
		// (set) Token: 0x0600E093 RID: 57491 RVA: 0x003D9626 File Offset: 0x003D7826
		public int petId { get; set; }

		// Token: 0x0600E094 RID: 57492 RVA: 0x003D9630 File Offset: 0x003D7830
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.day = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.intro = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.petId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.reward = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.reward[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.rewardPet = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.rewardPet[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
