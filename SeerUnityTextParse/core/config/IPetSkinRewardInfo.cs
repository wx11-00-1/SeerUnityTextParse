using System;

namespace core.config
{
	public class IPetSkinRewardInfo : IConfigItem
	{
        public string changereward { get; set; }

        public string reward { get; set; }

        public int id { get; set; }

        public int param { get; set; }

        public int redbadge { get; set; }

        public int skintype { get; set; }

        public int stainfo { get; set; }

        public int subtype { get; set; }

        public int userbit { get; set; }

        public int userinfo { get; set; }

        public int userinfo1 { get; set; }

        public void Parse(byte[] bytes, ref int byteIndex)
        {
            changereward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            param = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            redbadge = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            skintype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            stainfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            subtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            userbit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            userinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            userinfo1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
        }
    }
}
