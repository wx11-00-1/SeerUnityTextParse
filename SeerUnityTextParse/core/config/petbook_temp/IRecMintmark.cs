using System;

namespace core.config.petbook_temp
{
	// Token: 0x02001F58 RID: 8024
	public class IRecMintmark
	{
		// Token: 0x17001C38 RID: 7224
		// (get) Token: 0x0600F0C2 RID: 61634 RVA: 0x003F531E File Offset: 0x003F351E
		// (set) Token: 0x0600F0C3 RID: 61635 RVA: 0x003F5326 File Offset: 0x003F3526
		public IPlaceItem[] place { get; set; }

		// Token: 0x0600F0C4 RID: 61636 RVA: 0x003F5330 File Offset: 0x003F3530
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.place = new IPlaceItem[num];
				for (int i = 0; i < num; i++)
				{
					this.place[i] = new IPlaceItem();
					this.place[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
