using System;

namespace core.config.itemsOptimizeCatItems25
{
	// Token: 0x02001FF6 RID: 8182
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001EAE RID: 7854
		// (get) Token: 0x0600F73B RID: 63291 RVA: 0x003FCA91 File Offset: 0x003FAC91
		public override string fileName
		{
			get
			{
				return "itemsOptimizeCatItems25";
			}
		}

		// Token: 0x17001EAF RID: 7855
		// (get) Token: 0x0600F73C RID: 63292 RVA: 0x003FCA98 File Offset: 0x003FAC98
		// (set) Token: 0x0600F73D RID: 63293 RVA: 0x003FCAA0 File Offset: 0x003FACA0
		public IItemsItem[] items { get; set; }

		// Token: 0x0600F73E RID: 63294 RVA: 0x003FCAAC File Offset: 0x003FACAC
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

		// Token: 0x0600F73F RID: 63295 RVA: 0x003FCB00 File Offset: 0x003FAD00
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
