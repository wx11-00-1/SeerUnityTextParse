using System;

namespace core.config.monsters
{
	public class IRootInterface : ConfigBase<IRootInterface>
	{
        public override string fileName => "monsters";

        public IMonsters Monsters { get; set; }

        public void Parse(byte[] bytes, ref int byteIndex)
        {
            int byteIndex2 = byteIndex;
            if (byteIndex2 < bytes.Length)
            {
                if (bytes[byteIndex2++] != 0)
                {
                    Monsters = new IMonsters();
                    Monsters.Parse(bytes, ref byteIndex2);
                }
                byteIndex = byteIndex2;
            }
        }

        public override void Parse(byte[] bytes)
        {
            int byteIndex = 0;
            Parse(bytes, ref byteIndex);
        }
    }
}
