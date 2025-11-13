using System;

namespace core.config.gems
{
	// Token: 0x0200202E RID: 8238
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17002050 RID: 8272
		// (get) Token: 0x0600FB8F RID: 64399 RVA: 0x00400E9A File Offset: 0x003FF09A
		public override string fileName
		{
			get
			{
				return "gems";
			}
		}

		// Token: 0x17002051 RID: 8273
		// (get) Token: 0x0600FB90 RID: 64400 RVA: 0x00400EA1 File Offset: 0x003FF0A1
		// (set) Token: 0x0600FB91 RID: 64401 RVA: 0x00400EA9 File Offset: 0x003FF0A9
		public IGems Gems { get; set; }

		// Token: 0x0600FB92 RID: 64402 RVA: 0x00400EB2 File Offset: 0x003FF0B2
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Gems = new IGems();
				this.Gems.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600FB93 RID: 64403 RVA: 0x00400ED8 File Offset: 0x003FF0D8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
