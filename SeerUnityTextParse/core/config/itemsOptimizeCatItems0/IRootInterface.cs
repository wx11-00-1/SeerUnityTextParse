using System;

namespace core.config.itemsOptimizeCatItems0
{
	// Token: 0x0200201A RID: 8218
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001F85 RID: 8069
		// (get) Token: 0x0600F9D1 RID: 63953 RVA: 0x003FF0C4 File Offset: 0x003FD2C4
		public override string fileName
		{
			get
			{
				return "itemsOptimizeCatItems0";
			}
		}

		// Token: 0x17001F86 RID: 8070
		// (get) Token: 0x0600F9D2 RID: 63954 RVA: 0x003FF0CB File Offset: 0x003FD2CB
		// (set) Token: 0x0600F9D3 RID: 63955 RVA: 0x003FF0D3 File Offset: 0x003FD2D3
		public IItemsItem[] items { get; set; }

		// Token: 0x0600F9D4 RID: 63956 RVA: 0x003FF0DC File Offset: 0x003FD2DC
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

		// Token: 0x0600F9D5 RID: 63957 RVA: 0x003FF130 File Offset: 0x003FD330
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
