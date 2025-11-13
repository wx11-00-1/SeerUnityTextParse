using System;

namespace core.config.peak_battle_mons
{
	// Token: 0x02001F75 RID: 8053
	public class IWeeklyIDItem
	{
		// Token: 0x17001C8D RID: 7309
		// (get) Token: 0x0600F1A6 RID: 61862 RVA: 0x003F65B8 File Offset: 0x003F47B8
		// (set) Token: 0x0600F1A7 RID: 61863 RVA: 0x003F65C0 File Offset: 0x003F47C0
		public string NewSeIcon { get; set; }

		// Token: 0x17001C8E RID: 7310
		// (get) Token: 0x0600F1A8 RID: 61864 RVA: 0x003F65C9 File Offset: 0x003F47C9
		// (set) Token: 0x0600F1A9 RID: 61865 RVA: 0x003F65D1 File Offset: 0x003F47D1
		public int HomeAdditionMon { get; set; }

		// Token: 0x0600F1AA RID: 61866 RVA: 0x003F65DA File Offset: 0x003F47DA
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.HomeAdditionMon = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.NewSeIcon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
