using System;

namespace core.config.petbook_bisaifu
{
	// Token: 0x02001F63 RID: 8035
	public class IRecMintmark
	{
		// Token: 0x17001C5C RID: 7260
		// (get) Token: 0x0600F120 RID: 61728 RVA: 0x003F5ABB File Offset: 0x003F3CBB
		// (set) Token: 0x0600F121 RID: 61729 RVA: 0x003F5AC3 File Offset: 0x003F3CC3
		public IPlaceItem[] place { get; set; }

		// Token: 0x0600F122 RID: 61730 RVA: 0x003F5ACC File Offset: 0x003F3CCC
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
