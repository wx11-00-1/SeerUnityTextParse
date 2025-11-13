using System;

namespace core.config.map_config
{
	// Token: 0x02001FD6 RID: 8150
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001E26 RID: 7718
		// (get) Token: 0x0600F59F RID: 62879 RVA: 0x003FB192 File Offset: 0x003F9392
		public override string fileName
		{
			get
			{
				return "map_config";
			}
		}

		// Token: 0x17001E27 RID: 7719
		// (get) Token: 0x0600F5A0 RID: 62880 RVA: 0x003FB199 File Offset: 0x003F9399
		// (set) Token: 0x0600F5A1 RID: 62881 RVA: 0x003FB1A1 File Offset: 0x003F93A1
		public IMaps Maps { get; set; }

		// Token: 0x0600F5A2 RID: 62882 RVA: 0x003FB1AA File Offset: 0x003F93AA
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Maps = new IMaps();
				this.Maps.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600F5A3 RID: 62883 RVA: 0x003FB1D0 File Offset: 0x003F93D0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
