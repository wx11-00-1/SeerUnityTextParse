using System;

namespace core.config.redbutton
{
	// Token: 0x020024B2 RID: 9394
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x1700231D RID: 8989
		// (get) Token: 0x060122F6 RID: 74486 RVA: 0x004B3C6A File Offset: 0x004B1E6A
		public override string fileName
		{
			get
			{
				return "redbutton";
			}
		}

		// Token: 0x1700231E RID: 8990
		// (get) Token: 0x060122F7 RID: 74487 RVA: 0x004B3C71 File Offset: 0x004B1E71
		// (set) Token: 0x060122F8 RID: 74488 RVA: 0x004B3C79 File Offset: 0x004B1E79
		public IRoot root { get; set; }

		// Token: 0x060122F9 RID: 74489 RVA: 0x004B3C82 File Offset: 0x004B1E82
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x060122FA RID: 74490 RVA: 0x004B3CA8 File Offset: 0x004B1EA8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
