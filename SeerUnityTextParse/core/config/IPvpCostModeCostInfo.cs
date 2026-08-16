using System;

namespace core.config
{
	public class IPvpCostModeCostInfo : IConfigItem
	{
        public string name { get; set; }

        public string pet { get; set; }

        public string time { get; set; }

        public int cost { get; set; }

        public int id { get; set; }

        public int subkeyMonth { get; set; }

        public int subkeyTotal { get; set; }

        public void Parse(byte[] bytes, ref int byteIndex)
        {
            cost = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            pet = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            subkeyMonth = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            subkeyTotal = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            time = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
        }
    }
}
