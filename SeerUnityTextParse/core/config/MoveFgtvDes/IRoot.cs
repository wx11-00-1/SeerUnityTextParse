using System;

namespace core.config.MoveFgtvDes
{
	// Token: 0x02001FAB RID: 8107
	public class IRoot
	{
		// Token: 0x17001D5F RID: 7519
		// (get) Token: 0x0600F3B6 RID: 62390 RVA: 0x003F8D7E File Offset: 0x003F6F7E
		// (set) Token: 0x0600F3B7 RID: 62391 RVA: 0x003F8D86 File Offset: 0x003F6F86
		public IMoveItem[] Move { get; set; }

		// Token: 0x0600F3B8 RID: 62392 RVA: 0x003F8D90 File Offset: 0x003F6F90
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Move = new IMoveItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Move[i] = new IMoveItem();
					this.Move[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
