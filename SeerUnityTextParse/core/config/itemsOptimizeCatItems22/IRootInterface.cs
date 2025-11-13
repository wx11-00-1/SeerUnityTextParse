using System;

namespace core.config.itemsOptimizeCatItems22
{
	// Token: 0x02001FFC RID: 8188
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001ECF RID: 7887
		// (get) Token: 0x0600F7A0 RID: 63392 RVA: 0x003FD079 File Offset: 0x003FB279
		public override string fileName
		{
			get
			{
				return "itemsOptimizeCatItems22";
			}
		}

		// Token: 0x17001ED0 RID: 7888
		// (get) Token: 0x0600F7A1 RID: 63393 RVA: 0x003FD080 File Offset: 0x003FB280
		// (set) Token: 0x0600F7A2 RID: 63394 RVA: 0x003FD088 File Offset: 0x003FB288
		public IItemsItem[] items { get; set; }

		// Token: 0x0600F7A3 RID: 63395 RVA: 0x003FD094 File Offset: 0x003FB294
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

		// Token: 0x0600F7A4 RID: 63396 RVA: 0x003FD0E8 File Offset: 0x003FB2E8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
