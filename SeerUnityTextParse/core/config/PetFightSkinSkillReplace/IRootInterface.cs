using System;

namespace core.config.PetFightSkinSkillReplace
{
	// Token: 0x02001F4F RID: 8015
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001C18 RID: 7192
		// (get) Token: 0x0600F070 RID: 61552 RVA: 0x003F4D06 File Offset: 0x003F2F06
		public override string fileName
		{
			get
			{
				return "PetFightSkinSkillReplace";
			}
		}

		// Token: 0x17001C19 RID: 7193
		// (get) Token: 0x0600F071 RID: 61553 RVA: 0x003F4D0D File Offset: 0x003F2F0D
		// (set) Token: 0x0600F072 RID: 61554 RVA: 0x003F4D15 File Offset: 0x003F2F15
		public IRoot Root { get; set; }

		// Token: 0x0600F073 RID: 61555 RVA: 0x003F4D1E File Offset: 0x003F2F1E
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Root = new IRoot();
				this.Root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600F074 RID: 61556 RVA: 0x003F4D44 File Offset: 0x003F2F44
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
