using System;

namespace core.config.ninjaroom
{
	// Token: 0x02002516 RID: 9494
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17002453 RID: 9299
		// (get) Token: 0x0601262A RID: 75306 RVA: 0x004B7EB3 File Offset: 0x004B60B3
		public override string fileName
		{
			get
			{
				return "ninjaroom";
			}
		}

		// Token: 0x17002454 RID: 9300
		// (get) Token: 0x0601262B RID: 75307 RVA: 0x004B7EBA File Offset: 0x004B60BA
		// (set) Token: 0x0601262C RID: 75308 RVA: 0x004B7EC2 File Offset: 0x004B60C2
		public IRoot root { get; set; }

		// Token: 0x0601262D RID: 75309 RVA: 0x004B7ECB File Offset: 0x004B60CB
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0601262E RID: 75310 RVA: 0x004B7EF0 File Offset: 0x004B60F0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
