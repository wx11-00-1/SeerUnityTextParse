using System;

namespace core.config.elvenkingtrial_exchange
{
	public class IRoot
	{
        public IItems items { get; set; }

        public IRewards rewards { get; set; }

        public ISwaps swaps { get; set; }

        public void Parse(byte[] bytes, ref int byteIndex)
        {
            if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
            {
                items = new IItems();
                items.Parse(bytes, ref byteIndex);
            }
            if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
            {
                rewards = new IRewards();
                rewards.Parse(bytes, ref byteIndex);
            }
            if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
            {
                swaps = new ISwaps();
                swaps.Parse(bytes, ref byteIndex);
            }
        }
    }
}
