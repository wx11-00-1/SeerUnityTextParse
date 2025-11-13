using System;

namespace core.config.mintmark_lottery
{
	// Token: 0x02001FBD RID: 8125
	public class IMenuItem
	{
		// Token: 0x17001DDA RID: 7642
		// (get) Token: 0x0600F4D0 RID: 62672 RVA: 0x003FA170 File Offset: 0x003F8370
		// (set) Token: 0x0600F4D1 RID: 62673 RVA: 0x003FA178 File Offset: 0x003F8378
		public IMintMarkItem[] MintMark { get; set; }

		// Token: 0x17001DDB RID: 7643
		// (get) Token: 0x0600F4D2 RID: 62674 RVA: 0x003FA181 File Offset: 0x003F8381
		// (set) Token: 0x0600F4D3 RID: 62675 RVA: 0x003FA189 File Offset: 0x003F8389
		public int Level { get; set; }

		// Token: 0x0600F4D4 RID: 62676 RVA: 0x003FA194 File Offset: 0x003F8394
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.MintMark = new IMintMarkItem[num];
				for (int i = 0; i < num; i++)
				{
					this.MintMark[i] = new IMintMarkItem();
					this.MintMark[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
