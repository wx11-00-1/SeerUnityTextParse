using System;

namespace core.config.itemsOptimizeCatItems25
{
	public class IRootInterface : ConfigBase<IRootInterface>
	{
        public override string fileName => "itemsOptimizeCatItems25";

        public IItemsItem[] items { get; set; }

        public void Parse(byte[] bytes, ref int byteIndex)
        {
            if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
            {
                int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
                items = new IItemsItem[num];
                for (int i = 0; i < num; i++)
                {
                    items[i] = new IItemsItem();
                    items[i].Parse(bytes, ref byteIndex);
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
