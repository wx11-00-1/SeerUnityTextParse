using System;

namespace core.config.pvp_practice
{
	public class IItemItem
	{
        public string describe { get; set; }

        public string prompt { get; set; }

        public string rewardinfo { get; set; }

        public int ID { get; set; }

        public int lv { get; set; }

        public int monsterid { get; set; }

        public int type { get; set; }

        public void Parse(byte[] bytes, ref int byteIndex)
        {
            ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            lv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            monsterid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            prompt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            rewardinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
        }
    }
}
