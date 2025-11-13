using System;

namespace core.config.medals
{
	// Token: 0x02001FCE RID: 8142
	public class IMedals
	{
		// Token: 0x17001E19 RID: 7705
		// (get) Token: 0x0600F575 RID: 62837 RVA: 0x003FAE59 File Offset: 0x003F9059
		// (set) Token: 0x0600F576 RID: 62838 RVA: 0x003FAE61 File Offset: 0x003F9061
		public IMedalItem[] medal { get; set; }

		// Token: 0x0600F577 RID: 62839 RVA: 0x003FAE6C File Offset: 0x003F906C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.medal = new IMedalItem[num];
				for (int i = 0; i < num; i++)
				{
					this.medal[i] = new IMedalItem();
					this.medal[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
