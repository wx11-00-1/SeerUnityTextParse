using System;

namespace core.config.skin_shop
{
	// Token: 0x02001F1F RID: 7967
	public class ISkins
	{
		// Token: 0x17001B6E RID: 7022
		// (get) Token: 0x0600EEBC RID: 61116 RVA: 0x003F2BB2 File Offset: 0x003F0DB2
		// (set) Token: 0x0600EEBD RID: 61117 RVA: 0x003F2BBA File Offset: 0x003F0DBA
		public ISkinItem[] Skin { get; set; }

		// Token: 0x0600EEBE RID: 61118 RVA: 0x003F2BC4 File Offset: 0x003F0DC4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Skin = new ISkinItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Skin[i] = new ISkinItem();
					this.Skin[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
