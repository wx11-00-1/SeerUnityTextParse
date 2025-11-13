using System;

namespace core.config.itemsOptimizeCatItems14
{
	// Token: 0x0200200E RID: 8206
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001F2B RID: 7979
		// (get) Token: 0x0600F8B6 RID: 63670 RVA: 0x003FE0FD File Offset: 0x003FC2FD
		public override string fileName
		{
			get
			{
				return "itemsOptimizeCatItems14";
			}
		}

		// Token: 0x17001F2C RID: 7980
		// (get) Token: 0x0600F8B7 RID: 63671 RVA: 0x003FE104 File Offset: 0x003FC304
		// (set) Token: 0x0600F8B8 RID: 63672 RVA: 0x003FE10C File Offset: 0x003FC30C
		public IItemsItem[] items { get; set; }

		// Token: 0x0600F8B9 RID: 63673 RVA: 0x003FE118 File Offset: 0x003FC318
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

		// Token: 0x0600F8BA RID: 63674 RVA: 0x003FE16C File Offset: 0x003FC36C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
