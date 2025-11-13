using System;

namespace core.config
{
	// Token: 0x02001E95 RID: 7829
	public class Year2025StgSkill : XlsConfigBase<Year2025StgSkill, IYear2025StgSkillInfo>
	{
		// Token: 0x17001A96 RID: 6806
		// (get) Token: 0x0600E932 RID: 59698 RVA: 0x003E44EF File Offset: 0x003E26EF
		public override string fileName
		{
			get
			{
				return "year2025_stg_skill";
			}
		}

		// Token: 0x0600E933 RID: 59699 RVA: 0x003E44F8 File Offset: 0x003E26F8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IYear2025StgSkillInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IYear2025StgSkillInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E934 RID: 59700 RVA: 0x003E454C File Offset: 0x003E274C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
