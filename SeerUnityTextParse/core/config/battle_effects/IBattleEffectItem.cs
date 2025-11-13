using System;

namespace core.config.battle_effects
{
	// Token: 0x02002063 RID: 8291
	public class IBattleEffectItem
	{
		// Token: 0x170020F2 RID: 8434
		// (get) Token: 0x0600FD3D RID: 64829 RVA: 0x00402E24 File Offset: 0x00401024
		// (set) Token: 0x0600FD3E RID: 64830 RVA: 0x00402E2C File Offset: 0x0040102C
		public ISubEffectItem[] SubEffect { get; set; }

		// Token: 0x170020F3 RID: 8435
		// (get) Token: 0x0600FD3F RID: 64831 RVA: 0x00402E35 File Offset: 0x00401035
		// (set) Token: 0x0600FD40 RID: 64832 RVA: 0x00402E3D File Offset: 0x0040103D
		public int Type { get; set; }

		// Token: 0x0600FD41 RID: 64833 RVA: 0x00402E48 File Offset: 0x00401048
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.SubEffect = new ISubEffectItem[num];
				for (int i = 0; i < num; i++)
				{
					this.SubEffect[i] = new ISubEffectItem();
					this.SubEffect[i].Parse(bytes, ref byteIndex);
				}
			}
			this.Type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
