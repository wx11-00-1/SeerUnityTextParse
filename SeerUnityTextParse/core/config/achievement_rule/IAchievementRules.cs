using System;

namespace core.config.achievement_rule
{
	// Token: 0x02002084 RID: 8324
	public class IAchievementRules
	{
		// Token: 0x17002143 RID: 8515
		// (get) Token: 0x0600FE21 RID: 65057 RVA: 0x00403F30 File Offset: 0x00402130
		// (set) Token: 0x0600FE22 RID: 65058 RVA: 0x00403F38 File Offset: 0x00402138
		public IBranchItem[] Branch { get; set; }

		// Token: 0x0600FE23 RID: 65059 RVA: 0x00403F44 File Offset: 0x00402144
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Branch = new IBranchItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Branch[i] = new IBranchItem();
					this.Branch[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
