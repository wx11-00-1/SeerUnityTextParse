using System;

namespace core.config.itemsOptimizeCatItems27
{
	// Token: 0x02002A3C RID: 10812
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17002B82 RID: 11138
		// (get) Token: 0x06015D98 RID: 89496 RVA: 0x0058E39F File Offset: 0x0058C59F
		public override string fileName
		{
			get
			{
				return "itemsOptimizeCatItems27";
			}
		}

		// Token: 0x17002B83 RID: 11139
		// (get) Token: 0x06015D99 RID: 89497 RVA: 0x0058E3A6 File Offset: 0x0058C5A6
		// (set) Token: 0x06015D9A RID: 89498 RVA: 0x0058E3AE File Offset: 0x0058C5AE
		public IItemsItem[] items { get; set; }

		// Token: 0x06015D9B RID: 89499 RVA: 0x0058E3B8 File Offset: 0x0058C5B8
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

		// Token: 0x06015D9C RID: 89500 RVA: 0x0058E40C File Offset: 0x0058C60C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
