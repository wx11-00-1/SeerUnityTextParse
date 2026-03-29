using System;

namespace core.config.TitleBg
{
	public class IRootInterface : ConfigBase<IRootInterface>
	{
        public override string fileName => "TitleBg";

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
