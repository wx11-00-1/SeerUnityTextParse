using System;

namespace core.config.MoveFgtvDes
{
	// Token: 0x02001FAA RID: 8106
	public class IMoveItem
	{
		// Token: 0x17001D5D RID: 7517
		// (get) Token: 0x0600F3B0 RID: 62384 RVA: 0x003F8D31 File Offset: 0x003F6F31
		// (set) Token: 0x0600F3B1 RID: 62385 RVA: 0x003F8D39 File Offset: 0x003F6F39
		public string FgtvDes { get; set; }

		// Token: 0x17001D5E RID: 7518
		// (get) Token: 0x0600F3B2 RID: 62386 RVA: 0x003F8D42 File Offset: 0x003F6F42
		// (set) Token: 0x0600F3B3 RID: 62387 RVA: 0x003F8D4A File Offset: 0x003F6F4A
		public int ID { get; set; }

		// Token: 0x0600F3B4 RID: 62388 RVA: 0x003F8D53 File Offset: 0x003F6F53
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.FgtvDes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
