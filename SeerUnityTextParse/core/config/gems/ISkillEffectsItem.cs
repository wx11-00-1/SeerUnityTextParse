using System;

namespace core.config.gems
{
	// Token: 0x0200202F RID: 8239
	public class ISkillEffectsItem
	{
		// Token: 0x17002052 RID: 8274
		// (get) Token: 0x0600FB95 RID: 64405 RVA: 0x00400EF8 File Offset: 0x003FF0F8
		// (set) Token: 0x0600FB96 RID: 64406 RVA: 0x00400F00 File Offset: 0x003FF100
		public IEffect Effect { get; set; }

		// Token: 0x0600FB97 RID: 64407 RVA: 0x00400F09 File Offset: 0x003FF109
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Effect = new IEffect();
				this.Effect.Parse(bytes, ref byteIndex);
			}
		}
	}
}
