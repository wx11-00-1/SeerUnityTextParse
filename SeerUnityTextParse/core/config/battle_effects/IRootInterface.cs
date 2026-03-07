using System;

namespace core.config.battle_effects
{
	public class IRootInterface : ConfigBase<IRootInterface>
	{
        public override string fileName => "battle_effects";

        public IBattleEffects BattleEffects { get; set; }

        public void Parse(byte[] bytes, ref int byteIndex)
        {
            if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
            {
                BattleEffects = new IBattleEffects();
                BattleEffects.Parse(bytes, ref byteIndex);
            }
        }

        public override void Parse(byte[] bytes)
        {
            int byteIndex = 0;
            Parse(bytes, ref byteIndex);
        }
    }
}
