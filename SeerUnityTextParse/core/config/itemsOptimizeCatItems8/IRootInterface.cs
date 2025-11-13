using System;

namespace core.config.itemsOptimizeCatItems8
{
	// Token: 0x02001FE8 RID: 8168
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001E54 RID: 7764
		// (get) Token: 0x0600F61F RID: 63007 RVA: 0x003FBA3D File Offset: 0x003F9C3D
		public override string fileName
		{
			get
			{
				return "itemsOptimizeCatItems8";
			}
		}

		// Token: 0x17001E55 RID: 7765
		// (get) Token: 0x0600F620 RID: 63008 RVA: 0x003FBA44 File Offset: 0x003F9C44
		// (set) Token: 0x0600F621 RID: 63009 RVA: 0x003FBA4C File Offset: 0x003F9C4C
		public IItemsItem[] items { get; set; }

		// Token: 0x0600F622 RID: 63010 RVA: 0x003FBA58 File Offset: 0x003F9C58
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

		// Token: 0x0600F623 RID: 63011 RVA: 0x003FBAAC File Offset: 0x003F9CAC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
