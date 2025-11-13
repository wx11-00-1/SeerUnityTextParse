using System;

namespace core.config.itemsOptimizeCatItems13
{
	// Token: 0x02002010 RID: 8208
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001F3B RID: 7995
		// (get) Token: 0x0600F8E8 RID: 63720 RVA: 0x003FE3CE File Offset: 0x003FC5CE
		public override string fileName
		{
			get
			{
				return "itemsOptimizeCatItems13";
			}
		}

		// Token: 0x17001F3C RID: 7996
		// (get) Token: 0x0600F8E9 RID: 63721 RVA: 0x003FE3D5 File Offset: 0x003FC5D5
		// (set) Token: 0x0600F8EA RID: 63722 RVA: 0x003FE3DD File Offset: 0x003FC5DD
		public IItemsItem[] items { get; set; }

		// Token: 0x0600F8EB RID: 63723 RVA: 0x003FE3E8 File Offset: 0x003FC5E8
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

		// Token: 0x0600F8EC RID: 63724 RVA: 0x003FE43C File Offset: 0x003FC63C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
