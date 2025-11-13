using System;

namespace core.config.JackPotShop
{
	// Token: 0x02001FDA RID: 8154
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001E37 RID: 7735
		// (get) Token: 0x0600F5C9 RID: 62921 RVA: 0x003FB479 File Offset: 0x003F9679
		public override string fileName
		{
			get
			{
				return "JackPotShop";
			}
		}

		// Token: 0x17001E38 RID: 7736
		// (get) Token: 0x0600F5CA RID: 62922 RVA: 0x003FB480 File Offset: 0x003F9680
		// (set) Token: 0x0600F5CB RID: 62923 RVA: 0x003FB488 File Offset: 0x003F9688
		public IRoot root { get; set; }

		// Token: 0x0600F5CC RID: 62924 RVA: 0x003FB491 File Offset: 0x003F9691
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600F5CD RID: 62925 RVA: 0x003FB4B4 File Offset: 0x003F96B4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
