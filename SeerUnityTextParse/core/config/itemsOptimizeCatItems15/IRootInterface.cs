using System;

namespace core.config.itemsOptimizeCatItems15
{
	// Token: 0x0200200C RID: 8204
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001F1F RID: 7967
		// (get) Token: 0x0600F890 RID: 63632 RVA: 0x003FDED1 File Offset: 0x003FC0D1
		public override string fileName
		{
			get
			{
				return "itemsOptimizeCatItems15";
			}
		}

		// Token: 0x17001F20 RID: 7968
		// (get) Token: 0x0600F891 RID: 63633 RVA: 0x003FDED8 File Offset: 0x003FC0D8
		// (set) Token: 0x0600F892 RID: 63634 RVA: 0x003FDEE0 File Offset: 0x003FC0E0
		public IItemsItem[] items { get; set; }

		// Token: 0x0600F893 RID: 63635 RVA: 0x003FDEEC File Offset: 0x003FC0EC
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

		// Token: 0x0600F894 RID: 63636 RVA: 0x003FDF40 File Offset: 0x003FC140
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
