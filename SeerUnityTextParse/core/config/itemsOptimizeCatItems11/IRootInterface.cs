using System;

namespace core.config.itemsOptimizeCatItems11
{
	// Token: 0x02002014 RID: 8212
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001F56 RID: 8022
		// (get) Token: 0x0600F93E RID: 63806 RVA: 0x003FE894 File Offset: 0x003FCA94
		public override string fileName
		{
			get
			{
				return "itemsOptimizeCatItems11";
			}
		}

		// Token: 0x17001F57 RID: 8023
		// (get) Token: 0x0600F93F RID: 63807 RVA: 0x003FE89B File Offset: 0x003FCA9B
		// (set) Token: 0x0600F940 RID: 63808 RVA: 0x003FE8A3 File Offset: 0x003FCAA3
		public IItemsItem[] items { get; set; }

		// Token: 0x0600F941 RID: 63809 RVA: 0x003FE8AC File Offset: 0x003FCAAC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.items = new IItemsItem[num];
				for (int i = 0; i < num; i++)
				{
					this.items[i] = new IItemsItem();
					this.items[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600F942 RID: 63810 RVA: 0x003FE900 File Offset: 0x003FCB00
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
