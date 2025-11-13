using System;

namespace core.config.battle_effects
{
	// Token: 0x02002064 RID: 8292
	public class IBattleEffects
	{
		// Token: 0x170020F4 RID: 8436
		// (get) Token: 0x0600FD43 RID: 64835 RVA: 0x00402EAF File Offset: 0x004010AF
		// (set) Token: 0x0600FD44 RID: 64836 RVA: 0x00402EB7 File Offset: 0x004010B7
		public IBattleEffectItem[] BattleEffect { get; set; }

		// Token: 0x0600FD45 RID: 64837 RVA: 0x00402EC0 File Offset: 0x004010C0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.BattleEffect = new IBattleEffectItem[num];
				for (int i = 0; i < num; i++)
				{
					this.BattleEffect[i] = new IBattleEffectItem();
					this.BattleEffect[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
