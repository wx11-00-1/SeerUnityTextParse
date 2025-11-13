using System;

namespace core.config.vip_pet_shop
{
	// Token: 0x02001EF9 RID: 7929
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001AEA RID: 6890
		// (get) Token: 0x0600ED68 RID: 60776 RVA: 0x003F1336 File Offset: 0x003EF536
		public override string fileName
		{
			get
			{
				return "vip_pet_shop";
			}
		}

		// Token: 0x17001AEB RID: 6891
		// (get) Token: 0x0600ED69 RID: 60777 RVA: 0x003F133D File Offset: 0x003EF53D
		// (set) Token: 0x0600ED6A RID: 60778 RVA: 0x003F1345 File Offset: 0x003EF545
		public IRoot root { get; set; }

		// Token: 0x0600ED6B RID: 60779 RVA: 0x003F134E File Offset: 0x003EF54E
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600ED6C RID: 60780 RVA: 0x003F1374 File Offset: 0x003EF574
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
