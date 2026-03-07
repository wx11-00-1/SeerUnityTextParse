using System;

namespace core.config.battle_effects
{
	public class ISubEffectItem
	{
        public string Name { get; set; }

        public int Ctrl { get; set; }

        public int Dependent { get; set; }

        public int Derivation { get; set; }

        public int Efftype { get; set; }

        public int ID { get; set; }

        public int Restriction { get; set; }

        public int Unctrl { get; set; }

        public int Undependent { get; set; }

        public int Underivation { get; set; }

        public int Unrestriction { get; set; }

        public int Unweaken { get; set; }

        public int Weaken { get; set; }

        public void Parse(byte[] bytes, ref int byteIndex)
        {
            Ctrl = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            Dependent = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            Derivation = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            Efftype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
            Restriction = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            Unctrl = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            Undependent = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            Underivation = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            Unrestriction = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            Unweaken = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            Weaken = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
        }
    }
}
