using System;

namespace core.config.signIcon_fight
{
	public class IRootInterface : ConfigBase<IRootInterface>
	{
        public override string fileName => "signIcon_fight";

        public IConfig config { get; set; }

        public void Parse(byte[] bytes, ref int byteIndex)
        {
            if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
            {
                config = new IConfig();
                config.Parse(bytes, ref byteIndex);
            }
        }

        public override void Parse(byte[] bytes)
        {
            int byteIndex = 0;
            Parse(bytes, ref byteIndex);
        }
    }
}
