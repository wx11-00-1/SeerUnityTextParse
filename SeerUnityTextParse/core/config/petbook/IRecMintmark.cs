using System;

namespace core.config.petbook
{
	// Token: 0x02001F6E RID: 8046
	public class IRecMintmark
	{
		// Token: 0x17001C80 RID: 7296
		// (get) Token: 0x0600F17E RID: 61822 RVA: 0x003F625E File Offset: 0x003F445E
		// (set) Token: 0x0600F17F RID: 61823 RVA: 0x003F6266 File Offset: 0x003F4466
		public IPlaceItem[] place { get; set; }

		// Token: 0x0600F180 RID: 61824 RVA: 0x003F6270 File Offset: 0x003F4470
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
