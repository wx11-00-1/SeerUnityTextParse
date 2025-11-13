using System;

namespace core.config.newer_guide_h5_2
{
	// Token: 0x02001F94 RID: 8084
	public class IRoot
	{
		// Token: 0x17001CEF RID: 7407
		// (get) Token: 0x0600F2A8 RID: 62120 RVA: 0x003F7854 File Offset: 0x003F5A54
		// (set) Token: 0x0600F2A9 RID: 62121 RVA: 0x003F785C File Offset: 0x003F5A5C
		public INewer newer { get; set; }

		// Token: 0x17001CF0 RID: 7408
		// (get) Token: 0x0600F2AA RID: 62122 RVA: 0x003F7865 File Offset: 0x003F5A65
		// (set) Token: 0x0600F2AB RID: 62123 RVA: 0x003F786D File Offset: 0x003F5A6D
		public INewer newerpay { get; set; }

		// Token: 0x17001CF1 RID: 7409
		// (get) Token: 0x0600F2AC RID: 62124 RVA: 0x003F7876 File Offset: 0x003F5A76
		// (set) Token: 0x0600F2AD RID: 62125 RVA: 0x003F787E File Offset: 0x003F5A7E
		public INewer normal { get; set; }

		// Token: 0x17001CF2 RID: 7410
		// (get) Token: 0x0600F2AE RID: 62126 RVA: 0x003F7887 File Offset: 0x003F5A87
		// (set) Token: 0x0600F2AF RID: 62127 RVA: 0x003F788F File Offset: 0x003F5A8F
		public string timelimit { get; set; }

		// Token: 0x0600F2B0 RID: 62128 RVA: 0x003F7898 File Offset: 0x003F5A98
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.newer = new INewer();
				this.newer.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.newerpay = new INewer();
				this.newerpay.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.normal = new INewer();
				this.normal.Parse(bytes, ref byteIndex);
			}
			this.timelimit = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
