using System;

namespace core.config.achievements
{
	// Token: 0x0200208B RID: 8331
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x1700215C RID: 8540
		// (get) Token: 0x0600FE61 RID: 65121 RVA: 0x004043CE File Offset: 0x004025CE
		public override string fileName
		{
			get
			{
				return "achievements";
			}
		}

		// Token: 0x1700215D RID: 8541
		// (get) Token: 0x0600FE62 RID: 65122 RVA: 0x004043D5 File Offset: 0x004025D5
		// (set) Token: 0x0600FE63 RID: 65123 RVA: 0x004043DD File Offset: 0x004025DD
		public IAchievementRules AchievementRules { get; set; }

		// Token: 0x0600FE64 RID: 65124 RVA: 0x004043E6 File Offset: 0x004025E6
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.AchievementRules = new IAchievementRules();
				this.AchievementRules.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600FE65 RID: 65125 RVA: 0x0040440C File Offset: 0x0040260C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
