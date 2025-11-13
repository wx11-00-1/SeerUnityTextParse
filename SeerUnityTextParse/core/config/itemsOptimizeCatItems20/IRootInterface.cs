using System;

namespace core.config.itemsOptimizeCatItems20
{
	// Token: 0x02002000 RID: 8192
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001EDB RID: 7899
		// (get) Token: 0x0600F7C0 RID: 63424 RVA: 0x003FD2A9 File Offset: 0x003FB4A9
		public override string fileName
		{
			get
			{
				return "itemsOptimizeCatItems20";
			}
		}

		// Token: 0x17001EDC RID: 7900
		// (get) Token: 0x0600F7C1 RID: 63425 RVA: 0x003FD2B0 File Offset: 0x003FB4B0
		// (set) Token: 0x0600F7C2 RID: 63426 RVA: 0x003FD2B8 File Offset: 0x003FB4B8
		public IItemsItem[] items { get; set; }

		// Token: 0x0600F7C3 RID: 63427 RVA: 0x003FD2C4 File Offset: 0x003FB4C4
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

		// Token: 0x0600F7C4 RID: 63428 RVA: 0x003FD318 File Offset: 0x003FB518
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
