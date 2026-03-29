using System;

namespace core.config
{
	// Token: 0x02002392 RID: 9106
	public class StgSkill : XlsConfigBase<StgSkill, IStgSkillInfo>
	{
		// Token: 0x17001FB7 RID: 8119
		// (get) Token: 0x06011712 RID: 71442 RVA: 0x0049D4E6 File Offset: 0x0049B6E6
		public override string fileName
		{
			get
			{
				return "stg_skill";
			}
		}

		// Token: 0x06011713 RID: 71443 RVA: 0x0049D4F0 File Offset: 0x0049B6F0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStgSkillInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStgSkillInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06011714 RID: 71444 RVA: 0x0049D544 File Offset: 0x0049B744
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
