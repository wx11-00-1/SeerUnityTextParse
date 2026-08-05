using System;

namespace core.config.itemsOptimizeCatItems30
{
	// Token: 0x02002BD8 RID: 11224
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17002CD2 RID: 11474
		// (get) Token: 0x06016FD8 RID: 94168 RVA: 0x005D0561 File Offset: 0x005CE761
		public override string fileName
		{
			get
			{
				return "itemsOptimizeCatItems30";
			}
		}

		// Token: 0x17002CD3 RID: 11475
		// (get) Token: 0x06016FD9 RID: 94169 RVA: 0x005D0568 File Offset: 0x005CE768
		// (set) Token: 0x06016FDA RID: 94170 RVA: 0x005D0570 File Offset: 0x005CE770
		public IItemsItem[] items { get; set; }

		// Token: 0x06016FDB RID: 94171 RVA: 0x005D057C File Offset: 0x005CE77C
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

		// Token: 0x06016FDC RID: 94172 RVA: 0x005D05D0 File Offset: 0x005CE7D0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
