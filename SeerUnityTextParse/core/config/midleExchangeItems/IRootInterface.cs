using System;

namespace core.config.midleExchangeItems
{
	// Token: 0x02001FCA RID: 8138
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001E12 RID: 7698
		// (get) Token: 0x0600F55A RID: 62810 RVA: 0x003FAC1C File Offset: 0x003F8E1C
		public override string fileName
		{
			get
			{
				return "midleExchangeItems";
			}
		}

		// Token: 0x17001E13 RID: 7699
		// (get) Token: 0x0600F55B RID: 62811 RVA: 0x003FAC23 File Offset: 0x003F8E23
		// (set) Token: 0x0600F55C RID: 62812 RVA: 0x003FAC2B File Offset: 0x003F8E2B
		public IItemsItem[] items { get; set; }

		// Token: 0x0600F55D RID: 62813 RVA: 0x003FAC34 File Offset: 0x003F8E34
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

		// Token: 0x0600F55E RID: 62814 RVA: 0x003FAC88 File Offset: 0x003F8E88
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
