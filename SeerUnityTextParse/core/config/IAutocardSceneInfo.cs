using System;

namespace core.config
{
	public class IAutocardSceneInfo : IConfigItem
	{
        public string bookresouce { get; set; }

        public string des { get; set; }

        public string name { get; set; }

        public string resource { get; set; }

        public string tag { get; set; }

        public int id { get; set; }

        public int rarity { get; set; }

        public int stat { get; set; }

        public void Parse(byte[] bytes, ref int byteIndex)
        {
            bookresouce = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            resource = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            stat = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            tag = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
        }
    }
}
