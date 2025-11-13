using System;

namespace core.config.itemsOptimizeCatItems9
{
	// Token: 0x02001FE6 RID: 8166
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001E4E RID: 7758
		// (get) Token: 0x0600F60F RID: 62991 RVA: 0x003FB925 File Offset: 0x003F9B25
		public override string fileName
		{
			get
			{
				return "itemsOptimizeCatItems9";
			}
		}

		// Token: 0x17001E4F RID: 7759
		// (get) Token: 0x0600F610 RID: 62992 RVA: 0x003FB92C File Offset: 0x003F9B2C
		// (set) Token: 0x0600F611 RID: 62993 RVA: 0x003FB934 File Offset: 0x003F9B34
		public IItemsItem[] items { get; set; }

		// Token: 0x0600F612 RID: 62994 RVA: 0x003FB940 File Offset: 0x003F9B40
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

		// Token: 0x0600F613 RID: 62995 RVA: 0x003FB994 File Offset: 0x003F9B94
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
