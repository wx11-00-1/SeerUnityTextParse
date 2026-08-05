using System;

namespace core.config.itemsOptimizeCatItems29
{
	// Token: 0x02002BDC RID: 11228
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17002CFA RID: 11514
		// (get) Token: 0x06017042 RID: 94274 RVA: 0x005D0BC9 File Offset: 0x005CEDC9
		public override string fileName
		{
			get
			{
				return "itemsOptimizeCatItems29";
			}
		}

		// Token: 0x17002CFB RID: 11515
		// (get) Token: 0x06017043 RID: 94275 RVA: 0x005D0BD0 File Offset: 0x005CEDD0
		// (set) Token: 0x06017044 RID: 94276 RVA: 0x005D0BD8 File Offset: 0x005CEDD8
		public IItemsItem[] items { get; set; }

		// Token: 0x06017045 RID: 94277 RVA: 0x005D0BE4 File Offset: 0x005CEDE4
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

		// Token: 0x06017046 RID: 94278 RVA: 0x005D0C38 File Offset: 0x005CEE38
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
