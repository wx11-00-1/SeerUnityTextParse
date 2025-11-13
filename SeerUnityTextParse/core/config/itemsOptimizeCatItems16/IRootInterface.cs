using System;

namespace core.config.itemsOptimizeCatItems16
{
	// Token: 0x0200200A RID: 8202
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001F13 RID: 7955
		// (get) Token: 0x0600F86A RID: 63594 RVA: 0x003FDCA5 File Offset: 0x003FBEA5
		public override string fileName
		{
			get
			{
				return "itemsOptimizeCatItems16";
			}
		}

		// Token: 0x17001F14 RID: 7956
		// (get) Token: 0x0600F86B RID: 63595 RVA: 0x003FDCAC File Offset: 0x003FBEAC
		// (set) Token: 0x0600F86C RID: 63596 RVA: 0x003FDCB4 File Offset: 0x003FBEB4
		public IItemsItem[] items { get; set; }

		// Token: 0x0600F86D RID: 63597 RVA: 0x003FDCC0 File Offset: 0x003FBEC0
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

		// Token: 0x0600F86E RID: 63598 RVA: 0x003FDD14 File Offset: 0x003FBF14
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
