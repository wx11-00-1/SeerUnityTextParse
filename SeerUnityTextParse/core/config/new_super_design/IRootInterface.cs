using System;

namespace core.config.new_super_design
{
	// Token: 0x02001F8A RID: 8074
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001CCB RID: 7371
		// (get) Token: 0x0600F24C RID: 62028 RVA: 0x003F71F2 File Offset: 0x003F53F2
		public override string fileName
		{
			get
			{
				return "new_super_design";
			}
		}

		// Token: 0x17001CCC RID: 7372
		// (get) Token: 0x0600F24D RID: 62029 RVA: 0x003F71F9 File Offset: 0x003F53F9
		// (set) Token: 0x0600F24E RID: 62030 RVA: 0x003F7201 File Offset: 0x003F5401
		public IRoot Root { get; set; }

		// Token: 0x0600F24F RID: 62031 RVA: 0x003F720A File Offset: 0x003F540A
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Root = new IRoot();
				this.Root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600F250 RID: 62032 RVA: 0x003F7230 File Offset: 0x003F5430
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
