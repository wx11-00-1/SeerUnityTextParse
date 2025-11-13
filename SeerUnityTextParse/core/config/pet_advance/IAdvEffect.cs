using System;

namespace core.config.pet_advance
{
	// Token: 0x02001F41 RID: 8001
	public class IAdvEffect
	{
		// Token: 0x17001BEC RID: 7148
		// (get) Token: 0x0600EFFC RID: 61436 RVA: 0x003F443C File Offset: 0x003F263C
		// (set) Token: 0x0600EFFD RID: 61437 RVA: 0x003F4444 File Offset: 0x003F2644
		public string Des { get; set; }

		// Token: 0x17001BED RID: 7149
		// (get) Token: 0x0600EFFE RID: 61438 RVA: 0x003F444D File Offset: 0x003F264D
		// (set) Token: 0x0600EFFF RID: 61439 RVA: 0x003F4455 File Offset: 0x003F2655
		public int Id { get; set; }

		// Token: 0x0600F000 RID: 61440 RVA: 0x003F445E File Offset: 0x003F265E
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
