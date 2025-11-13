using System;

namespace core.model
{
	// Token: 0x02001977 RID: 6519
	public class SoulBeadItemInfo : SingleItemInfo
	{
		// Token: 0x0600CC86 RID: 52358 RVA: 0x003B5C7C File Offset: 0x003B3E7C
		public SoulBeadItemInfo(ByteArray data = null)
		{
			this.obtainTime = (int)data.ReadUnsignedInt();
			base.itemID = (int)data.ReadUnsignedInt();
			this.m_type = ItemType.SOULBEAD;
			this.leftTime = 31536000U;
			this.itemNum = 1U;
			this.updateTime = (uint)this.obtainTime;
		}

		// Token: 0x0400E2E9 RID: 58089
		public int obtainTime;
	}
}
