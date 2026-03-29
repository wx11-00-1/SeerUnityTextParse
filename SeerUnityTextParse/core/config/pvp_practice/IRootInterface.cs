using System;

namespace core.config.pvp_practice
{
	public class IRootInterface : ConfigBase<IRootInterface>
	{
        public override string fileName => "pvp_practice";

        public IRoot root { get; set; }

        public void Parse(byte[] bytes, ref int byteIndex)
        {
            if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
            {
                root = new IRoot();
                root.Parse(bytes, ref byteIndex);
            }
        }

        public override void Parse(byte[] bytes)
        {
            int byteIndex = 0;
            Parse(bytes, ref byteIndex);
        }
    }
}
