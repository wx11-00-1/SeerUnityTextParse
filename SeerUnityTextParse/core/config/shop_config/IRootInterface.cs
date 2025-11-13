using System;

namespace core.config.shop_config
{
	// Token: 0x02001F29 RID: 7977
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001BAA RID: 7082
		// (get) Token: 0x0600EF48 RID: 61256 RVA: 0x003F36CA File Offset: 0x003F18CA
		public override string fileName
		{
			get
			{
				return "shop_config";
			}
		}

		// Token: 0x17001BAB RID: 7083
		// (get) Token: 0x0600EF49 RID: 61257 RVA: 0x003F36D1 File Offset: 0x003F18D1
		// (set) Token: 0x0600EF4A RID: 61258 RVA: 0x003F36D9 File Offset: 0x003F18D9
		public IRoot root { get; set; }

		// Token: 0x0600EF4B RID: 61259 RVA: 0x003F36E2 File Offset: 0x003F18E2
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600EF4C RID: 61260 RVA: 0x003F3708 File Offset: 0x003F1908
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
