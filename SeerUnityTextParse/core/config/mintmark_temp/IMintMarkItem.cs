using System;

namespace core.config.mintmark_temp
{
	public class IMintMarkItem
    {
        public string Des { get; set; }

        public string EffectDes { get; set; }

        public int[] Arg { get; set; }

        public int[] BaseAttriValue { get; set; }

        public int[] ExtraAttriValue { get; set; }

        public int[] MaxAttriValue { get; set; }

        public int[] MonsterID { get; set; }

        public int[] MoveID { get; set; }

        public int Connect { get; set; }

        public int Grade { get; set; }

        public int Hide { get; set; }

        public int ID { get; set; }

        public int Level { get; set; }

        public int Max { get; set; }

        public int MintmarkClass { get; set; }

        public int Quality { get; set; }

        public int Rare { get; set; }

        public int Rarity { get; set; }

        public int TotalConsume { get; set; }

        public int Type { get; set; }

        public void Parse(byte[] bytes, ref int byteIndex)
        {
            if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
            {
                int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
                Arg = new int[num];
                for (int i = 0; i < num; i++)
                {
                    Arg[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
                }
            }
            if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
            {
                int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
                BaseAttriValue = new int[num2];
                for (int j = 0; j < num2; j++)
                {
                    BaseAttriValue[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
                }
            }
            Connect = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            Des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            EffectDes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
            {
                int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
                ExtraAttriValue = new int[num3];
                for (int k = 0; k < num3; k++)
                {
                    ExtraAttriValue[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
                }
            }
            Grade = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            Level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
            {
                int num4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
                MaxAttriValue = new int[num4];
                for (int l = 0; l < num4; l++)
                {
                    MaxAttriValue[l] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
                }
            }
            MintmarkClass = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
            {
                int num5 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
                MonsterID = new int[num5];
                for (int m = 0; m < num5; m++)
                {
                    MonsterID[m] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
                }
            }
            if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
            {
                int num6 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
                MoveID = new int[num6];
                for (int n = 0; n < num6; n++)
                {
                    MoveID[n] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
                }
            }
            Quality = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            Rare = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            Rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            TotalConsume = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            Type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
        }
    }
}
