using System;

namespace core.config
{
	public class IItemgainInfo : IConfigItem
	{
        public string target { get; set; }

        public string text { get; set; }

        public int id { get; set; }

        public int type { get; set; }

        public int usetarget { get; set; }

        public void Parse(byte[] bytes, ref int byteIndex)
        {
            id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            target = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            text = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            usetarget = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
        }
    }
}
