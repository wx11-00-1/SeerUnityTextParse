using System;

namespace core.config.midleItems
{
	// Token: 0x02001FC7 RID: 8135
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001E06 RID: 7686
		// (get) Token: 0x0600F53C RID: 62780 RVA: 0x003FA9F1 File Offset: 0x003F8BF1
		public override string fileName
		{
			get
			{
				return "midleItems";
			}
		}

		// Token: 0x17001E07 RID: 7687
		// (get) Token: 0x0600F53D RID: 62781 RVA: 0x003FA9F8 File Offset: 0x003F8BF8
		// (set) Token: 0x0600F53E RID: 62782 RVA: 0x003FAA00 File Offset: 0x003F8C00
		public IItemsItem[] items { get; set; }

		// Token: 0x0600F53F RID: 62783 RVA: 0x003FAA0C File Offset: 0x003F8C0C
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

		// Token: 0x0600F540 RID: 62784 RVA: 0x003FAA60 File Offset: 0x003F8C60
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
