using System;

namespace core.config
{
	public class IElfGachaInfo : IConfigItem
	{
        public string endtime { get; set; }

        public string name { get; set; }

        public string starttime { get; set; }

        public int Aitem { get; set; }

        public int Bitem { get; set; }

        public int cost1 { get; set; }

        public int discost { get; set; }

        public int disitem { get; set; }

        public int exchangeNum { get; set; }

        public int id { get; set; }

        public int miditem { get; set; }

        public int poolid { get; set; }

        public int Sitem { get; set; }

        public int SSitem { get; set; }

        public int taskred { get; set; }

        public int ticket { get; set; }

        public int Tips { get; set; }

        public int videotype { get; set; }

        public void Parse(byte[] bytes, ref int byteIndex)
        {
            Aitem = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            Bitem = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            SSitem = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            Sitem = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            Tips = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            cost1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            discost = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            disitem = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            endtime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            exchangeNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            miditem = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            poolid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            starttime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            taskred = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            ticket = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            videotype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
        }
    }
}
