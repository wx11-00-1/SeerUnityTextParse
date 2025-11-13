using System;

namespace core.config.Monsterpool
{
	// Token: 0x02001FBB RID: 8123
	public class IRoot
	{
		// Token: 0x17001DD7 RID: 7639
		// (get) Token: 0x0600F4C6 RID: 62662 RVA: 0x003FA0A7 File Offset: 0x003F82A7
		// (set) Token: 0x0600F4C7 RID: 62663 RVA: 0x003FA0AF File Offset: 0x003F82AF
		public IPoolItem[] Pool { get; set; }

		// Token: 0x0600F4C8 RID: 62664 RVA: 0x003FA0B8 File Offset: 0x003F82B8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Pool = new IPoolItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Pool[i] = new IPoolItem();
					this.Pool[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
