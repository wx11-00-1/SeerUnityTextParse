using System;

namespace core.config.itemsOptimizeCatItems4
{
	// Token: 0x02001FF0 RID: 8176
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001E83 RID: 7811
		// (get) Token: 0x0600F6B4 RID: 63156 RVA: 0x003FC2CB File Offset: 0x003FA4CB
		public override string fileName
		{
			get
			{
				return "itemsOptimizeCatItems4";
			}
		}

		// Token: 0x17001E84 RID: 7812
		// (get) Token: 0x0600F6B5 RID: 63157 RVA: 0x003FC2D2 File Offset: 0x003FA4D2
		// (set) Token: 0x0600F6B6 RID: 63158 RVA: 0x003FC2DA File Offset: 0x003FA4DA
		public IItemsItem[] items { get; set; }

		// Token: 0x0600F6B7 RID: 63159 RVA: 0x003FC2E4 File Offset: 0x003FA4E4
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

		// Token: 0x0600F6B8 RID: 63160 RVA: 0x003FC338 File Offset: 0x003FA538
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
