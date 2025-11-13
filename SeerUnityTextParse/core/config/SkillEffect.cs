using System;

namespace core.config
{
	// Token: 0x02001E25 RID: 7717
	public class SkillEffect : XlsConfigBase<SkillEffect, ISkillEffectInfo>
	{
		// Token: 0x170018A9 RID: 6313
		// (get) Token: 0x0600E478 RID: 58488 RVA: 0x003DE695 File Offset: 0x003DC895
		public override string fileName
		{
			get
			{
				return "skill_effect";
			}
		}

		// Token: 0x0600E479 RID: 58489 RVA: 0x003DE69C File Offset: 0x003DC89C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ISkillEffectInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ISkillEffectInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E47A RID: 58490 RVA: 0x003DE6F0 File Offset: 0x003DC8F0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
