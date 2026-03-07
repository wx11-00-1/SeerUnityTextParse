using System;

namespace core.config.signIcon_fight
{
	public class IItemItem : IConfigItem
	{
        public string className { get; set; }

        public string dec { get; set; }

        public string Des { get; set; }

        public string[] frame { get; set; }

        public string NumDes { get; set; }

        public string[] spDes { get; set; }

        public string SpDes { get; set; }

        public string[] spicon { get; set; }

        public string[] sptips { get; set; }

        public string tips { get; set; }

        public int id { get; set; }

        public int isShowNum { get; set; }

        public int showmonster { get; set; }

        public int showtime { get; set; }

        public int sort { get; set; }

        public void Parse(byte[] bytes, ref int byteIndex)
        {
            Des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            NumDes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            SpDes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            className = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            dec = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
            {
                int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
                frame = new string[num];
                for (int i = 0; i < num; i++)
                {
                    frame[i] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
                }
            }
            id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            isShowNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            showmonster = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            showtime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
            {
                int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
                spDes = new string[num2];
                for (int j = 0; j < num2; j++)
                {
                    spDes[j] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
                }
            }
            if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
            {
                int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
                spicon = new string[num3];
                for (int k = 0; k < num3; k++)
                {
                    spicon[k] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
                }
            }
            if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
            {
                int num4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
                sptips = new string[num4];
                for (int l = 0; l < num4; l++)
                {
                    sptips[l] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
                }
            }
            tips = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
        }
    }
}
