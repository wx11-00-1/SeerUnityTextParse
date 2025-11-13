using System;

namespace core.config.itemsOptimizeCatItems5
{
	// Token: 0x02001FEE RID: 8174
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001E74 RID: 7796
		// (get) Token: 0x0600F685 RID: 63109 RVA: 0x003FC029 File Offset: 0x003FA229
		public override string fileName
		{
			get
			{
				return "itemsOptimizeCatItems5";
			}
		}

		// Token: 0x17001E75 RID: 7797
		// (get) Token: 0x0600F686 RID: 63110 RVA: 0x003FC030 File Offset: 0x003FA230
		// (set) Token: 0x0600F687 RID: 63111 RVA: 0x003FC038 File Offset: 0x003FA238
		public IItemsItem[] items { get; set; }

		// Token: 0x0600F688 RID: 63112 RVA: 0x003FC044 File Offset: 0x003FA244
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

		// Token: 0x0600F689 RID: 63113 RVA: 0x003FC098 File Offset: 0x003FA298
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
