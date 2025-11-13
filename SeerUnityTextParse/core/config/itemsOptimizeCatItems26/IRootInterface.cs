using System;

namespace core.config.itemsOptimizeCatItems26
{
	// Token: 0x02001FF4 RID: 8180
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001EA2 RID: 7842
		// (get) Token: 0x0600F715 RID: 63253 RVA: 0x003FC865 File Offset: 0x003FAA65
		public override string fileName
		{
			get
			{
				return "itemsOptimizeCatItems26";
			}
		}

		// Token: 0x17001EA3 RID: 7843
		// (get) Token: 0x0600F716 RID: 63254 RVA: 0x003FC86C File Offset: 0x003FAA6C
		// (set) Token: 0x0600F717 RID: 63255 RVA: 0x003FC874 File Offset: 0x003FAA74
		public IItemsItem[] items { get; set; }

		// Token: 0x0600F718 RID: 63256 RVA: 0x003FC880 File Offset: 0x003FAA80
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

		// Token: 0x0600F719 RID: 63257 RVA: 0x003FC8D4 File Offset: 0x003FAAD4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
