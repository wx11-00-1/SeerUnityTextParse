using System;

namespace core.config.battle_effects
{
	// Token: 0x02002065 RID: 8293
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x170020F5 RID: 8437
		// (get) Token: 0x0600FD47 RID: 64839 RVA: 0x00402F1A File Offset: 0x0040111A
		public override string fileName
		{
			get
			{
				return "battle_effects";
			}
		}

		// Token: 0x170020F6 RID: 8438
		// (get) Token: 0x0600FD48 RID: 64840 RVA: 0x00402F21 File Offset: 0x00401121
		// (set) Token: 0x0600FD49 RID: 64841 RVA: 0x00402F29 File Offset: 0x00401129
		public IBattleEffects BattleEffects { get; set; }

		// Token: 0x0600FD4A RID: 64842 RVA: 0x00402F32 File Offset: 0x00401132
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.BattleEffects = new IBattleEffects();
				this.BattleEffects.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600FD4B RID: 64843 RVA: 0x00402F58 File Offset: 0x00401158
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
