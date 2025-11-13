using System;

namespace core.config.petbook
{
	// Token: 0x02001F6F RID: 8047
	public class IRoot
	{
		// Token: 0x17001C81 RID: 7297
		// (get) Token: 0x0600F182 RID: 61826 RVA: 0x003F62CA File Offset: 0x003F44CA
		// (set) Token: 0x0600F183 RID: 61827 RVA: 0x003F62D2 File Offset: 0x003F44D2
		public IHotPet HotPet { get; set; }

		// Token: 0x17001C82 RID: 7298
		// (get) Token: 0x0600F184 RID: 61828 RVA: 0x003F62DB File Offset: 0x003F44DB
		// (set) Token: 0x0600F185 RID: 61829 RVA: 0x003F62E3 File Offset: 0x003F44E3
		public IHotspot Hotspot { get; set; }

		// Token: 0x17001C83 RID: 7299
		// (get) Token: 0x0600F186 RID: 61830 RVA: 0x003F62EC File Offset: 0x003F44EC
		// (set) Token: 0x0600F187 RID: 61831 RVA: 0x003F62F4 File Offset: 0x003F44F4
		public IMonsterItem[] Monster { get; set; }

		// Token: 0x17001C84 RID: 7300
		// (get) Token: 0x0600F188 RID: 61832 RVA: 0x003F62FD File Offset: 0x003F44FD
		// (set) Token: 0x0600F189 RID: 61833 RVA: 0x003F6305 File Offset: 0x003F4505
		public IRecMintmark RecMintmark { get; set; }

		// Token: 0x0600F18A RID: 61834 RVA: 0x003F6310 File Offset: 0x003F4510
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
