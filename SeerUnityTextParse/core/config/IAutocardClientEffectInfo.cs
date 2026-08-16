using System;

namespace core.config
{
	public class IAutocardClientEffectInfo : IConfigItem
	{
        public string Des { get; set; }

        public int Duration { get; set; }

        public int id { get; set; }

        public int TimeLast { get; set; }

        public void Parse(byte[] bytes, ref int byteIndex)
        {
            Des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            Duration = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            TimeLast = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
        }
    }
}
