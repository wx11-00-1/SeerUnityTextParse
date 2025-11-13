using System;

namespace core.config.effectbuff
{
	// Token: 0x0200205F RID: 8287
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x170020E7 RID: 8423
		// (get) Token: 0x0600FD1F RID: 64799 RVA: 0x00402C22 File Offset: 0x00400E22
		public override string fileName
		{
			get
			{
				return "effectbuff";
			}
		}

		// Token: 0x170020E8 RID: 8424
		// (get) Token: 0x0600FD20 RID: 64800 RVA: 0x00402C29 File Offset: 0x00400E29
		// (set) Token: 0x0600FD21 RID: 64801 RVA: 0x00402C31 File Offset: 0x00400E31
		public IRoot root { get; set; }

		// Token: 0x0600FD22 RID: 64802 RVA: 0x00402C3A File Offset: 0x00400E3A
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600FD23 RID: 64803 RVA: 0x00402C60 File Offset: 0x00400E60
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
