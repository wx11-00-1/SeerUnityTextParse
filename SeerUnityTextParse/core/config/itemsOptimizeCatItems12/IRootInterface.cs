using System;

namespace core.config.itemsOptimizeCatItems12
{
	// Token: 0x02002012 RID: 8210
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001F48 RID: 8008
		// (get) Token: 0x0600F912 RID: 63762 RVA: 0x003FE621 File Offset: 0x003FC821
		public override string fileName
		{
			get
			{
				return "itemsOptimizeCatItems12";
			}
		}

		// Token: 0x17001F49 RID: 8009
		// (get) Token: 0x0600F913 RID: 63763 RVA: 0x003FE628 File Offset: 0x003FC828
		// (set) Token: 0x0600F914 RID: 63764 RVA: 0x003FE630 File Offset: 0x003FC830
		public IItemsItem[] items { get; set; }

		// Token: 0x0600F915 RID: 63765 RVA: 0x003FE63C File Offset: 0x003FC83C
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

		// Token: 0x0600F916 RID: 63766 RVA: 0x003FE690 File Offset: 0x003FC890
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
