using System;

namespace core.config.itemsOptimizeCatItems24
{
	// Token: 0x02001FF8 RID: 8184
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001EB8 RID: 7864
		// (get) Token: 0x0600F75B RID: 63323 RVA: 0x003FCC6F File Offset: 0x003FAE6F
		public override string fileName
		{
			get
			{
				return "itemsOptimizeCatItems24";
			}
		}

		// Token: 0x17001EB9 RID: 7865
		// (get) Token: 0x0600F75C RID: 63324 RVA: 0x003FCC76 File Offset: 0x003FAE76
		// (set) Token: 0x0600F75D RID: 63325 RVA: 0x003FCC7E File Offset: 0x003FAE7E
		public IItemsItem[] items { get; set; }

		// Token: 0x0600F75E RID: 63326 RVA: 0x003FCC88 File Offset: 0x003FAE88
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

		// Token: 0x0600F75F RID: 63327 RVA: 0x003FCCDC File Offset: 0x003FAEDC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
