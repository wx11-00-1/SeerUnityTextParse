using System;

namespace core.config.open_bonus
{
	// Token: 0x02001F80 RID: 8064
	public class IRoot
	{
		// Token: 0x17001CA3 RID: 7331
		// (get) Token: 0x0600F1E8 RID: 61928 RVA: 0x003F6A4F File Offset: 0x003F4C4F
		// (set) Token: 0x0600F1E9 RID: 61929 RVA: 0x003F6A57 File Offset: 0x003F4C57
		public IBonusItem[] Bonus { get; set; }

		// Token: 0x0600F1EA RID: 61930 RVA: 0x003F6A60 File Offset: 0x003F4C60
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Bonus = new IBonusItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Bonus[i] = new IBonusItem();
					this.Bonus[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
