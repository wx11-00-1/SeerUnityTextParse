using System;

namespace core.config
{
	public class ElfGachaReward : XlsConfigBase<ElfGachaReward, IElfGachaRewardInfo>
	{
        public override string fileName => "elfGachaReward";

        public void Parse(byte[] bytes, ref int byteIndex)
        {
            if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
            {
                int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
                data = new IElfGachaRewardInfo[num];
                for (int i = 0; i < num; i++)
                {
                    data[i] = new IElfGachaRewardInfo();
                    data[i].Parse(bytes, ref byteIndex);
                }
            }
        }

        public override void Parse(byte[] bytes)
        {
            int byteIndex = 0;
            Parse(bytes, ref byteIndex);
        }
    }
}
