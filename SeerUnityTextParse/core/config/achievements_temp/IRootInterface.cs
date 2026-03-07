using System;

namespace core.config.achievements_temp
{
	// Token: 0x0200235A RID: 9050
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x170024F6 RID: 9462
		// (get) Token: 0x06011A52 RID: 72274 RVA: 0x0046DEB6 File Offset: 0x0046C0B6
		public override string fileName
		{
			get
			{
				return "achievements_temp";
			}
		}

		// Token: 0x170024F7 RID: 9463
		// (get) Token: 0x06011A53 RID: 72275 RVA: 0x0046DEBD File Offset: 0x0046C0BD
		// (set) Token: 0x06011A54 RID: 72276 RVA: 0x0046DEC5 File Offset: 0x0046C0C5
		public IAchievementRules AchievementRules { get; set; }

		// Token: 0x06011A55 RID: 72277 RVA: 0x0046DECE File Offset: 0x0046C0CE
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.AchievementRules = new IAchievementRules();
				this.AchievementRules.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x06011A56 RID: 72278 RVA: 0x0046DEF4 File Offset: 0x0046C0F4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
