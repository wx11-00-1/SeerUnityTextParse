using System;

namespace core.config.item_user_info
{
	// Token: 0x02001FDB RID: 8155
	public class IItemItem
	{
		// Token: 0x17001E39 RID: 7737
		// (get) Token: 0x0600F5CF RID: 62927 RVA: 0x003FB4D4 File Offset: 0x003F96D4
		// (set) Token: 0x0600F5D0 RID: 62928 RVA: 0x003FB4DC File Offset: 0x003F96DC
		public string desc { get; set; }

		// Token: 0x17001E3A RID: 7738
		// (get) Token: 0x0600F5D1 RID: 62929 RVA: 0x003FB4E5 File Offset: 0x003F96E5
		// (set) Token: 0x0600F5D2 RID: 62930 RVA: 0x003FB4ED File Offset: 0x003F96ED
		public int itemid { get; set; }

		// Token: 0x17001E3B RID: 7739
		// (get) Token: 0x0600F5D3 RID: 62931 RVA: 0x003FB4F6 File Offset: 0x003F96F6
		// (set) Token: 0x0600F5D4 RID: 62932 RVA: 0x003FB4FE File Offset: 0x003F96FE
		public int Type { get; set; }

		// Token: 0x0600F5D5 RID: 62933 RVA: 0x003FB507 File Offset: 0x003F9707
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.itemid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
