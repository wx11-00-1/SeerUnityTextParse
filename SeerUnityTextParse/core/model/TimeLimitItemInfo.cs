using System;
using common;
using core.config;

namespace core.model
{
	// Token: 0x02001983 RID: 6531
	public class TimeLimitItemInfo
	{
		// Token: 0x0600CCDD RID: 52445 RVA: 0x003B6690 File Offset: 0x003B4890
		public TimeLimitItemInfo(ByteArray data = null)
		{
			if (data != null)
			{
				this.itemID = (int)data.ReadUnsignedInt();
				this.overTime = (int)data.ReadUnsignedInt();
				this.itemNum = (int)data.ReadUnsignedInt();
				this.rarity = ResetableSingleTon<ItemXMLInfo>.Ins.getRarity(this.itemID);
			}
		}

		// Token: 0x0400E351 RID: 58193
		public int itemID;

		// Token: 0x0400E352 RID: 58194
		public int overTime;

		// Token: 0x0400E353 RID: 58195
		public int itemNum;

		// Token: 0x0400E354 RID: 58196
		public int rarity;
	}
}
