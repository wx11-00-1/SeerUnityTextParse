using System;

namespace core.config.pvp_practice
{
	public class IRoot
	{
        public IItemItem[] item { get; set; }

        public void Parse(byte[] bytes, ref int byteIndex)
        {
            if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
            {
                int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
                item = new IItemItem[num];
                for (int i = 0; i < num; i++)
                {
                    item[i] = new IItemItem();
                    item[i].Parse(bytes, ref byteIndex);
                }
            }
        }
    }
}
