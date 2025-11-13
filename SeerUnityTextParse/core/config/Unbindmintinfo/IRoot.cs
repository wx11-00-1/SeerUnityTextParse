using System;

namespace core.config.Unbindmintinfo
{
	// Token: 0x02001F00 RID: 7936
	public class IRoot
	{
		// Token: 0x17001B05 RID: 6917
		// (get) Token: 0x0600EDAC RID: 60844 RVA: 0x003F1818 File Offset: 0x003EFA18
		// (set) Token: 0x0600EDAD RID: 60845 RVA: 0x003F1820 File Offset: 0x003EFA20
		public IUnbindActivity UnbindActivity { get; set; }

		// Token: 0x0600EDAE RID: 60846 RVA: 0x003F1829 File Offset: 0x003EFA29
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.UnbindActivity = new IUnbindActivity();
				this.UnbindActivity.Parse(bytes, ref byteIndex);
			}
		}
	}
}
