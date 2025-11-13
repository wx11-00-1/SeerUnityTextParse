using System;

namespace core.config.Wishsuit
{
	// Token: 0x02001EE5 RID: 7909
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001AAA RID: 6826
		// (get) Token: 0x0600ECC0 RID: 60608 RVA: 0x003F0803 File Offset: 0x003EEA03
		public override string fileName
		{
			get
			{
				return "Wishsuit";
			}
		}

		// Token: 0x17001AAB RID: 6827
		// (get) Token: 0x0600ECC1 RID: 60609 RVA: 0x003F080A File Offset: 0x003EEA0A
		// (set) Token: 0x0600ECC2 RID: 60610 RVA: 0x003F0812 File Offset: 0x003EEA12
		public IWishsuits Wishsuits { get; set; }

		// Token: 0x0600ECC3 RID: 60611 RVA: 0x003F081B File Offset: 0x003EEA1B
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Wishsuits = new IWishsuits();
				this.Wishsuits.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600ECC4 RID: 60612 RVA: 0x003F0840 File Offset: 0x003EEA40
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
