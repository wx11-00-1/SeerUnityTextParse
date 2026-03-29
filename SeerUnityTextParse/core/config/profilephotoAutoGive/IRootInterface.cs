using System;

namespace core.config.profilephotoAutoGive
{
	// Token: 0x020024B6 RID: 9398
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17002329 RID: 9001
		// (get) Token: 0x06012316 RID: 74518 RVA: 0x004B3E90 File Offset: 0x004B2090
		public override string fileName
		{
			get
			{
				return "profilephotoAutoGive";
			}
		}

		// Token: 0x06012317 RID: 74519 RVA: 0x004B3E97 File Offset: 0x004B2097
		public void Parse(byte[] bytes, ref int byteIndex)
		{
		}

		// Token: 0x06012318 RID: 74520 RVA: 0x004B3E9C File Offset: 0x004B209C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
