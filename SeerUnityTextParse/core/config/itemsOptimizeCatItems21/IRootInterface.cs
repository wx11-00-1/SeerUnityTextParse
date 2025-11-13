using System;

namespace core.config.itemsOptimizeCatItems21
{
	// Token: 0x02001FFE RID: 8190
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001ED5 RID: 7893
		// (get) Token: 0x0600F7B0 RID: 63408 RVA: 0x003FD191 File Offset: 0x003FB391
		public override string fileName
		{
			get
			{
				return "itemsOptimizeCatItems21";
			}
		}

		// Token: 0x17001ED6 RID: 7894
		// (get) Token: 0x0600F7B1 RID: 63409 RVA: 0x003FD198 File Offset: 0x003FB398
		// (set) Token: 0x0600F7B2 RID: 63410 RVA: 0x003FD1A0 File Offset: 0x003FB3A0
		public IItemsItem[] items { get; set; }

		// Token: 0x0600F7B3 RID: 63411 RVA: 0x003FD1AC File Offset: 0x003FB3AC
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

		// Token: 0x0600F7B4 RID: 63412 RVA: 0x003FD200 File Offset: 0x003FB400
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
