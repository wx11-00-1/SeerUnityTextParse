using System;

namespace core.config.itemsOptimizeCatItems18
{
	// Token: 0x02002006 RID: 8198
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001EF6 RID: 7926
		// (get) Token: 0x0600F813 RID: 63507 RVA: 0x003FD7A9 File Offset: 0x003FB9A9
		public override string fileName
		{
			get
			{
				return "itemsOptimizeCatItems18";
			}
		}

		// Token: 0x17001EF7 RID: 7927
		// (get) Token: 0x0600F814 RID: 63508 RVA: 0x003FD7B0 File Offset: 0x003FB9B0
		// (set) Token: 0x0600F815 RID: 63509 RVA: 0x003FD7B8 File Offset: 0x003FB9B8
		public IItemsItem[] items { get; set; }

		// Token: 0x0600F816 RID: 63510 RVA: 0x003FD7C4 File Offset: 0x003FB9C4
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

		// Token: 0x0600F817 RID: 63511 RVA: 0x003FD818 File Offset: 0x003FBA18
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
