using System;

namespace core.config
{
	public class ITreasureChestGiftInfo : IConfigItem
	{
        public int[] probability { get; set; }

        public int[] rewardinfo { get; set; }

        public int count { get; set; }

        public int id { get; set; }

        public int type { get; set; }

        public void Parse(byte[] bytes, ref int byteIndex)
        {
            count = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
            {
                int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
                probability = new int[num];
                for (int i = 0; i < num; i++)
                {
                    probability[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
                }
            }
            if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
            {
                int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
                rewardinfo = new int[num2];
                for (int j = 0; j < num2; j++)
                {
                    rewardinfo[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
                }
            }
            type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
        }
    }
}
