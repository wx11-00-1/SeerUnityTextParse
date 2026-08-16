using System;

namespace core.config.elvenkingtrial_exchange
{
	public class ISwapItem : IConfigItem
	{
        public int id { get; set; }

        public int rewards { get; set; }

        public void Parse(byte[] bytes, ref int byteIndex)
        {
            id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            rewards = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
        }
    }
}
