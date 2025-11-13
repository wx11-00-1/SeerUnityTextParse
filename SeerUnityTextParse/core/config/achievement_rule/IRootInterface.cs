using System;

namespace core.config.achievement_rule
{
	// Token: 0x02002086 RID: 8326
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17002146 RID: 8518
		// (get) Token: 0x0600FE2B RID: 65067 RVA: 0x00403FE4 File Offset: 0x004021E4
		public override string fileName
		{
			get
			{
				return "achievement_rule";
			}
		}

		// Token: 0x17002147 RID: 8519
		// (get) Token: 0x0600FE2C RID: 65068 RVA: 0x00403FEB File Offset: 0x004021EB
		// (set) Token: 0x0600FE2D RID: 65069 RVA: 0x00403FF3 File Offset: 0x004021F3
		public IAchievementRules AchievementRules { get; set; }

		// Token: 0x0600FE2E RID: 65070 RVA: 0x00403FFC File Offset: 0x004021FC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.AchievementRules = new IAchievementRules();
				this.AchievementRules.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600FE2F RID: 65071 RVA: 0x00404020 File Offset: 0x00402220
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
