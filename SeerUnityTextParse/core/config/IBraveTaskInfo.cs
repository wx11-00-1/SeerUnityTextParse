using System;

namespace core.config
{
	// Token: 0x02001CDE RID: 7390
	public class IBraveTaskInfo : IConfigItem
	{
		// Token: 0x170012F7 RID: 4855
		// (get) Token: 0x0600D686 RID: 54918 RVA: 0x003CD07C File Offset: 0x003CB27C
		// (set) Token: 0x0600D687 RID: 54919 RVA: 0x003CD084 File Offset: 0x003CB284
		public string title { get; set; }

		// Token: 0x170012F8 RID: 4856
		// (get) Token: 0x0600D688 RID: 54920 RVA: 0x003CD08D File Offset: 0x003CB28D
		// (set) Token: 0x0600D689 RID: 54921 RVA: 0x003CD095 File Offset: 0x003CB295
		public int[] jump { get; set; }

		// Token: 0x170012F9 RID: 4857
		// (get) Token: 0x0600D68A RID: 54922 RVA: 0x003CD09E File Offset: 0x003CB29E
		// (set) Token: 0x0600D68B RID: 54923 RVA: 0x003CD0A6 File Offset: 0x003CB2A6
		public int[] rewardinfo { get; set; }

		// Token: 0x170012FA RID: 4858
		// (get) Token: 0x0600D68C RID: 54924 RVA: 0x003CD0AF File Offset: 0x003CB2AF
		// (set) Token: 0x0600D68D RID: 54925 RVA: 0x003CD0B7 File Offset: 0x003CB2B7
		public int[] taskparam { get; set; }

		// Token: 0x170012FB RID: 4859
		// (get) Token: 0x0600D68E RID: 54926 RVA: 0x003CD0C0 File Offset: 0x003CB2C0
		// (set) Token: 0x0600D68F RID: 54927 RVA: 0x003CD0C8 File Offset: 0x003CB2C8
		public int group { get; set; }

		// Token: 0x170012FC RID: 4860
		// (get) Token: 0x0600D690 RID: 54928 RVA: 0x003CD0D1 File Offset: 0x003CB2D1
		// (set) Token: 0x0600D691 RID: 54929 RVA: 0x003CD0D9 File Offset: 0x003CB2D9
		public int id { get; set; }

		// Token: 0x170012FD RID: 4861
		// (get) Token: 0x0600D692 RID: 54930 RVA: 0x003CD0E2 File Offset: 0x003CB2E2
		// (set) Token: 0x0600D693 RID: 54931 RVA: 0x003CD0EA File Offset: 0x003CB2EA
		public int tasktype { get; set; }

		// Token: 0x0600D694 RID: 54932 RVA: 0x003CD0F4 File Offset: 0x003CB2F4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.group = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.jump = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.jump[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.rewardinfo = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.rewardinfo[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.taskparam = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					this.taskparam[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.tasktype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
