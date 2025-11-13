using System;

namespace core.config.itemsOptimizeCatItems1
{
	// Token: 0x02002018 RID: 8216
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001F76 RID: 8054
		// (get) Token: 0x0600F9A2 RID: 63906 RVA: 0x003FEE26 File Offset: 0x003FD026
		public override string fileName
		{
			get
			{
				return "itemsOptimizeCatItems1";
			}
		}

		// Token: 0x17001F77 RID: 8055
		// (get) Token: 0x0600F9A3 RID: 63907 RVA: 0x003FEE2D File Offset: 0x003FD02D
		// (set) Token: 0x0600F9A4 RID: 63908 RVA: 0x003FEE35 File Offset: 0x003FD035
		public IItemsItem[] items { get; set; }

		// Token: 0x0600F9A5 RID: 63909 RVA: 0x003FEE40 File Offset: 0x003FD040
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

		// Token: 0x0600F9A6 RID: 63910 RVA: 0x003FEE94 File Offset: 0x003FD094
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
