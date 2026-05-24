using System;

namespace core.config
{
	public class IAutocardContentInfo : IConfigItem
	{
        public string BuffId { get; set; }

        public string BuffParam { get; set; }

        public string cardTxt { get; set; }

        public string des { get; set; }

        public string name { get; set; }

        public int attack { get; set; }

        public int compose { get; set; }

        public int composeTo { get; set; }

        public int cost { get; set; }

        public int CountNum { get; set; }

        public int Display { get; set; }

        public int health { get; set; }

        public int id { get; set; }

        public int isUse { get; set; }

        public int level { get; set; }

        public int nature { get; set; }

        public int picID { get; set; }

        public int subtype { get; set; }

        public int type { get; set; }

        public void Parse(byte[] bytes, ref int byteIndex)
        {
            BuffId = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            BuffParam = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            CountNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            Display = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            attack = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            cardTxt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            compose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            composeTo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            cost = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            health = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            isUse = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            nature = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            picID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            subtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
        }
    }
}
