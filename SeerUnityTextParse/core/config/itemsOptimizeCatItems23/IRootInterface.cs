using System;

namespace core.config.itemsOptimizeCatItems23
{
	// Token: 0x02001FFA RID: 8186
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001EC9 RID: 7881
		// (get) Token: 0x0600F790 RID: 63376 RVA: 0x003FCF64 File Offset: 0x003FB164
		public override string fileName
		{
			get
			{
				return "itemsOptimizeCatItems23";
			}
		}

		// Token: 0x17001ECA RID: 7882
		// (get) Token: 0x0600F791 RID: 63377 RVA: 0x003FCF6B File Offset: 0x003FB16B
		// (set) Token: 0x0600F792 RID: 63378 RVA: 0x003FCF73 File Offset: 0x003FB173
		public IItemsItem[] items { get; set; }

		// Token: 0x0600F793 RID: 63379 RVA: 0x003FCF7C File Offset: 0x003FB17C
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

		// Token: 0x0600F794 RID: 63380 RVA: 0x003FCFD0 File Offset: 0x003FB1D0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
