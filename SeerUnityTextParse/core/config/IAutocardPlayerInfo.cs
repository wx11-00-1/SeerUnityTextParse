using System;

namespace core.config
{
	public class IAutocardPlayerInfo : IConfigItem
	{
        public string action1 { get; set; }

        public string action2 { get; set; }

        public string action3 { get; set; }

        public string des { get; set; }

        public string name { get; set; }

        public string resource { get; set; }

        public string skin { get; set; }

        public string tag { get; set; }

        public int id { get; set; }

        public int jumpinfo { get; set; }

        public int moveSpeed { get; set; }

        public int rarity { get; set; }

        public void Parse(byte[] bytes, ref int byteIndex)
        {
            action1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            action2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            action3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            jumpinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            moveSpeed = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            resource = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            skin = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            tag = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
        }
    }
}
