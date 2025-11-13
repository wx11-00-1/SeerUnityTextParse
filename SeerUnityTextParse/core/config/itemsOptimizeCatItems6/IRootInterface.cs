using System;

namespace core.config.itemsOptimizeCatItems6
{
	// Token: 0x02001FEC RID: 8172
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001E67 RID: 7783
		// (get) Token: 0x0600F65C RID: 63068 RVA: 0x003FBDD5 File Offset: 0x003F9FD5
		public override string fileName
		{
			get
			{
				return "itemsOptimizeCatItems6";
			}
		}

		// Token: 0x17001E68 RID: 7784
		// (get) Token: 0x0600F65D RID: 63069 RVA: 0x003FBDDC File Offset: 0x003F9FDC
		// (set) Token: 0x0600F65E RID: 63070 RVA: 0x003FBDE4 File Offset: 0x003F9FE4
		public IItemsItem[] items { get; set; }

		// Token: 0x0600F65F RID: 63071 RVA: 0x003FBDF0 File Offset: 0x003F9FF0
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

		// Token: 0x0600F660 RID: 63072 RVA: 0x003FBE44 File Offset: 0x003FA044
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
