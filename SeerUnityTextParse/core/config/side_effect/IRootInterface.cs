using System;

namespace core.config.side_effect
{
	// Token: 0x0200249F RID: 9375
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x170022D7 RID: 8919
		// (get) Token: 0x06012244 RID: 74308 RVA: 0x004B2FDC File Offset: 0x004B11DC
		public override string fileName
		{
			get
			{
				return "side_effect";
			}
		}

		// Token: 0x170022D8 RID: 8920
		// (get) Token: 0x06012245 RID: 74309 RVA: 0x004B2FE3 File Offset: 0x004B11E3
		// (set) Token: 0x06012246 RID: 74310 RVA: 0x004B2FEB File Offset: 0x004B11EB
		public ISideEffects SideEffects { get; set; }

		// Token: 0x06012247 RID: 74311 RVA: 0x004B2FF4 File Offset: 0x004B11F4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.SideEffects = new ISideEffects();
				this.SideEffects.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x06012248 RID: 74312 RVA: 0x004B3018 File Offset: 0x004B1218
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
