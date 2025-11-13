using System;

namespace core.config.vip_item_shop
{
	// Token: 0x02001EFF RID: 7935
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001B03 RID: 6915
		// (get) Token: 0x0600EDA6 RID: 60838 RVA: 0x003F17BA File Offset: 0x003EF9BA
		public override string fileName
		{
			get
			{
				return "vip_item_shop";
			}
		}

		// Token: 0x17001B04 RID: 6916
		// (get) Token: 0x0600EDA7 RID: 60839 RVA: 0x003F17C1 File Offset: 0x003EF9C1
		// (set) Token: 0x0600EDA8 RID: 60840 RVA: 0x003F17C9 File Offset: 0x003EF9C9
		public IRoot root { get; set; }

		// Token: 0x0600EDA9 RID: 60841 RVA: 0x003F17D2 File Offset: 0x003EF9D2
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600EDAA RID: 60842 RVA: 0x003F17F8 File Offset: 0x003EF9F8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
