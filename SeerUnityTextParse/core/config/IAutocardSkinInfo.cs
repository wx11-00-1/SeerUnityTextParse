using System;

namespace core.config
{
	public class IAutocardSkinInfo : IConfigItem
	{
        public string getDes { get; set; }

        public string name { get; set; }

        public string skinName { get; set; }

        public int contentId { get; set; }

        public int id { get; set; }

        public int jumpId { get; set; }

        public int series { get; set; }

        public int type { get; set; }

        public void Parse(byte[] bytes, ref int byteIndex)
        {
            contentId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            getDes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            jumpId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            series = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            skinName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
        }
    }
}
