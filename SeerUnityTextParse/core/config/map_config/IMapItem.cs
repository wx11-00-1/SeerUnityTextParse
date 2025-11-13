using System;

namespace core.config.map_config
{
	// Token: 0x02001FD4 RID: 8148
	public class IMapItem : IConfigItem
	{
		// Token: 0x17001E22 RID: 7714
		// (get) Token: 0x0600F593 RID: 62867 RVA: 0x003FB08A File Offset: 0x003F928A
		// (set) Token: 0x0600F594 RID: 62868 RVA: 0x003FB092 File Offset: 0x003F9292
		public IChangeMapComp changeMapComp { get; set; }

		// Token: 0x17001E23 RID: 7715
		// (get) Token: 0x0600F595 RID: 62869 RVA: 0x003FB09B File Offset: 0x003F929B
		// (set) Token: 0x0600F596 RID: 62870 RVA: 0x003FB0A3 File Offset: 0x003F92A3
		public IEntries Entries { get; set; }

		// Token: 0x17001E24 RID: 7716
		// (get) Token: 0x0600F597 RID: 62871 RVA: 0x003FB0AC File Offset: 0x003F92AC
		// (set) Token: 0x0600F598 RID: 62872 RVA: 0x003FB0B4 File Offset: 0x003F92B4
		public int id { get; set; }

		// Token: 0x0600F599 RID: 62873 RVA: 0x003FB0C0 File Offset: 0x003F92C0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Entries = new IEntries();
				this.Entries.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.changeMapComp = new IChangeMapComp();
				this.changeMapComp.Parse(bytes, ref byteIndex);
			}
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
