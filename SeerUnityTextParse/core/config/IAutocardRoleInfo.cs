using System;

namespace core.config
{
	public class IAutocardRoleInfo : IConfigItem
	{
        public string BuffId { get; set; }

        public string BuffParam { get; set; }

        public string desc { get; set; }

        public string name { get; set; }

        public string skillName { get; set; }

        public string skillTxt { get; set; }

        public string skillUpgrade { get; set; }

        public int CountNum { get; set; }

        public int Display { get; set; }

        public int health { get; set; }

        public int id { get; set; }

        public int nature { get; set; }

        public int picID { get; set; }

        public int skillCostNum { get; set; }

        public int skillGameLimit { get; set; }

        public int skillID { get; set; }

        public int skillRoundLimit { get; set; }

        public int skillType { get; set; }

        public void Parse(byte[] bytes, ref int byteIndex)
        {
            BuffId = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            BuffParam = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            CountNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            Display = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            health = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            nature = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            picID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            skillCostNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            skillGameLimit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            skillID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            skillName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            skillRoundLimit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            skillTxt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            skillType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            skillUpgrade = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
        }
    }
}
