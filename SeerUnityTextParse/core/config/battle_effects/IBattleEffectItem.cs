using System;

namespace core.config.battle_effects
{
	public class IBattleEffectItem
	{
        public ISubEffectItem[] SubEffect { get; set; }

        public int Type { get; set; }

        public void Parse(byte[] bytes, ref int byteIndex)
        {
            if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
            {
                int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
                SubEffect = new ISubEffectItem[num];
                for (int i = 0; i < num; i++)
                {
                    SubEffect[i] = new ISubEffectItem();
                    SubEffect[i].Parse(bytes, ref byteIndex);
                }
            }
            Type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
        }
    }
}
