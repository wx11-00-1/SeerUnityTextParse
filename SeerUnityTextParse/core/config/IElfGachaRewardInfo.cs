using System;

namespace core.config
{
	public class IElfGachaRewardInfo : IConfigItem
	{
        public string endtime { get; set; }

        public string starttime { get; set; }

        public int consumeid { get; set; }

        public int consumnum { get; set; }

        public int Discount { get; set; }

        public int Distance { get; set; }

        public int id { get; set; }

        public int NewMsglogId { get; set; }

        public int Pet5thMove { get; set; }

        public int PetID { get; set; }

        public int PetLimit { get; set; }

        public int PetMint { get; set; }

        public int PetNewseId { get; set; }

        public int poolid { get; set; }

        public int pooltype { get; set; }

        public int quality { get; set; }

        public void Parse(byte[] bytes, ref int byteIndex)
        {
            Discount = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            Distance = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            NewMsglogId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            Pet5thMove = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            PetID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            PetLimit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            PetMint = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            PetNewseId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            consumeid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            consumnum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            endtime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            poolid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            pooltype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            quality = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            starttime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
        }
    }
}
