using System;

namespace core.config.Unbindmintinfo
{
	// Token: 0x02001F02 RID: 7938
	public class IUnbindActivity
	{
		// Token: 0x17001B08 RID: 6920
		// (get) Token: 0x0600EDB6 RID: 60854 RVA: 0x003F18B0 File Offset: 0x003EFAB0
		// (set) Token: 0x0600EDB7 RID: 60855 RVA: 0x003F18B8 File Offset: 0x003EFAB8
		public IUnbindmintinfoItem[] Unbindmintinfo { get; set; }

		// Token: 0x0600EDB8 RID: 60856 RVA: 0x003F18C4 File Offset: 0x003EFAC4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Unbindmintinfo = new IUnbindmintinfoItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Unbindmintinfo[i] = new IUnbindmintinfoItem();
					this.Unbindmintinfo[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
