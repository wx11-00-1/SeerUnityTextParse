using System;

namespace core.config.bossEffectIcon
{
	// Token: 0x02002062 RID: 8290
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x170020F0 RID: 8432
		// (get) Token: 0x0600FD37 RID: 64823 RVA: 0x00402DC6 File Offset: 0x00400FC6
		public override string fileName
		{
			get
			{
				return "bossEffectIcon";
			}
		}

		// Token: 0x170020F1 RID: 8433
		// (get) Token: 0x0600FD38 RID: 64824 RVA: 0x00402DCD File Offset: 0x00400FCD
		// (set) Token: 0x0600FD39 RID: 64825 RVA: 0x00402DD5 File Offset: 0x00400FD5
		public IRoot root { get; set; }

		// Token: 0x0600FD3A RID: 64826 RVA: 0x00402DDE File Offset: 0x00400FDE
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600FD3B RID: 64827 RVA: 0x00402E04 File Offset: 0x00401004
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
