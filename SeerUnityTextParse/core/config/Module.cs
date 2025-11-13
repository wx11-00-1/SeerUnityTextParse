using System;

namespace core.config
{
	// Token: 0x02001D97 RID: 7575
	public class Module : XlsConfigBase<Module, IModuleInfo>
	{
		// Token: 0x17001628 RID: 5672
		// (get) Token: 0x0600DE5A RID: 56922 RVA: 0x003D6B45 File Offset: 0x003D4D45
		public override string fileName
		{
			get
			{
				return "module";
			}
		}

		// Token: 0x0600DE5B RID: 56923 RVA: 0x003D6B4C File Offset: 0x003D4D4C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IModuleInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IModuleInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DE5C RID: 56924 RVA: 0x003D6BA0 File Offset: 0x003D4DA0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
