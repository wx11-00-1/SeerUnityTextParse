using System;

namespace core.config.petbook_temp
{
	// Token: 0x02001F59 RID: 8025
	public class IRoot
	{
		// Token: 0x17001C39 RID: 7225
		// (get) Token: 0x0600F0C6 RID: 61638 RVA: 0x003F538A File Offset: 0x003F358A
		// (set) Token: 0x0600F0C7 RID: 61639 RVA: 0x003F5392 File Offset: 0x003F3592
		public IHotPet HotPet { get; set; }

		// Token: 0x17001C3A RID: 7226
		// (get) Token: 0x0600F0C8 RID: 61640 RVA: 0x003F539B File Offset: 0x003F359B
		// (set) Token: 0x0600F0C9 RID: 61641 RVA: 0x003F53A3 File Offset: 0x003F35A3
		public IHotspot Hotspot { get; set; }

		// Token: 0x17001C3B RID: 7227
		// (get) Token: 0x0600F0CA RID: 61642 RVA: 0x003F53AC File Offset: 0x003F35AC
		// (set) Token: 0x0600F0CB RID: 61643 RVA: 0x003F53B4 File Offset: 0x003F35B4
		public IMonsterItem[] Monster { get; set; }

		// Token: 0x17001C3C RID: 7228
		// (get) Token: 0x0600F0CC RID: 61644 RVA: 0x003F53BD File Offset: 0x003F35BD
		// (set) Token: 0x0600F0CD RID: 61645 RVA: 0x003F53C5 File Offset: 0x003F35C5
		public IRecMintmark RecMintmark { get; set; }

		// Token: 0x0600F0CE RID: 61646 RVA: 0x003F53D0 File Offset: 0x003F35D0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.HotPet = new IHotPet();
				this.HotPet.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Hotspot = new IHotspot();
				this.Hotspot.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Monster = new IMonsterItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Monster[i] = new IMonsterItem();
					this.Monster[i].Parse(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.RecMintmark = new IRecMintmark();
				this.RecMintmark.Parse(bytes, ref byteIndex);
			}
		}
	}
}
