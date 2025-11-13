using System;

namespace core.config.throw_item
{
	// Token: 0x02001F0F RID: 7951
	public class IItemItem : IConfigItem
	{
		// Token: 0x17001B2E RID: 6958
		// (get) Token: 0x0600EE1C RID: 60956 RVA: 0x003F2098 File Offset: 0x003F0298
		// (set) Token: 0x0600EE1D RID: 60957 RVA: 0x003F20A0 File Offset: 0x003F02A0
		public int hitEffect { get; set; }

		// Token: 0x17001B2F RID: 6959
		// (get) Token: 0x0600EE1E RID: 60958 RVA: 0x003F20A9 File Offset: 0x003F02A9
		// (set) Token: 0x0600EE1F RID: 60959 RVA: 0x003F20B1 File Offset: 0x003F02B1
		public int id { get; set; }

		// Token: 0x17001B30 RID: 6960
		// (get) Token: 0x0600EE20 RID: 60960 RVA: 0x003F20BA File Offset: 0x003F02BA
		// (set) Token: 0x0600EE21 RID: 60961 RVA: 0x003F20C2 File Offset: 0x003F02C2
		public int track { get; set; }

		// Token: 0x0600EE22 RID: 60962 RVA: 0x003F20CB File Offset: 0x003F02CB
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.hitEffect = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.track = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
