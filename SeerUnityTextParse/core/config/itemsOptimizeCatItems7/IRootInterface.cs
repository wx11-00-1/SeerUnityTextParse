using System;

namespace core.config.itemsOptimizeCatItems7
{
	// Token: 0x02001FEA RID: 8170
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001E60 RID: 7776
		// (get) Token: 0x0600F645 RID: 63045 RVA: 0x003FBC69 File Offset: 0x003F9E69
		public override string fileName
		{
			get
			{
				return "itemsOptimizeCatItems7";
			}
		}

		// Token: 0x17001E61 RID: 7777
		// (get) Token: 0x0600F646 RID: 63046 RVA: 0x003FBC70 File Offset: 0x003F9E70
		// (set) Token: 0x0600F647 RID: 63047 RVA: 0x003FBC78 File Offset: 0x003F9E78
		public IItemsItem[] items { get; set; }

		// Token: 0x0600F648 RID: 63048 RVA: 0x003FBC84 File Offset: 0x003F9E84
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

		// Token: 0x0600F649 RID: 63049 RVA: 0x003FBCD8 File Offset: 0x003F9ED8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
