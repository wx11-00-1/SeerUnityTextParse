using System;

namespace core.config
{
	public class ElGacha : XlsConfigBase<ElGacha, IElGachaInfo>
	{
        public override string fileName => "elGacha";

        public void Parse(byte[] bytes, ref int byteIndex)
        {
            if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
            {
                int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
                data = new IElGachaInfo[num];
                for (int i = 0; i < num; i++)
                {
                    data[i] = new IElGachaInfo();
                    data[i].Parse(bytes, ref byteIndex);
                }
            }
        }

        public override void Parse(byte[] bytes)
        {
            int byteIndex = 0;
            Parse(bytes, ref byteIndex);
        }
	}
}
