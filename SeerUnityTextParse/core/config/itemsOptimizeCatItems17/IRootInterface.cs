using System;

namespace core.config.itemsOptimizeCatItems17
{
	// Token: 0x02002008 RID: 8200
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001F0D RID: 7949
		// (get) Token: 0x0600F85A RID: 63578 RVA: 0x003FDB8D File Offset: 0x003FBD8D
		public override string fileName
		{
			get
			{
				return "itemsOptimizeCatItems17";
			}
		}

		// Token: 0x17001F0E RID: 7950
		// (get) Token: 0x0600F85B RID: 63579 RVA: 0x003FDB94 File Offset: 0x003FBD94
		// (set) Token: 0x0600F85C RID: 63580 RVA: 0x003FDB9C File Offset: 0x003FBD9C
		public IItemsItem[] items { get; set; }

		// Token: 0x0600F85D RID: 63581 RVA: 0x003FDBA8 File Offset: 0x003FBDA8
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

		// Token: 0x0600F85E RID: 63582 RVA: 0x003FDBFC File Offset: 0x003FBDFC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
