using System;

namespace core.config
{
	// Token: 0x0200271E RID: 10014
	public class MysteryBoxGameSkill : XlsConfigBase<MysteryBoxGameSkill, IMysteryBoxGameSkillInfo>
	{
		// Token: 0x17001F7C RID: 8060
		// (get) Token: 0x06013C1F RID: 80927 RVA: 0x0055CBC7 File Offset: 0x0055ADC7
		public override string fileName
		{
			get
			{
				return "mysteryBoxGameSkill";
			}
		}

		// Token: 0x06013C20 RID: 80928 RVA: 0x0055CBD0 File Offset: 0x0055ADD0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IMysteryBoxGameSkillInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IMysteryBoxGameSkillInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06013C21 RID: 80929 RVA: 0x0055CC24 File Offset: 0x0055AE24
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
