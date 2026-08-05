using System;

namespace core.config.itemsOptimizeCatItems28
{
	// Token: 0x02002BDE RID: 11230
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17002D0E RID: 11534
		// (get) Token: 0x0601706E RID: 94318 RVA: 0x005D0E99 File Offset: 0x005CF099
		public override string fileName
		{
			get
			{
				return "itemsOptimizeCatItems28";
			}
		}

		// Token: 0x17002D0F RID: 11535
		// (get) Token: 0x0601706F RID: 94319 RVA: 0x005D0EA0 File Offset: 0x005CF0A0
		// (set) Token: 0x06017070 RID: 94320 RVA: 0x005D0EA8 File Offset: 0x005CF0A8
		public IItemsItem[] items { get; set; }

		// Token: 0x06017071 RID: 94321 RVA: 0x005D0EB4 File Offset: 0x005CF0B4
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

		// Token: 0x06017072 RID: 94322 RVA: 0x005D0F08 File Offset: 0x005CF108
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
