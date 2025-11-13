using System;
using common;
using core.config.battle_effects;


namespace core.config
{
	// Token: 0x02001EB8 RID: 7864
	public class PetStatusEffectConfig : ConfigManagerSingleton<PetStatusEffectConfig>
	{
		// Token: 0x0600EB1A RID: 60186 RVA: 0x003EC026 File Offset: 0x003EA226

		// Token: 0x0600EB1B RID: 60187 RVA: 0x003EC02F File Offset: 0x003EA22F
		

		// Token: 0x0600EB1C RID: 60188 RVA: 0x003EC040 File Offset: 0x003EA240
		

		// Token: 0x0600EB1D RID: 60189 RVA: 0x003EC084 File Offset: 0x003EA284
		public IBattleEffectItem getEffectByType(int type)
		{
			foreach (IBattleEffectItem battleEffectItem in this.s_Xml)
			{
				if (battleEffectItem.Type == type)
				{
					return battleEffectItem;
				}
			}
			return null;
		}

		// Token: 0x0600EB1E RID: 60190 RVA: 0x003EC0B8 File Offset: 0x003EA2B8
		private ISubEffectItem getxmlnodeById(IBattleEffectItem tmpxml, int id)
		{
			ISubEffectItem[] subEffect = tmpxml.SubEffect;
			for (int i = subEffect.Length - 1; i >= 0; i--)
			{
				if (subEffect[i].ID == id)
				{
					return subEffect[i];
				}
			}
			return null;
		}

		// Token: 0x0600EB1F RID: 60191 RVA: 0x003EC0EC File Offset: 0x003EA2EC
		public ISubEffectItem getSubEffectItem(int type, int id)
		{
			IBattleEffectItem effectByType = this.getEffectByType(type);
			if (effectByType != null)
			{
				ISubEffectItem subEffectItem = this.getxmlnodeById(effectByType, id);
				if (subEffectItem != null && subEffectItem.Name != null)
				{
					return subEffectItem;
				}
			}
			return null;
		}

		// Token: 0x0600EB20 RID: 60192 RVA: 0x003EC11C File Offset: 0x003EA31C
		public string getName(int type, int id)
		{
			IBattleEffectItem effectByType = this.getEffectByType(type);
			if (effectByType != null)
			{
				ISubEffectItem subEffectItem = this.getxmlnodeById(effectByType, id);
				if (subEffectItem != null && subEffectItem.Name != null)
				{
					return subEffectItem.Name;
				}
			}
			return string.Empty;
		}

		// Token: 0x0400EECD RID: 61133
		private IBattleEffectItem[] s_Xml;
	}
}
