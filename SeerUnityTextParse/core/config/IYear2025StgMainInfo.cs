using System;

namespace core.config
{
	// Token: 0x02001E94 RID: 7828
	public class IYear2025StgMainInfo : IConfigItem
	{
		// Token: 0x17001A8B RID: 6795
		// (get) Token: 0x0600E91A RID: 59674 RVA: 0x003E42F8 File Offset: 0x003E24F8
		// (set) Token: 0x0600E91B RID: 59675 RVA: 0x003E4300 File Offset: 0x003E2500
		public string bossMessages { get; set; }

		// Token: 0x17001A8C RID: 6796
		// (get) Token: 0x0600E91C RID: 59676 RVA: 0x003E4309 File Offset: 0x003E2509
		// (set) Token: 0x0600E91D RID: 59677 RVA: 0x003E4311 File Offset: 0x003E2511
		public string skills { get; set; }

		// Token: 0x17001A8D RID: 6797
		// (get) Token: 0x0600E91E RID: 59678 RVA: 0x003E431A File Offset: 0x003E251A
		// (set) Token: 0x0600E91F RID: 59679 RVA: 0x003E4322 File Offset: 0x003E2522
		public int[] args { get; set; }

		// Token: 0x17001A8E RID: 6798
		// (get) Token: 0x0600E920 RID: 59680 RVA: 0x003E432B File Offset: 0x003E252B
		// (set) Token: 0x0600E921 RID: 59681 RVA: 0x003E4333 File Offset: 0x003E2533
		public int[] bossSkillSpeed { get; set; }

		// Token: 0x17001A8F RID: 6799
		// (get) Token: 0x0600E922 RID: 59682 RVA: 0x003E433C File Offset: 0x003E253C
		// (set) Token: 0x0600E923 RID: 59683 RVA: 0x003E4344 File Offset: 0x003E2544
		public int[] playerSkills { get; set; }

		// Token: 0x17001A90 RID: 6800
		// (get) Token: 0x0600E924 RID: 59684 RVA: 0x003E434D File Offset: 0x003E254D
		// (set) Token: 0x0600E925 RID: 59685 RVA: 0x003E4355 File Offset: 0x003E2555
		public int bossSpeed { get; set; }

		// Token: 0x17001A91 RID: 6801
		// (get) Token: 0x0600E926 RID: 59686 RVA: 0x003E435E File Offset: 0x003E255E
		// (set) Token: 0x0600E927 RID: 59687 RVA: 0x003E4366 File Offset: 0x003E2566
		public int bossState { get; set; }

		// Token: 0x17001A92 RID: 6802
		// (get) Token: 0x0600E928 RID: 59688 RVA: 0x003E436F File Offset: 0x003E256F
		// (set) Token: 0x0600E929 RID: 59689 RVA: 0x003E4377 File Offset: 0x003E2577
		public int finishCondition { get; set; }

		// Token: 0x17001A93 RID: 6803
		// (get) Token: 0x0600E92A RID: 59690 RVA: 0x003E4380 File Offset: 0x003E2580
		// (set) Token: 0x0600E92B RID: 59691 RVA: 0x003E4388 File Offset: 0x003E2588
		public int health { get; set; }

		// Token: 0x17001A94 RID: 6804
		// (get) Token: 0x0600E92C RID: 59692 RVA: 0x003E4391 File Offset: 0x003E2591
		// (set) Token: 0x0600E92D RID: 59693 RVA: 0x003E4399 File Offset: 0x003E2599
		public int id { get; set; }

		// Token: 0x17001A95 RID: 6805
		// (get) Token: 0x0600E92E RID: 59694 RVA: 0x003E43A2 File Offset: 0x003E25A2
		// (set) Token: 0x0600E92F RID: 59695 RVA: 0x003E43AA File Offset: 0x003E25AA
		public int type { get; set; }

		// Token: 0x0600E930 RID: 59696 RVA: 0x003E43B4 File Offset: 0x003E25B4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.args = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.args[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.bossMessages = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.bossSkillSpeed = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.bossSkillSpeed[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.bossSpeed = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.bossState = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.finishCondition = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.health = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.playerSkills = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					this.playerSkills[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.skills = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
