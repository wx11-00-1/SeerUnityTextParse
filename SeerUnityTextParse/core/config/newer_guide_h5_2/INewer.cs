using System;

namespace core.config.newer_guide_h5_2
{
	// Token: 0x02001F92 RID: 8082
	public class INewer
	{
		// Token: 0x17001CE9 RID: 7401
		// (get) Token: 0x0600F298 RID: 62104 RVA: 0x003F7720 File Offset: 0x003F5920
		// (set) Token: 0x0600F299 RID: 62105 RVA: 0x003F7728 File Offset: 0x003F5928
		public IPet dialog { get; set; }

		// Token: 0x17001CEA RID: 7402
		// (get) Token: 0x0600F29A RID: 62106 RVA: 0x003F7731 File Offset: 0x003F5931
		// (set) Token: 0x0600F29B RID: 62107 RVA: 0x003F7739 File Offset: 0x003F5939
		public IPet pet { get; set; }

		// Token: 0x17001CEB RID: 7403
		// (get) Token: 0x0600F29C RID: 62108 RVA: 0x003F7742 File Offset: 0x003F5942
		// (set) Token: 0x0600F29D RID: 62109 RVA: 0x003F774A File Offset: 0x003F594A
		public IStepsItem[] steps { get; set; }

		// Token: 0x0600F29E RID: 62110 RVA: 0x003F7754 File Offset: 0x003F5954
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.dialog = new IPet();
				this.dialog.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.pet = new IPet();
				this.pet.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.steps = new IStepsItem[num];
				for (int i = 0; i < num; i++)
				{
					this.steps[i] = new IStepsItem();
					this.steps[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
