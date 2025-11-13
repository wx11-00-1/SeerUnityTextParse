using System;

namespace core.config.open_time_limit
{
	// Token: 0x02001F7B RID: 8059
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001C9A RID: 7322
		// (get) Token: 0x0600F1CC RID: 61900 RVA: 0x003F6893 File Offset: 0x003F4A93
		public override string fileName
		{
			get
			{
				return "open_time_limit";
			}
		}

		// Token: 0x17001C9B RID: 7323
		// (get) Token: 0x0600F1CD RID: 61901 RVA: 0x003F689A File Offset: 0x003F4A9A
		// (set) Token: 0x0600F1CE RID: 61902 RVA: 0x003F68A2 File Offset: 0x003F4AA2
		public IActivityConfigPool ActivityConfigPool { get; set; }

		// Token: 0x0600F1CF RID: 61903 RVA: 0x003F68AB File Offset: 0x003F4AAB
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.ActivityConfigPool = new IActivityConfigPool();
				this.ActivityConfigPool.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600F1D0 RID: 61904 RVA: 0x003F68D0 File Offset: 0x003F4AD0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
