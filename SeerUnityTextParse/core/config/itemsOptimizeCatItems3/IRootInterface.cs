using System;

namespace core.config.itemsOptimizeCatItems3
{
	// Token: 0x02001FF2 RID: 8178
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001E97 RID: 7831
		// (get) Token: 0x0600F6F2 RID: 63218 RVA: 0x003FC662 File Offset: 0x003FA862
		public override string fileName
		{
			get
			{
				return "itemsOptimizeCatItems3";
			}
		}

		// Token: 0x17001E98 RID: 7832
		// (get) Token: 0x0600F6F3 RID: 63219 RVA: 0x003FC669 File Offset: 0x003FA869
		// (set) Token: 0x0600F6F4 RID: 63220 RVA: 0x003FC671 File Offset: 0x003FA871
		public IItemsItem[] items { get; set; }

		// Token: 0x0600F6F5 RID: 63221 RVA: 0x003FC67C File Offset: 0x003FA87C
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

		// Token: 0x0600F6F6 RID: 63222 RVA: 0x003FC6D0 File Offset: 0x003FA8D0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
