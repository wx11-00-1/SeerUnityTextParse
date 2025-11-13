using System;

namespace core.config.Fragment
{
	// Token: 0x02002035 RID: 8245
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17002067 RID: 8295
		// (get) Token: 0x0600FBCB RID: 64459 RVA: 0x0040127A File Offset: 0x003FF47A
		public override string fileName
		{
			get
			{
				return "Fragment";
			}
		}

		// Token: 0x17002068 RID: 8296
		// (get) Token: 0x0600FBCC RID: 64460 RVA: 0x00401281 File Offset: 0x003FF481
		// (set) Token: 0x0600FBCD RID: 64461 RVA: 0x00401289 File Offset: 0x003FF489
		public IRoot Root { get; set; }

		// Token: 0x0600FBCE RID: 64462 RVA: 0x00401292 File Offset: 0x003FF492
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Root = new IRoot();
				this.Root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600FBCF RID: 64463 RVA: 0x004012B8 File Offset: 0x003FF4B8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
