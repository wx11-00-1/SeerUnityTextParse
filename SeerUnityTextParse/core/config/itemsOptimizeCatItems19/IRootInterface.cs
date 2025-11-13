using System;

namespace core.config.itemsOptimizeCatItems19
{
	// Token: 0x02002004 RID: 8196
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001EEA RID: 7914
		// (get) Token: 0x0600F7ED RID: 63469 RVA: 0x003FD57D File Offset: 0x003FB77D
		public override string fileName
		{
			get
			{
				return "itemsOptimizeCatItems19";
			}
		}

		// Token: 0x17001EEB RID: 7915
		// (get) Token: 0x0600F7EE RID: 63470 RVA: 0x003FD584 File Offset: 0x003FB784
		// (set) Token: 0x0600F7EF RID: 63471 RVA: 0x003FD58C File Offset: 0x003FB78C
		public IItemsItem[] items { get; set; }

		// Token: 0x0600F7F0 RID: 63472 RVA: 0x003FD598 File Offset: 0x003FB798
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

		// Token: 0x0600F7F1 RID: 63473 RVA: 0x003FD5EC File Offset: 0x003FB7EC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
