using System;

namespace core.config.itemType
{
	// Token: 0x02001FDE RID: 8158
	public class IItemItem
	{
		// Token: 0x17001E3F RID: 7743
		// (get) Token: 0x0600F5E1 RID: 62945 RVA: 0x003FB608 File Offset: 0x003F9808
		// (set) Token: 0x0600F5E2 RID: 62946 RVA: 0x003FB610 File Offset: 0x003F9810
		public int ID { get; set; }

		// Token: 0x0600F5E3 RID: 62947 RVA: 0x003FB619 File Offset: 0x003F9819
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
