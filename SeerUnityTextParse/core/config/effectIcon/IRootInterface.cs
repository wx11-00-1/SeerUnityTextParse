using System;

namespace core.config.effectIcon
{
	// Token: 0x02002059 RID: 8281
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x170020D6 RID: 8406
		// (get) Token: 0x0600FCF1 RID: 64753 RVA: 0x004028F6 File Offset: 0x00400AF6
		public override string fileName
		{
			get
			{
				return "effectIcon";
			}
		}

		// Token: 0x170020D7 RID: 8407
		// (get) Token: 0x0600FCF2 RID: 64754 RVA: 0x004028FD File Offset: 0x00400AFD
		// (set) Token: 0x0600FCF3 RID: 64755 RVA: 0x00402905 File Offset: 0x00400B05
		public IRoot root { get; set; }

		// Token: 0x0600FCF4 RID: 64756 RVA: 0x0040290E File Offset: 0x00400B0E
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600FCF5 RID: 64757 RVA: 0x00402934 File Offset: 0x00400B34
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
