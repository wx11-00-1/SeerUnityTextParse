using System;

namespace core.config.TitleBg
{
	public class IItemItem : IConfigItem
	{
        public string finishTime { get; set; }

        public string go { get; set; }

        public string introduction { get; set; }

        public string name { get; set; }

        public int id { get; set; }

        public int imageId { get; set; }

        public int isObtain { get; set; }

        public void Parse(byte[] bytes, ref int byteIndex)
        {
            finishTime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            go = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            imageId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            introduction = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            isObtain = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
        }
    }
}
