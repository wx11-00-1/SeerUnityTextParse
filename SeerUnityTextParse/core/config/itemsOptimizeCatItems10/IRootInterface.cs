using System;

namespace core.config.itemsOptimizeCatItems10
{
	// Token: 0x02002016 RID: 8214
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001F62 RID: 8034
		// (get) Token: 0x0600F964 RID: 63844 RVA: 0x003FEABD File Offset: 0x003FCCBD
		public override string fileName
		{
			get
			{
				return "itemsOptimizeCatItems10";
			}
		}

		// Token: 0x17001F63 RID: 8035
		// (get) Token: 0x0600F965 RID: 63845 RVA: 0x003FEAC4 File Offset: 0x003FCCC4
		// (set) Token: 0x0600F966 RID: 63846 RVA: 0x003FEACC File Offset: 0x003FCCCC
		public IItemsItem[] items { get; set; }

		// Token: 0x0600F967 RID: 63847 RVA: 0x003FEAD8 File Offset: 0x003FCCD8
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

		// Token: 0x0600F968 RID: 63848 RVA: 0x003FEB2C File Offset: 0x003FCD2C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
