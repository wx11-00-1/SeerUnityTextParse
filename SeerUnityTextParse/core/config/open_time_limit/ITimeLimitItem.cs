using System;

namespace core.config.open_time_limit
{
	// Token: 0x02001F7C RID: 8060
	public class ITimeLimitItem
	{
		// Token: 0x17001C9C RID: 7324
		// (get) Token: 0x0600F1D2 RID: 61906 RVA: 0x003F68F0 File Offset: 0x003F4AF0
		// (set) Token: 0x0600F1D3 RID: 61907 RVA: 0x003F68F8 File Offset: 0x003F4AF8
		public string EndTime { get; set; }

		// Token: 0x17001C9D RID: 7325
		// (get) Token: 0x0600F1D4 RID: 61908 RVA: 0x003F6901 File Offset: 0x003F4B01
		// (set) Token: 0x0600F1D5 RID: 61909 RVA: 0x003F6909 File Offset: 0x003F4B09
		public string StartTime { get; set; }

		// Token: 0x17001C9E RID: 7326
		// (get) Token: 0x0600F1D6 RID: 61910 RVA: 0x003F6912 File Offset: 0x003F4B12
		// (set) Token: 0x0600F1D7 RID: 61911 RVA: 0x003F691A File Offset: 0x003F4B1A
		public int TID { get; set; }

		// Token: 0x0600F1D8 RID: 61912 RVA: 0x003F6923 File Offset: 0x003F4B23
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.EndTime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.StartTime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.TID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
