using System;

namespace core.config.newguideStep2020
{
	// Token: 0x0200252D RID: 9517
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x170024B2 RID: 9394
		// (get) Token: 0x06012716 RID: 75542 RVA: 0x004B93E6 File Offset: 0x004B75E6
		public override string fileName
		{
			get
			{
				return "newguideStep2020";
			}
		}

		// Token: 0x170024B3 RID: 9395
		// (get) Token: 0x06012717 RID: 75543 RVA: 0x004B93ED File Offset: 0x004B75ED
		// (set) Token: 0x06012718 RID: 75544 RVA: 0x004B93F5 File Offset: 0x004B75F5
		public IRoot root { get; set; }

		// Token: 0x06012719 RID: 75545 RVA: 0x004B93FE File Offset: 0x004B75FE
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0601271A RID: 75546 RVA: 0x004B9424 File Offset: 0x004B7624
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
