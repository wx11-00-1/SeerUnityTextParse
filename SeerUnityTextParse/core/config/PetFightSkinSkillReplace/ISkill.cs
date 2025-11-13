using System;

namespace core.config.PetFightSkinSkillReplace
{
	// Token: 0x02001F50 RID: 8016
	public class ISkill : IConfigItem
	{
		// Token: 0x17001C1A RID: 7194
		// (get) Token: 0x0600F076 RID: 61558 RVA: 0x003F4D64 File Offset: 0x003F2F64
		// (set) Token: 0x0600F077 RID: 61559 RVA: 0x003F4D6C File Offset: 0x003F2F6C
		public string action { get; set; }

		// Token: 0x17001C1B RID: 7195
		// (get) Token: 0x0600F078 RID: 61560 RVA: 0x003F4D75 File Offset: 0x003F2F75
		// (set) Token: 0x0600F079 RID: 61561 RVA: 0x003F4D7D File Offset: 0x003F2F7D
		public int id { get; set; }

		// Token: 0x17001C1C RID: 7196
		// (get) Token: 0x0600F07A RID: 61562 RVA: 0x003F4D86 File Offset: 0x003F2F86
		// (set) Token: 0x0600F07B RID: 61563 RVA: 0x003F4D8E File Offset: 0x003F2F8E
		public int replaceId { get; set; }

		// Token: 0x0600F07C RID: 61564 RVA: 0x003F4D97 File Offset: 0x003F2F97
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.action = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.replaceId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
