using System;

namespace core.config.scene_icon
{
	// Token: 0x020024A9 RID: 9385
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17002306 RID: 8966
		// (get) Token: 0x060122B6 RID: 74422 RVA: 0x004B37FC File Offset: 0x004B19FC
		public override string fileName
		{
			get
			{
				return "scene_icon";
			}
		}

		// Token: 0x060122B7 RID: 74423 RVA: 0x004B3803 File Offset: 0x004B1A03
		public void Parse(byte[] bytes, ref int byteIndex)
		{
		}

		// Token: 0x060122B8 RID: 74424 RVA: 0x004B3808 File Offset: 0x004B1A08
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
