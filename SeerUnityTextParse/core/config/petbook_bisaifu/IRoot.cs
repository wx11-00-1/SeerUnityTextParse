using System;

namespace core.config.petbook_bisaifu
{
	// Token: 0x02001F64 RID: 8036
	public class IRoot
	{
		// Token: 0x17001C5D RID: 7261
		// (get) Token: 0x0600F124 RID: 61732 RVA: 0x003F5B26 File Offset: 0x003F3D26
		// (set) Token: 0x0600F125 RID: 61733 RVA: 0x003F5B2E File Offset: 0x003F3D2E
		public IHotPet HotPet { get; set; }

		// Token: 0x17001C5E RID: 7262
		// (get) Token: 0x0600F126 RID: 61734 RVA: 0x003F5B37 File Offset: 0x003F3D37
		// (set) Token: 0x0600F127 RID: 61735 RVA: 0x003F5B3F File Offset: 0x003F3D3F
		public IHotspot Hotspot { get; set; }

		// Token: 0x17001C5F RID: 7263
		// (get) Token: 0x0600F128 RID: 61736 RVA: 0x003F5B48 File Offset: 0x003F3D48
		// (set) Token: 0x0600F129 RID: 61737 RVA: 0x003F5B50 File Offset: 0x003F3D50
		public IMonsterItem[] Monster { get; set; }

		// Token: 0x17001C60 RID: 7264
		// (get) Token: 0x0600F12A RID: 61738 RVA: 0x003F5B59 File Offset: 0x003F3D59
		// (set) Token: 0x0600F12B RID: 61739 RVA: 0x003F5B61 File Offset: 0x003F3D61
		public IRecMintmark RecMintmark { get; set; }

		// Token: 0x0600F12C RID: 61740 RVA: 0x003F5B6C File Offset: 0x003F3D6C
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
