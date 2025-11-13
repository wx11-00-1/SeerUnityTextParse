using System;

namespace core.config.itemsOptimizeCatItems2
{
	// Token: 0x02002002 RID: 8194
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001EE4 RID: 7908
		// (get) Token: 0x0600F7DD RID: 63453 RVA: 0x003FD466 File Offset: 0x003FB666
		public override string fileName
		{
			get
			{
				return "itemsOptimizeCatItems2";
			}
		}

		// Token: 0x17001EE5 RID: 7909
		// (get) Token: 0x0600F7DE RID: 63454 RVA: 0x003FD46D File Offset: 0x003FB66D
		// (set) Token: 0x0600F7DF RID: 63455 RVA: 0x003FD475 File Offset: 0x003FB675
		public IItemsItem[] items { get; set; }

		// Token: 0x0600F7E0 RID: 63456 RVA: 0x003FD480 File Offset: 0x003FB680
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

		// Token: 0x0600F7E1 RID: 63457 RVA: 0x003FD4D4 File Offset: 0x003FB6D4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
