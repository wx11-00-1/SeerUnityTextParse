using System;

namespace core.config.PetFightSkinSkillReplace
{
	// Token: 0x02001F4D RID: 8013
	public class IItemItem
	{
		// Token: 0x17001C14 RID: 7188
		// (get) Token: 0x0600F064 RID: 61540 RVA: 0x003F4C21 File Offset: 0x003F2E21
		// (set) Token: 0x0600F065 RID: 61541 RVA: 0x003F4C29 File Offset: 0x003F2E29
		public ISkill skill { get; set; }

		// Token: 0x17001C15 RID: 7189
		// (get) Token: 0x0600F066 RID: 61542 RVA: 0x003F4C32 File Offset: 0x003F2E32
		// (set) Token: 0x0600F067 RID: 61543 RVA: 0x003F4C3A File Offset: 0x003F2E3A
		public int petid { get; set; }

		// Token: 0x17001C16 RID: 7190
		// (get) Token: 0x0600F068 RID: 61544 RVA: 0x003F4C43 File Offset: 0x003F2E43
		// (set) Token: 0x0600F069 RID: 61545 RVA: 0x003F4C4B File Offset: 0x003F2E4B
		public int skinid { get; set; }

		// Token: 0x0600F06A RID: 61546 RVA: 0x003F4C54 File Offset: 0x003F2E54
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.petid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.skill = new ISkill();
				this.skill.Parse(bytes, ref byteIndex);
			}
			this.skinid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
