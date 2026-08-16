using System;

namespace core.config
{
	// Token: 0x02002776 RID: 10102
	public class ArmorHeroNWSkill : XlsConfigBase<ArmorHeroNWSkill, IArmorHeroNWSkillInfo>
	{
		// Token: 0x17001888 RID: 6280
		// (get) Token: 0x06013FD8 RID: 81880 RVA: 0x005A503D File Offset: 0x005A323D
		public override string fileName
		{
			get
			{
				return "armorHeroNWSkill";
			}
		}

		// Token: 0x06013FD9 RID: 81881 RVA: 0x005A5044 File Offset: 0x005A3244
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IArmorHeroNWSkillInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IArmorHeroNWSkillInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06013FDA RID: 81882 RVA: 0x005A5098 File Offset: 0x005A3298
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
