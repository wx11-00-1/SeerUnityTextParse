using System;

namespace core.config.new_super_design
{
	// Token: 0x02001F8C RID: 8076
	public class IRules
	{
		// Token: 0x17001CD4 RID: 7380
		// (get) Token: 0x0600F262 RID: 62050 RVA: 0x003F735B File Offset: 0x003F555B
		// (set) Token: 0x0600F263 RID: 62051 RVA: 0x003F7363 File Offset: 0x003F5563
		public IRuleItem[] Rule { get; set; }

		// Token: 0x0600F264 RID: 62052 RVA: 0x003F736C File Offset: 0x003F556C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Rule = new IRuleItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Rule[i] = new IRuleItem();
					this.Rule[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
