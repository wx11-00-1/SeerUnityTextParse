using System;

namespace core.config.LockedSpaceMapConfig
{
	// Token: 0x02002581 RID: 9601
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x1700262D RID: 9773
		// (get) Token: 0x06012AB9 RID: 76473 RVA: 0x004BE0A6 File Offset: 0x004BC2A6
		public override string fileName
		{
			get
			{
				return "LockedSpaceMapConfig";
			}
		}

		// Token: 0x1700262E RID: 9774
		// (get) Token: 0x06012ABA RID: 76474 RVA: 0x004BE0AD File Offset: 0x004BC2AD
		// (set) Token: 0x06012ABB RID: 76475 RVA: 0x004BE0B5 File Offset: 0x004BC2B5
		public IRoot root { get; set; }

		// Token: 0x06012ABC RID: 76476 RVA: 0x004BE0BE File Offset: 0x004BC2BE
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x06012ABD RID: 76477 RVA: 0x004BE0E4 File Offset: 0x004BC2E4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
