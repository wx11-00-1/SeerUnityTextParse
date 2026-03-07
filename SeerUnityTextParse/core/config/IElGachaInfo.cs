using System;

namespace core.config
{
	public class IElGachaInfo : IConfigItem
	{
        public string endtime { get; set; }

        public string name { get; set; }

        public string starttime { get; set; }

        public int id { get; set; }

        public int poolid { get; set; }

        public int Sitem { get; set; }

        public int SSitem { get; set; }

        public int ticket { get; set; }

        public void Parse(byte[] bytes, ref int byteIndex)
        {
            SSitem = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            Sitem = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            endtime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            poolid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            starttime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            ticket = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
        }
    }
}
