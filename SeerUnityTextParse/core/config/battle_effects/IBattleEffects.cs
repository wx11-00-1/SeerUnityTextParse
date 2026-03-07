using System;

namespace core.config.battle_effects
{
	public class IBattleEffects
	{
        public IBattleEffectItem[] BattleEffect { get; set; }

        public void Parse(byte[] bytes, ref int byteIndex)
        {
            if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
            {
                int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
                BattleEffect = new IBattleEffectItem[num];
                for (int i = 0; i < num; i++)
                {
                    BattleEffect[i] = new IBattleEffectItem();
                    BattleEffect[i].Parse(bytes, ref byteIndex);
                }
            }
        }
    }
}
